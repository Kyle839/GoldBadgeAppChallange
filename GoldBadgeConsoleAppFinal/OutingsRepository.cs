using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outings.Console
{
    class OutingsRepository
    {
        public enum TypeOfOuting
        {
            Golf = 1,
            Bowling = 2,
            AmusementPark = 3,
            Concert = 4,
        }
        public class Outing
        {
            public TypeOfOuting OutingType { get; set; }
            public int Attendance { get; set; }
            public DateTime OutingDate { get; set; }
            public double CostPerPerson { get; set; }
            public double TotalCost { get; set; }

            public Outing(TypeOfOuting outingType, int attendance, DateTime outingDate, double costPerPerson, double totalCost)
            {
                OutingType = outingType;
                Attendance = attendance;
                OutingDate = outingDate;
                CostPerPerson = costPerPerson;
                TotalCost = totalCost;
            }

            public Outing()
            {
                //no content or input to display 
            }
        }
    }
