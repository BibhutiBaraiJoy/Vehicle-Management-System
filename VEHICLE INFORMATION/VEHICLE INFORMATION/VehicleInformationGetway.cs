using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace VEHICLE_INFORMATION
{
    class VehicleInformationGetway
    {
        public void saveVehicleInformation(VehicleInformationClass vehicleInformationObj)
        {
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string insertString = "INSERT INTO vehicleInformationTabl VALUES('" + vehicleInformationObj.ModelYear + "','" + vehicleInformationObj.Department + "','" + vehicleInformationObj.VinNumber + "','" + vehicleInformationObj.VehicleNumber + "','" + vehicleInformationObj.Colour + "','" + vehicleInformationObj.ModelNumber + "','" + vehicleInformationObj.EnginNumber + "','" + vehicleInformationObj.Transmistion + "','" + vehicleInformationObj.TrialSize + "','" + vehicleInformationObj.CompanyName + "','" + vehicleInformationObj.AccountNumber + "')";
            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public List<VehicleInformationClass> GetVendorInformation()
        {
            VehicleInformationClass vehicleObj = null;
            List<VehicleInformationClass> vehicleses=new List<VehicleInformationClass>();
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
             SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string queryString="SELECT * FROM vehicleInformationTabl";
            SqlCommand command=new SqlCommand(queryString,connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                vehicleObj=new VehicleInformationClass();
                vehicleObj.ModelYear=(reader["modelYear"]).ToString();
                vehicleObj.Department=(reader["department"]).ToString();
                vehicleObj.VinNumber=(reader["vinNumber"]).ToString();
                vehicleObj.VehicleNumber=(reader["vehicleNumber"]).ToString();
                vehicleObj.Colour=(reader["colour"]).ToString();
                vehicleObj.ModelNumber=(reader["modelNumber"]).ToString();
                vehicleObj.EnginNumber=(reader["enginNumber"]).ToString();
                vehicleObj.Transmistion=(reader["Transmistion"]).ToString();
                vehicleObj.TrialSize=(reader["trialSize"]).ToString();
                vehicleObj.CompanyName=(reader["companyName"]).ToString();
                vehicleObj.AccountNumber=(reader["accountNumber"]).ToString();
                vehicleses.Add(vehicleObj);
            }
            connection.Close();
            return vehicleses;


        }

       
    }
}
