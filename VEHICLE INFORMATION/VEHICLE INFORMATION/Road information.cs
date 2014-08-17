using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VEHICLE_INFORMATION
{
    public partial class roadParmit : Form
    {
        public roadParmit()
        {
            InitializeComponent();
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            mainForm mainFormObj = new mainForm();
            mainFormObj.Show();
            this.Hide();
        }

        private void partsButton_Click(object sender, EventArgs e)
        {
            PARTS partsFormObj = new PARTS();
            partsFormObj.Show();
            this.Hide();
        }

        private void personButton_Click(object sender, EventArgs e)
        {
            PERSON personObj = new PERSON();
            personObj.Show();
            this.Hide();
        }

        private void vendorsButton_Click(object sender, EventArgs e)
        {
            vendorsForm vendosrFormobj = new vendorsForm();
            vendosrFormobj.Show();
            this.Show();
        }

        private void roadParmitButton_Click(object sender, EventArgs e)
        {
            roadParmit roadp = new roadParmit();
            this.Hide();
            roadp.Show();
        }

        private void roadSaveButton_Click(object sender, EventArgs e)
        {
            roadPermitClass roadPermitObj = new roadPermitClass();
            roadPermitObj.TypeOfCar = typeOfCarComboBox.Text;
            roadPermitObj.CarId = carIdTextBox.Text;
            roadPermitObj.CarLisenceNumber = carLisenceNumbertextBox.Text;
            roadPermitObj.RoadPermit = carRoadPermitTextBox.Text;
            roadInformationGetway getway = new roadInformationGetway();
            getway.saveRoadInformation(roadPermitObj);

            MessageBox.Show("inforMation Save");

           
           

           
        }

        private void roadDeleteButton_Click(object sender, EventArgs e)
        {
            string lisenceNumber;
            lisenceNumber = searchLisenceTextBox.Text;
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString = "Delete  From roadInformationTable Where carLisenceNumber='" + lisenceNumber + "'";
            SqlCommand command = new SqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("delet complet");
           
            
           
              
        }

        private void roadSarchButton_Click(object sender, EventArgs e)
        {
          
           
        
            string lisenceNumber;
            lisenceNumber = searchLisenceTextBox.Text;
            roadPermitClass roadObj=null;
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            string queryString = "SELECT * FROM roadInformationTable WHERE CarlisenceNumber='" + lisenceNumber + "'";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
    while (reader.Read())
            {
                roadObj = new roadPermitClass();
                roadObj.TypeOfCar = (reader["typeOfCar"]).ToString();
                typeOfCarComboBox.Text = (reader["typeOfCar"]).ToString();
                roadObj.CarId = (reader["carId"]).ToString();
                carIdTextBox.Text = (reader["carId"]).ToString();
                roadObj.CarLisenceNumber = (reader["carLisenceNumber"]).ToString();
                carLisenceNumbertextBox.Text = (reader["carLisenceNumber"]).ToString();
                roadObj.RoadPermit = (reader["roadPermit"]).ToString();
                carRoadPermitTextBox.Text = (reader["roadPermit"]).ToString();
        
            }
            MessageBox.Show("typeOfCar="+roadObj.TypeOfCar+"\n carId="+roadObj.CarId+"\n carLisenceNumber="+roadObj.CarLisenceNumber+"\n \n roadPermit:"+roadObj.RoadPermit);
                
             connection.Close();

            }

        private void roadNewButton_Click(object sender, EventArgs e)
        {
           
                carIdTextBox.Clear();
                carLisenceNumbertextBox.Clear();
                carRoadPermitTextBox.Clear();

        }

        private void showCarNameAndIdButton_Click(object sender, EventArgs e)
        {
            
            string roadpermitserch;
            roadpermitserch=showRoadPermitTextBox.Text;
             string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            
            string queryString = "SELECT  FROM roadInformationTable WHERE roadPermit='"+roadpermitserch+"'" ;
            SqlCommand command = new SqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            List<roadPermitClass> rodPer = new List<roadPermitClass>();
            roadInformationGetway roadGet = new roadInformationGetway();
            rodPer = roadGet.GetRoadInformation();
            carNameAndIdlistView.Items.Clear();
            foreach (roadPermitClass roadObj in rodPer)
            {
                ListViewItem roadList = new ListViewItem(roadObj.CarId);
                roadList.SubItems.Add(roadObj.CarLisenceNumber);
                carNameAndIdlistView.Items.Add(roadList);
            }
            connection.Close();
           
        }
           

        }

     
    }

