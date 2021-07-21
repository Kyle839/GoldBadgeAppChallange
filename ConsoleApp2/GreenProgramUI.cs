using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenChallange.Console
{
    class GreenProgramUI
    { 

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine ("Insurance Agent Main Menu. Please choose an option."\n +
                    "1. Create a new car profile\n" +
                    "2. Update a car profile\n" +
                    "3. Delete a car profile\n" +
                    "4. View all profiles\n" +
                    "5. Exit");
                string menuInput = Console.ReadLine();
                switch (menuInput)
                {
                    case "1":
                        Console.Clear();
                        CreateCarProfile();
                        break;
                    case "2":
                        Console.Clear();
                        UpdateCarProfile();
                        break;
                    case "3":
                        Console.Clear();
                        DeleteCarProfile();
                        break;
                    case "4":
                        Console.Clear();
                        ListAllCarProfiles();
                        break;
                    case "5":
                        default
                        Console.Clear();
                        Console.WriteLine("Thank You");
                        keepRunning = false;
                        break;
                }
            }
        }

        public void CreateCarProfile()
        {
            CarInformation newCarInfo = new CarInformation();

        
            Console.WriteLine("Car make/company: ");
            newCarInfo.CarMake = Console.ReadLine();

            
            Console.WriteLine("Car name: ");
            newCarInfo.CarName = Console.ReadLine();

            
            Console.WriteLine("Car year (YYYY): ");
            string yearAsString = Console.ReadLine();
            newCarInfo.CarYear = int.Parse(yearAsString);

            
            Console.WriteLine("Car type:\n" +
                "1. Electric\n" +
                "2. Hybrid\n" +
                "3. Gas ");
            string carTypeInput = Console.ReadLine();
            int carTypeInt = int.Parse(carTypeInput);
            newCarInfo.CarType = (CarType)carTypeInt;



            Console.WriteLine("Car Type:\n" +
                "1. Sedan\n" +
                "2. Truck\n" +
                "3. Van\n" +
                "4. SUV\n");


            string carType = Console.ReadLine();
            int carTypeint = int.Parse(carSizeInput);
            carInfo.CarType = (CarType)carType;

            Console.WriteLine(
                "Vehicle Profile Created. Please choose an option.\n" +
                "1. Return to Insurance Agent main menu\n" +
                "2. Update vehicle Profile" +
                "3. Add a new vehicle");

            string listAllInput = Console.ReadLine();
            switch (listAllInput)
            {
                case "1":
                    Console.Clear();
                    Menu();
                    break;
                case "2":
                    Console.Clear();
                    UpdateCarProfile();
                    break;
                case "3":
                    Console.Clear();
                    AddNewVehicle();
                    break;
                default: //if case numbers numbers not entered correctly 
                    Console.WriteLine("Hm, don't know about that one. Please press enter to get back to the Main Menu. \n");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }
        }

        public void UpdateCarProfile()
        {
            //display all car profiles
            List<CarInformation> listOfAllCarInfo = GreenRepository.GetCarInformation();

            foreach (CarInformation carInformation in listOfAllCarInfo)
            {

                Console.WriteLine($"Make: {carInformation.CarMake} \n" +
                    $"Name: {carInformation.CarName} \n" +
                    $"Year: {carInformation.CarYear} \n" +
                    $"Size: {carInformation.CarType} \n" +
                    $"Type: {carInformation.CarEngine} \n");
                   
            }

            //ask for name looking to update
            Console.WriteLine("Enter the name of the car you would like to update:");

            //get the name
            string updateInput = Console.ReadLine();

            //build a new object (override)
            CarInformation newCarInfo = new CarInformation();

          
            Console.WriteLine("Car make/Company: ");
            newCarInfo.CarMake = Console.ReadLine();

            
            Console.WriteLine("Car name: ");
            newCarInfo.CarName = Console.ReadLine();

            
            Console.WriteLine("Car year (YYYY): ");
            string yearAsString = Console.ReadLine();
            newCarInfo.CarYear = int.Parse(yearAsString);

            
            Console.WriteLine("Car type:\n" +
                "1. Electric\n" +
                "2. Hybrid\n" +
                "3. Gas ");
            string carType = Console.ReadLine();
            int carTypeInt = int.Parse(carType);
            newCarInfo.CarType = (carType)carTypInt;


            Console.WriteLine("Car Type:\n" +
                "1. Sedan\n" +
                "2. Truck\n" +
                "3. Van\n" +
                "4. SUV\n");

            string userCarType = Console.ReadLine();
            int carSizeAsInt = int.Parse(userCarType);
            newCarInfo.CarSize = (CarSize)carSizeAsInt;

            Console.WriteLine("Miles Per Gallon (MPG) : ");
            string mpgAsString = Console.ReadLine();
            newCarInfo.MilesPerGallon = int.Parse(mpgAsString);

            Console.WriteLine("Miles Per Charge: ");
            string MPCAsString = Console.ReadLine();
            newCarInfo.RangePerCharge = int.Parse(MPCAsString);


            if (wasUpdated)
            {
                Console.WriteLine("Vehicle Updated");
            }
            else
            {
                Console.WriteLine("There was a problem, please try again!");
            }
            Console.WriteLine(
                "Profile Updated! Choose an option or exit!\n" +
                "1. Return to Insurance Agent menu\n" +
                "2. Update a profile");
            string listAllInput = Console.ReadLine();
            switch (listAllInput)
            {
                case "1":
                    Console.Clear();
                    Menu();
                    break;
                case "2":
                    Console.Clear();
                    UpdateAProfile();
                    break;
                default:
                    Console.WriteLine("Hm, something went wrong. Let's go back to the Main Menu.\n" +
                        "Press any key");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }
        }

        public void DeleteCarProfile()
        {
            
            List<CarInfo> listOfAllCarInfo = GreenRepository.GetCarInformation();

            foreach (CarInfo carInformation in listOfAllCarInfo)
            {

                Console.WriteLine($"Make: {carInformation.CarMake} \n" +
                    $"Name: {carInformation.CarName} \n" +
                    $"Year: {carInformation.CarYear} \n" +
                    $"Size: {carInformation.CarSize} \n" +
                    $"Type: {carInformation.CarType} \n");

            }

        
            Console.WriteLine("\nEnter car name to delete:");

            string deleteInput = Console.ReadLine();

          
            bool wasDeleted = GreenRepository.RemoveCarInfoFromList(deleteInput);

      
            if (wasDeleted)
            {
                Console.WriteLine("Car Deleted");
            }
            else
            {
                Console.WriteLine("Car not found.");
            }

            Console.WriteLine(
                "Now that you've deleted a car profile, what would you like to do?\n" +
                "1. Return to Insurance Agent menu\n" +
                "2. View all car profiles");
            string listAllInput = Console.ReadLine();
            switch (listAllInput)
            {
                case "1":
                    Console.Clear();
                    Menu();
                    break;
                case "2":
                    Console.Clear();
                    ListAllCarProfiles();
                    break;
                default:
                    Console.WriteLine("Oops! Something went wrong, let's go back to the main menu.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }
        }

        }

    }


}
