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
    public partial class vendorsForm : Form
    {
        public vendorsForm()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            vendorsForm vendosrFormobj = new vendorsForm();
            vendosrFormobj.Show();
            this.Show();

        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            mainForm mainFormObj = new mainForm();
            mainFormObj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void newButton_Click(object sender, EventArgs e)
        {
            vendorsNameTextBox.Clear();
            vendorsPotalCodTextBox.Clear();
            vendorsStreetTextBox.Clear();
            vendosCityTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            VendorInformationClass vendorsObj = new VendorInformationClass();
            vendorsObj.VendorsName = vendorsNameTextBox.Text;
            vendorsObj.VendorsStreetAddress = vendorsStreetTextBox.Text;
            vendorsObj.VendorsPostalCode = vendorsPotalCodTextBox.Text;
            vendorsObj.VendorsCity = vendosCityTextBox.Text;

            VendorInformationctore vendorObj = new VendorInformationctore();
            vendorObj.saveVendorsInformation(vendorsObj);
           
           

            MessageBox.Show("Information save Suxcesfully");


        }

        private void showListViewButton_Click(object sender, EventArgs e)
        {
            vendorsListVew.Items.Clear();
            List<VendorInformationClass> vendorses = new List<VendorInformationClass>();
            VendorInformationctore vendor = new VendorInformationctore();
            vendorses = vendor.GetVendorInformation();

            foreach (VendorInformationClass vendorsOb in vendorses)
            {
                ListViewItem venlist = new ListViewItem(vendorsOb.VendorsName);
                venlist.SubItems.Add(vendorsOb.VendorsStreetAddress);
                venlist.SubItems.Add(vendorsOb.VendorsCity);
                venlist.SubItems.Add(vendorsOb.VendorsPostalCode);

                vendorsListVew.Items.Add(venlist);



            }
        }

        private void deletButton_Click(object sender, EventArgs e)
        {
            string vendorNam;
            vendorNam = vendorNamTextBox.Text;
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString = "Delete  From vendorsInformation Where vendorsName='" + vendorNam + "'";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("delet complet");

        }

        private void roadPermitButton_Click(object sender, EventArgs e)
        {
            roadParmit roadp = new roadParmit();
            this.Hide();
            roadp.Show();
        }
        

       
    }
}
