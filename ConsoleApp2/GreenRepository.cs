using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenChallange.Console

    //CRUD Data
{
    public class GreenRepository
    {
            private List<CarInformation> _listOfCarInformation = new List<CarInformation>();

            
            public void AddCarInfoToList(CarInformation info)
            {
                _listOfCarInformation.Add(info);
            }

            
            public List<CarInformation> GetCarInformation()
            {
                return _listOfCarInformation;
            }

           

            
            public bool RemoveCarInfoFromList(string name)
            {
                CarInformation info = GetInfoByName(name);

                if (info == null)
                {
                    return false;
                }

                int initialCount = _listOfCarInformation.Count;
                _listOfCarInformation.Remove(info);

                if (initialCount > _listOfCarInformation.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
    }
