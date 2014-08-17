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
    public partial class PARTS : Form
    {
        public PARTS()
        {
            InitializeComponent();
        }

        private void VehicleButton_Click(object sender, EventArgs e)
        {
            mainForm mainFormObj = new mainForm();
            mainFormObj.Show();
            this.Hide();
        }

        private void partsutton_Click(object sender, EventArgs e)
        {
            PARTS partsFormObj = new PARTS();
            this.Show();

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
            this.Hide();

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            partsNameTextBox.Clear();
            partsNumberTextBox.Clear();
            partsPriceTextBox.Clear();
            partsQuentityTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PartsInformationClass partsObj = new PartsInformationClass();
            partsObj.PartsName = partsNameTextBox.Text;
            partsObj.PartsNumber = partsNumberTextBox.Text;
            partsObj.PartsPrice = partsPriceTextBox.Text;
            partsObj.PartsQuentity = partsQuentityTextBox.Text;

            PartsInformationGetway partObg = new PartsInformationGetway();
            partObg.storePartsInformation(partsObj);

         
            MessageBox.Show("Information Save");

          
        }

        private void sarchButton_Click(object sender, EventArgs e)
        {
            string partsNumbe;
            partsNumbe = sarchPartsNumberTextBox.Text;
            PartsInformationClass parts=null;
            List<PartsInformationClass> partses = new List<PartsInformationClass>();
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string queryString = "SELECT * FROM partsInformationTable WHERE partsNumber='"+partsNumbe+"'";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                parts = new PartsInformationClass();
                parts.PartsName = (reader["partsName"]).ToString();
                partsNameTextBox.Text = (reader["partsName"]).ToString();
                parts.PartsNumber = (reader["partsNumber"]).ToString();
                partsNumberTextBox.Text = (reader["partsNumber"]).ToString();
                parts.PartsPrice = (reader["partsPrice"]).ToString();
                partsPriceTextBox.Text = (reader["partsPrice"]).ToString();
                parts.PartsQuentity = (reader["partsQuentity"]).ToString();
                partsQuentityTextBox.Text = (reader["partsQuentity"]).ToString();
                
            }
            
           
            
           
            MessageBox.Show("PrtsName=" + parts.PartsName + "\npartsNumber" + parts.PartsNumber + "\npartsPrice" + parts.PartsPrice + "\npartsQuentity" + parts.PartsQuentity);
            connection.Close();

        

        
        
        }

        private void showListviewButton_Click(object sender, EventArgs e)
        {
            partsListView.Items.Clear();
            List<PartsInformationClass> partsess = new List<PartsInformationClass>();
            PartsInformationGetway parts = new PartsInformationGetway();
            partsess = parts.GetpartInnformation();

            foreach (PartsInformationClass partsOb in partsess)
            {
                ListViewItem partlist = new ListViewItem(partsOb.PartsName);
                partlist.SubItems.Add(partsOb.PartsNumber);
                partlist.SubItems.Add(partsOb.PartsPrice);
                partlist.SubItems.Add(partsOb.PartsQuentity);
                partsListView.Items.Add(partlist);
            }
        }

        private void deletButton_Click(object sender, EventArgs e)
        {
            string partsNumbe;
            partsNumbe = sarchPartsNumberTextBox.Text;
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString = "Delete  From partsInformationTable Where partsNumber='" + partsNumbe + "'";
 
            SqlCommand command = new SqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("delet complet");
           
            
        }

        private void roadpermitButton_Click(object sender, EventArgs e)
        {
            roadParmit roadper = new roadParmit();
            this.Hide();
            roadper.Show();
        } 
    }
}
