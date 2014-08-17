using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace VEHICLE_INFORMATION
{
    class PersonInformationGetway
    {
        public void savePersonInformation(PersonInformationClass personinformationObj)
        {
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string insertString = "INSERT INTO personInformationTable VALUES('" + personinformationObj.PersonNumber + "','" + personinformationObj.PersonLastName + "','" + personinformationObj.PersonFirstName + "','" + personinformationObj.PersonAddress + "','" + personinformationObj.PersonMobailNumber + "','" + personinformationObj.PersonPostalCode + "','"+personinformationObj.Date+"')";
            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public List<PersonInformationClass> GetPersonInformation()
        {
            PersonInformationClass personinObj = null;
            List<PersonInformationClass> personses = new List<PersonInformationClass>();
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string queryString = "SELECT * FROM personInformationTable";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                personinObj = new PersonInformationClass();
                personinObj.PersonNumber = (reader["personNumber"]).ToString();
                personinObj.PersonLastName = (reader["personLastName"]).ToString();
                personinObj.PersonFirstName = (reader["personFirstName"]).ToString();
                personinObj.PersonAddress = (reader["personAddress"]).ToString();
                personinObj.PersonMobailNumber = (reader["personMobailNumber"]).ToString();
                personinObj.PersonPostalCode = (reader["personPostalCode"]).ToString();
                personinObj.Date = (reader["date"]).ToString();

                personses.Add(personinObj);
            }
            connection.Close();
            return personses;
        }
        

    }
}
