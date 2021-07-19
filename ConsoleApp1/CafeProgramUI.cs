using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeChallange.Console
{
    class CafeProgramUI
    {

        private readonly MenuRepo CafeRepository = new CafeRepository();

        private void Menu()
        {
           
        bool keepMenuRunning = true;
            while (keepMenuRunning)

            {
                //need meal number, meal name, description, list of ingredients, a price 
                //an example of what the user-end app would look like
                System.Console.WriteLine("Welcome to Komodo Cafe! You've got some sweet options for today!\n" +
                                              "1. 'The Veganator' Vegan Burger N Fries $12\n" +
                                              "2. 'The Wild Mushroom' Portabella Sandwich N Mac $14\n" +
                                              "3. 'Just Chill' Chili N Cornbread $10\n" +
                                              "4. 'Lemonhead' Lemon Tart $7\n" +
                                              "5. 'Strawberry Jubilee' Strawberries and Sweetbread $10\n");

                string userInput = Console.ReadLine();

            }
        }

        private void BackEndMenu()
        {
            bool keepMenuRunning = true;
            while (keepMenuRunning)

            {
                //The manager wants to be able to create new items, delete items, and receive a list of all items on the menu.
                Console.Clear();
                Console.WriteLine("Welcome to the Komodo Manager Menu, to edit menu please choose an option.\n" +
                                         "1. Create a new menu item with description & price\n" +
                                         "2. Delete an existing menu item\n" +
                                         "3. View full list of Menu Items\n" +
                                         "4. Exit Menu");
                switch (Console.ReadLine())
                {
                    case "1":
                        CreateItem();
                        break;
                    case "2":
                        DeleteItem();
                        break;
                    case "3":
                        ViewList();
                    case "4":
                        keepMenuRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please choose a valid number. Press any key to continue");
                        Console.ReadLine();
                        break;


                }

            }
        }

        private void CreateItem()
        {
            // add item
            //need meal number, meal name, description, list of ingredients, a price
            Console.Clear();
            Console.WriteLine("Enter Numeric Meal Number");
            int mealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name of meal");
            string mealName = Console.ReadLine();

            Console.WriteLine("Enter Meal Description for Menu");
            string mealDescription = Console.ReadLine();

            Console.WriteLine("Add list of ingredients");
            List<string> ingredients = new List<string>();

            Console.WriteLine("Enter Item Price");
            double itemPrice = double.Parse(Console.ReadLine());

            Menu menuItem = new Menu(mealNumber, mealName, mealDescription, ingredients, itemPrice);



        }

        
        private void DeleteItem()
            //delete item
        {
            Console.Clear();
            Console.WriteLine("Select the menu item you wish to delete.");
            ShowMenuItem();
            int chosenItem = int.Parse(Console.Readline());
            if (CafeRepository.DeleteItem(CafeRepository.SelectItem(selectedItem)))
            {
                Console.WriteLine("Item had been successfully deleted.");
            }
            else
            {
                Console.WriteLine("Item not found, please choose valid item.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        private void ShowMenuItem()
        {
            var menuItem = CafeRepository.ViewAllItems();
            foreach(var item in menuItem)
            {
                Console.WriteLine($"Item Number: {item.menuItem}")
            }
        }


        private void ViewList()
            //see all items in the menu list 
        {
            Console.Clear();
            var menuItem = CafeRepository.ViewAllItems();

            //mealNumber, mealName, mealDescription, ingredients, itemPrice
            foreach (var item in menuItem)
            {
                Console.WriteLine($"Meal Number: {item.MealNumber}\n") +
                                  $"Meal Name: {item.MealName}\n" +
                                  $"Description: {item.MealDescription}\n" +
                                  $"Ingredients: {item.ingredients}\n" +
                                  $"Price: {item.ItemPrice}");

                Console.Readline();
            }
        }
        



    }

}

