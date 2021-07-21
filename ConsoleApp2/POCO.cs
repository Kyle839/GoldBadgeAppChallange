using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenChallange.Console
{
    class POCO
 
        namespace Green_Plan
    {
        public enum CarEngine
        {
            Electric = 1,
            Hybrid = 2,
            Gas = 3
        }

        public enum CarType
        {
            Seden = 1,
            Truck = 2,
            Van = 3,
            SUV = 4
        }

        public class CarInformation
        { 
            public string CarName { get; set; }
            public int CarYear { get; set; }
            public string CarType { get; set; }
            public string CarEngine { get; set; }


            public CarInformation() { }

            public CarInformation(string carName, int carYear, string carType, string carEngine,)
            {
                CarName = carName;
                CarYear = carYear;
                CarType = carType;
                CarEngine = carEngine;

            }
        }
    }
