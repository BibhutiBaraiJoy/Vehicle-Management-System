using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace VEHICLE_INFORMATION
{
    class PartsInformationGetway
    {
        public void storePartsInformation(PartsInformationClass pertsInforObj)
        {
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string insertString = "INSERT INTO partsInformationTable VALUES('" + pertsInforObj.PartsName + "','" + pertsInforObj.PartsNumber + "','" + pertsInforObj.PartsPrice + "','" + pertsInforObj.PartsQuentity + "')";
            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            
            connection.Close();
        }
        public List<PartsInformationClass>GetpartInnformation()
        {
            PartsInformationClass parts=null;
            List<PartsInformationClass>partses=new List<PartsInformationClass>();
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;"; 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string queryString="SELECT * FROM partsInformationTable";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                parts=new PartsInformationClass();
                parts.PartsName=(reader["partsName"]).ToString();
                parts.PartsNumber=(reader["partsNumber"]).ToString();
                parts.PartsPrice = (reader["partsPrice"]).ToString();
                parts.PartsQuentity=(reader["partsQuentity"]).ToString();

                partses.Add(parts);


            }
            connection.Close();
            return partses;


        }
        
           

        }
       
       
               
  
    }

