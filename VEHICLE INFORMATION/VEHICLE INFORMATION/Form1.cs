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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            mainForm mainFormObj = new mainForm();
            //mainFormObj.Show();
            this.Show();
        }

        private void partButton_Click(object sender, EventArgs e)
        {
            PARTS partsFormObj = new PARTS();
            partsFormObj.Show();
            this.Hide();
        }

        private void personalButton_Click(object sender, EventArgs e)
        {
            PERSON personObj = new PERSON();
            personObj.Show();
            this.Hide();
        }

        private void vendorButton_Click(object sender, EventArgs e)
        {
            vendorsForm vendosrFormobj = new vendorsForm();
            vendosrFormobj.Show();
            this.Hide();

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            vehicleAccountTextBox.Clear();
            vehicleCompnyTextBox.Clear();
            vehicleEnginNumberYextBox.Clear();
            vehicleModelNumberTextBox.Clear();
            vehicleModelYearTextBox.Clear();
            vehicleNumberTextBox.Clear();
            vehicleTranansmistionTextBox.Clear();
            vehicleTrilSizeTextBox.Clear();
            vehicleVenNumTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            VehicleInformationClass vehicleObj = new VehicleInformationClass();
            vehicleObj.ModelYear = vehicleModelYearTextBox.Text;
            vehicleObj.Department = departmentCcomboBox.Text;
            vehicleObj.VinNumber = vehicleVenNumTextBox.Text;
            vehicleObj.VehicleNumber = vehicleNumberTextBox.Text;
            vehicleObj.Colour = colorComboBox.Text;
            vehicleObj.ModelNumber = vehicleModelNumberTextBox.Text;
            vehicleObj.EnginNumber = vehicleEnginNumberYextBox.Text;
            vehicleObj.Transmistion = vehicleTranansmistionTextBox.Text;
            vehicleObj.TrialSize = vehicleTrilSizeTextBox.Text;
            vehicleObj.CompanyName = vehicleCompnyTextBox.Text;
            vehicleObj.AccountNumber = vehicleAccountTextBox.Text;

            VehicleInformationGetway vehicleStObj = new VehicleInformationGetway();
            vehicleStObj.saveVehicleInformation(vehicleObj);
            
            MessageBox.Show("The information Save ");


        }

        private void vehicleSarchButton_Click(object sender, EventArgs e)
        {
            string vinNumberOf;
            vinNumberOf = vehicleSarchTextBox.Text;
            VehicleInformationClass vehicleObjc = null;
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString="SELECT * FROM vehicleInformationTabl WHERE vinNumber='"+vinNumberOf+"'";
            SqlCommand command=new SqlCommand(queryString,connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                vehicleObjc = new VehicleInformationClass();
                vehicleObjc.ModelYear = (reader["modelYear"]).ToString();
                vehicleModelYearTextBox.Text = (reader["modelYear"]).ToString();
                vehicleObjc.Department = (reader["department"]).ToString();
                departmentCcomboBox.Text = (reader["department"]).ToString();
                vehicleObjc.VinNumber = (reader["vinNumber"]).ToString();
                vehicleVenNumTextBox.Text = (reader["vinNumber"]).ToString();
                vehicleObjc.VehicleNumber = (reader["vehicleNumber"]).ToString();
                vehicleNumberTextBox.Text = (reader["vehicleNumber"]).ToString();
                vehicleObjc.Colour = (reader["colour"]).ToString();
                colorComboBox.Text = (reader["colour"]).ToString();
                vehicleObjc.ModelNumber = (reader["modelNumber"]).ToString();
                vehicleModelNumberTextBox.Text = (reader["modelNumber"]).ToString();
                vehicleObjc.EnginNumber = (reader["enginNumber"]).ToString();
                vehicleEnginNumberYextBox.Text = (reader["enginNumber"]).ToString();
                vehicleObjc.Transmistion = (reader["Transmistion"]).ToString();
                vehicleTranansmistionTextBox.Text = (reader["Transmistion"]).ToString();
                vehicleObjc.TrialSize = (reader["trialSize"]).ToString();
                vehicleTrilSizeTextBox.Text = (reader["trialSize"]).ToString();
                vehicleObjc.CompanyName = (reader["companyName"]).ToString();
                vehicleCompnyTextBox.Text = (reader["companyName"]).ToString();
                vehicleObjc.AccountNumber = (reader["accountNumber"]).ToString();
                vehicleAccountTextBox.Text = (reader["accountNumber"]).ToString();

            }
            MessageBox.Show("modeYear=" + vehicleObjc.ModelYear + "\n vinNumber=" + vehicleObjc.VinNumber + "\n vehicleNumber=" + vehicleObjc.VehicleNumber +  "\n modelNumber=" + vehicleObjc.ModelNumber + "\n enginNumber" + vehicleObjc.EnginNumber + "\n Transmistion" + vehicleObjc.Transmistion + "\n trialSize" + vehicleObjc.TrialSize + "\n companyName" + vehicleObjc.CompanyName + "\n accountNumber" + vehicleObjc.AccountNumber);
            connection.Close();
      
          
           
               
                
            }

        private void showListBoxButton_Click(object sender, EventArgs e)
        {
            vehicleListView.Items.Clear();
            List<VehicleInformationClass> vehicleses = new List<VehicleInformationClass>();
            VehicleInformationGetway vehiclObj = new VehicleInformationGetway();
            vehicleses = vehiclObj.GetVendorInformation();

            foreach (VehicleInformationClass vehicleOj in vehicleses)
            {
                ListViewItem vehiclList = new ListViewItem(vehicleOj.ModelYear);
                vehiclList.SubItems.Add(vehicleOj.Department);
                vehiclList.SubItems.Add(vehicleOj.VinNumber);
                vehiclList.SubItems.Add(vehicleOj.VehicleNumber);
                vehiclList.SubItems.Add(vehicleOj.Colour);
                vehiclList.SubItems.Add(vehicleOj.ModelNumber);
                vehiclList.SubItems.Add(vehicleOj.EnginNumber);
                vehiclList.SubItems.Add(vehicleOj.Transmistion);
                vehiclList.SubItems.Add(vehicleOj.TrialSize);
                vehiclList.SubItems.Add(vehicleOj.CompanyName);
                vehiclList.SubItems.Add(vehicleOj.AccountNumber);
                vehicleListView.Items.Add(vehiclList);
            }
        }

        private void deletButton_Click(object sender, EventArgs e)
        {
            string vinNumber;
            vinNumber = vehicleSarchTextBox.Text;
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString = "Delete  From vehicleInformationTabl Where vinNumber='" + vinNumber + "'";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("delet complet");
        }

        private void roadPermitButton_Click(object sender, EventArgs e)
        {
            roadParmit roadObj = new roadParmit();
            this.Hide();
            roadObj.Show();
        }
  

        }

    }

        
    

