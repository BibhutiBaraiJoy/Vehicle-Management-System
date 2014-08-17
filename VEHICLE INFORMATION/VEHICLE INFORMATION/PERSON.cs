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
    public partial class PERSON : Form
    {
        public PERSON()
        {
            InitializeComponent();
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            mainForm mainformObj = new mainForm();
            mainformObj.Show();
            this.Hide();
        }

        private void partsButton_Click(object sender, EventArgs e)
        {
            PARTS pertsObj = new PARTS();
            pertsObj.Show();
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
            this.Hide();

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            personAddressTextBox.Clear();
            personFirstNameTextBox.Clear();
            personLastNameTextBox.Clear();
            personMobailNumberTextBox.Clear();
            personNumberTextBox.Clear();
            PersonPostalCodeTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PersonInformationClass personObj = new PersonInformationClass();
            personObj.PersonNumber = personNumberTextBox.Text;
            personObj.PersonLastName = personLastNameTextBox.Text;
            personObj.PersonFirstName = personFirstNameTextBox.Text;
            personObj.PersonAddress = personAddressTextBox.Text;
            personObj.PersonMobailNumber = personMobailNumberTextBox.Text;
            personObj.PersonPostalCode = PersonPostalCodeTextBox.Text;
            personObj.Date = personDateTimePicker1.Text;

            PersonInformationGetway personseObj = new PersonInformationGetway();
            personseObj.savePersonInformation(personObj);

           
            MessageBox.Show("person Information save Correctly");

           
        }

        private void personSarchButton_Click(object sender, EventArgs e)
        {
            string personMobailNum;
            personMobailNum = sarchPersonTextBox.Text;
            PersonInformationClass personObj = null;
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string queryString = "SELECT * FROM personInformationTable WHERE personMobailNumber='"+personMobailNum+"'";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                personObj = new PersonInformationClass();
                personObj.PersonNumber = (reader["personNumber"]).ToString();
                personNumberTextBox.Text = (reader["personNumber"]).ToString();
                personObj.PersonLastName = (reader["personLastName"]).ToString();
                personLastNameTextBox.Text = (reader["personLastName"]).ToString();
                personObj.PersonFirstName = (reader["personFirstName"]).ToString();
                personFirstNameTextBox.Text = (reader["personFirstName"]).ToString();
                personObj.PersonAddress = (reader["personAddress"]).ToString();
                personAddressTextBox.Text = (reader["personAddress"]).ToString();
                personObj.PersonMobailNumber = (reader["personMobailNumber"]).ToString();
                personMobailNumberTextBox.Text = (reader["personMobailNumber"]).ToString();
                personObj.PersonPostalCode = (reader["personPostalCode"]).ToString();
                PersonPostalCodeTextBox.Text = (reader["personPostalCode"]).ToString();
                personObj.Date = (reader["date"]).ToString();
                personDateTimePicker1.Text = (reader["date"]).ToString();
                
            }
            MessageBox.Show("personNumber=" + personObj.PersonNumber + "\n personLastName=" + personObj.PersonLastName + "personFirstName" + personObj.PersonFirstName + "\n personAddress=" + personObj.PersonAddress + "\n personMobailNumber=" + personObj.PersonMobailNumber);

            connection.Close();
        }

        private void showListButton_Click(object sender, EventArgs e)
        {
            personListView.Items.Clear();
            List<PersonInformationClass> personses = new List<PersonInformationClass>();
            PersonInformationGetway pers = new PersonInformationGetway();
            personses = pers.GetPersonInformation();

            foreach (PersonInformationClass personObgt in personses)
            {
                ListViewItem personlist = new ListViewItem(personObgt.PersonNumber);
                personlist.SubItems.Add(personObgt.PersonLastName);
                personlist.SubItems.Add(personObgt.PersonFirstName);
                personlist.SubItems.Add(personObgt.PersonAddress);
                personlist.SubItems.Add(personObgt.PersonMobailNumber);
                personlist.SubItems.Add(personObgt.PersonPostalCode);
                personlist.SubItems.Add(personObgt.Date);

                personListView.Items.Add(personlist);

            }
        }

        private void deletButton_Click(object sender, EventArgs e)
        {
            string mobailNumber;
            mobailNumber = sarchPersonTextBox.Text;
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString = "Delete  From personInformationTable Where personMobailNumber='" + mobailNumber + "'";

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
