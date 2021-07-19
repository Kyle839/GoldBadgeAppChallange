using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outings.Console
{
    class OutingsProgramUI
    {
        private readonly OutingsRepository outingsrepo = OutingsRepository();
        bool keepProgramRunning = true;
        public void Run()
        {
            outingsrepo.InitilizeDataTable();
            while (keepProgramRunning)
            {
                Console.Clear();
                Console.WriteLine("Accountant Main Menu, Choose an option.\n" +
                "1. View All Outings\n" +
                "2. Add An Outing\n" +
                "3. See Cost cost each Indiviual Outing\n" +
                "4. See Combined Cost of All Outings\n" +
                "5. Exit Accountant Menu");


                switch (Console.ReadLine())
                {
                    case "1":
                        ViewOutings();
                        break;
                    case "2":
                        AddOuting();
                        break;
                    case "3":
                        CostForEach();
                        break;
                    case "4":
                        CombinedCost();
                        break;
                    case "5":
                        keepProgramRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid number, press any key to continue.");
                        Console.ReadLine();
                        break;
  
                }

                public void ViewOutings()
                {
                    Console.Clear();
                    List<Outings> outingList = OutingsRepository.ViewList();

                    foreach (Outings content in outingList)
                        {
                        Console.WriteLine($"{content.OutingsType}\n") +
                            $"{content.Attendance}\n" +
                    }

                }

                public void AddOuting()
                {

                }

                public void CostForEach();
                {

                }

                public void CombinedCost();
                {
                    Console.Clear();
                    Console.WriteLine("Combined cost for all outings: ${OutingsRepository.TotalCost()}");
                }



            }
        }
    }
}
