using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace VEHICLE_INFORMATION
{
    class VendorInformationctore
    {
        public void saveVendorsInformation(VendorInformationClass vehicleinformationObj)
        {
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string insertString = "INSERT INTO vendorsInformation VALUES('"+vehicleinformationObj.VendorsName+"','"+vehicleinformationObj.VendorsStreetAddress+"','"+vehicleinformationObj.VendorsCity+"','"+vehicleinformationObj.VendorsPostalCode+"')";
            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public List<VendorInformationClass> GetVendorInformation()
        {
           VendorInformationClass vendors = null;
            List<VendorInformationClass>vendorses=new List<VendorInformationClass>();
            string connectionString = @"server=DUET-559FE4FA51\SQLEXPRESS;integrated security = SSPI; database = VehicleInformationDB;"; 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string queryString = "SELECT * FROM vendorsInformation";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                vendors=new VendorInformationClass();
                vendors.VendorsName=(reader["vendorsName"]).ToString();
                vendors.VendorsPostalCode=(reader["vendorsPostalCode"]).ToString();
                vendors.VendorsStreetAddress=(reader["vendorsStreetAddress"]).ToString();
                vendors.VendorsCity=(reader["vendorsCity"]).ToString();
                vendorses.Add(vendors);
            }
            connection.Close();
            return vendorses;

        }
    }
}
