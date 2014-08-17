using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VEHICLE_INFORMATION
{
    class PersonInformationClass
    {
        private string personNumber;

        public string PersonNumber
        {
            get { return personNumber; }
            set { personNumber = value; }
        }
        private string personLastName;

        public string PersonLastName
        {
            get { return personLastName; }
            set { personLastName = value; }
        }
        private string personFirstName;

        public string PersonFirstName
        {
            get { return personFirstName; }
            set { personFirstName = value; }
        }
        private string personAddress;

        public string PersonAddress
        {
            get { return personAddress; }
            set { personAddress = value; }
        }
        private string personMobailNumber;

        public string PersonMobailNumber
        {
            get { return personMobailNumber; }
            set { personMobailNumber = value; }
        }
        private string personPostalCode;

        public string PersonPostalCode
        {
            get { return personPostalCode; }
            set { personPostalCode = value; }
        }
        private string date;

        public string Date
       {
            get { return date; }
            set { date = value; }
       }
    }
}
