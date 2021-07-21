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
                        Console.WriteLine($"{content.OutingsType}\n" +
                            $"{content.Attendance}\n" +
                            $"{content.EventDate}\n" +
                            $"{content.CostPerPerson}\n" +
                            $"{content.TotalEventCost}\n");
                    }
                    Console.WriteLine("Press any key to return to main menu");
                    Console.ReadLine();
                    Console.Clear();

                }

                public void AddOuting()
                {
                    Outing content = new Outing();

                    Console.WriteLine("Enter the event type number: \n" +
                        "1. Golf\n" +
                        "2. Bowling\n" +
                        "3. Amusement Parks\n" +
                        "4. Concert\n");

                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            content.OutingType = TypeOuting.Golf;
                            break;
                        case "2":
                            content.OutingType = TypeOuting.Bowling;
                            break;
                        case "3":
                            content.OutingType = TypeOuting.AmusementPark;
                        case "4":
                            content.OutingType = TypeOuting.Concert;
                            break;
                    }

                    Console.Clear();
                    Console.WriteLine($"({content.OutingType} (Attendance) (OutingDate) (CostPerPerson) (TotalCost)");

                    Console.WriteLine("Total number of Attendees:");
                    content.Attendance = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine($"({content.OutingType}) ({content.Attendance}) (OutingDate) (CostPerPerson) (TotalCost)");

                    Console.WriteLine("Date of the event (YYYY, MM, DD):");
                    content.OutingDate = DateTime.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine($"({content.OutingType}) ({content.Attendance}) ({content.OutingDate}) (CostPerPerson) (TotalCost)");

                    Console.WriteLine("Cost per person for the event: ");
                    content.CostPerPerson = double.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine($"({content.OutingType}) ({content.Attendance}) ({content.OutingDate}) ({content.CostPerPerson}) (TotalCost)");

                    Console.WriteLine("Total cost for the event: ");
                    content.TotalCost = double.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine($"({content.OutingType}) ({content.Attendance}) ({content.OutingDate}) ({content.CostPerPerson}) ({content.TotalCost})");

                    Console.Clear();
                    Console.WriteLine($"The following outing will be added to the list: \n" +
                        $"\n" +
                        $"OutingType: {content.OutingType}\n" +
                        $"Attendance: {content.Attendance}\n" +
                        $"OutingDate: {content.OutingDate}\n" +
                        $"CostPerPerson: {content.CostPerPerson}\n" +
                        $"TotalCost: {content.TotalCost}\n");

                    Console.WriteLine("Press 'Enter' to confirm");
                    Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Outing added!\n" +
                        "\n" +
                        "Press 'Enter' to return to the Main Menu.");
                    Console.ReadLine();

                    Console.Clear();

                    OutingsRepository.AddOuting(content);
                }

                public void CostForEach();
                {
                    Console.Clear();
                    Console.WriteLine($"Cost of golf outings: ${OutingsRepository.CostForEach(OutingType.Golf)\n}" +
                         $"Cost of bowling outings: ${OutingsRepository.CostByType(OutingType.Bowling)}\n" +
                         $"Cost of amusement park outings: ${OutingsRepository.CostByType(TypeOfOuting.AmusementPark)}\n" +
                         $"Cost of concert outings: ${OutingsRepository.CostByType(TypeOfOuting.Concert)}\n");

                    Console.WriteLine("Press enter to return to Main Menu");
                    Console.ReadLine();
                    Console.Clear();
                    
                }

                public void CombinedCost();
                {
                    Console.Clear();
                    Console.WriteLine("Combined cost for all outings: ${OutingsRepository.TotalCost()}");

                    Console.WriteLine("Press Enter when finished")
                    Console.ReadLine();
                    Console.Clear();

                }



            }
        }
    }
}
