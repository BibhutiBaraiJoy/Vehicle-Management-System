using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VEHICLE_INFORMATION
{
    class roadPermitClass
    {
        private string typeOfCar;

        public string TypeOfCar
        {
            get { return typeOfCar; }
            set { typeOfCar = value; }
        }
        private string carId;

        public string CarId
        {
            get { return carId; }
            set { carId = value; }
        }
        private string roadPermit;

        public string RoadPermit
        {
            get { return roadPermit; }
            set { roadPermit = value; }
        }
        private string carLisenceNumber;

        public string CarLisenceNumber
        {
            get { return carLisenceNumber; }
            set { carLisenceNumber = value; }
        }
    }
}
