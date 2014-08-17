using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VEHICLE_INFORMATION
{
    class VendorInformationClass
    {
        private string vendorsName;
        private string vendorsCity;
        private string vendorsStreetAddress;
        private string vendorsPostalCode;


        public string VendorsName
        {
            get { return vendorsName; }
            set { vendorsName = value; }
        }
        

        public string VendorsCity
        {
            get { return vendorsCity; }
            set { vendorsCity = value; }
        }
       

        public string VendorsStreetAddress
        {
            get { return vendorsStreetAddress; }
            set { vendorsStreetAddress = value; }
        }
       
        public string VendorsPostalCode
        {
            get { return vendorsPostalCode; }
            set { vendorsPostalCode = value; }
        }
    }
}
