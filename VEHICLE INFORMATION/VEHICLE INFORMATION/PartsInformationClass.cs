using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VEHICLE_INFORMATION
{
    class PartsInformationClass
    {
        private string partsName;

        public string PartsName
        {
            get { return partsName; }
            set { partsName = value; }
        }
        private string partsNumber;

        public string PartsNumber
        {
            get { return partsNumber; }
            set { partsNumber = value; }
        }
        private string partsPrice;

        public string PartsPrice
        {
            get { return partsPrice; }
            set { partsPrice = value; }
        }
        private string partsQuentity;

        public string PartsQuentity
        {
            get { return partsQuentity; }
            set { partsQuentity = value; }
        }
    }
}
