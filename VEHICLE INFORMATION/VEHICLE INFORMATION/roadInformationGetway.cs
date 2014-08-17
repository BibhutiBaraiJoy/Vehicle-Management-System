using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace VEHICLE_INFORMATION
{
    class roadInformationGetway
    {
        public void saveRoadInformation(roadPermitClass roadPermitObj)
        {
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string insertString = "INSERT INTO roadInformationTable VALUES('" + roadPermitObj.TypeOfCar + "','" + roadPermitObj.CarId + "','" + roadPermitObj.CarLisenceNumber + "','" + roadPermitObj.RoadPermit + "')";
            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public List<roadPermitClass> GetRoadInformation()
        {
            roadPermitClass roadObj = null;
            List<roadPermitClass> roadPer = new List<roadPermitClass>();
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString = "SELECT *FROM roadInformationTable";
             SqlCommand command=new SqlCommand(queryString,connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                roadObj = new roadPermitClass();
                roadObj.TypeOfCar = (reader["typeOfCar"]).ToString();
                roadObj.CarId = (reader["carId"]).ToString();
                roadObj.CarLisenceNumber = (reader["carLisenceNumber"]).ToString();
                roadObj.RoadPermit = (reader["roadPermit"]).ToString();
                roadPer.Add(roadObj);

            }
            connection.Close();
            return roadPer;


        }
       
    }
}
