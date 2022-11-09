using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FoodOrderSoftware
{
    internal class FoodMenu
    {
        #region defining of varibles, values and Constructor

        //Define varible nams
        public int id;
        public string name;
        public double price;
        public string size;

        //Do so we can get & set valuables to varibles
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }

        //passes variables into a constructor
        public FoodMenu(int Id, string Name, double Price, string Size)
        {
            id = Id;
            name = Name;
            price = Price;
            size = Size;
        }
        #endregion
    }

    public class FoodOption
    {
        //you input the date and time and pass it to {DelTime} function
        static void InputDelTime()
        {
            //This is were you input date and time
            #region Input Date & Time
            Console.WriteLine("Write the date and time where it should be delivered.");

            Console.WriteLine("\nDate:");
            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTime:");
            Console.Write("Hour: ");
            int hour = int.Parse(Console.ReadLine());

            Console.Write("Minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.Write("Seconds: ");
            int seconds = int.Parse(Console.ReadLine());
            #endregion
            DelTime(day, month, year, hour, minutes, seconds);

        }

        //Takes the input from {InputDelTime} function and combine it to a string
        static async void DelTime(int Day, int Month, int Year, int Hour, int Minutes, int Seconds)
        {

            //Combine the date into a string
            int[] date = { Day, Month, Year };
            var writeDate = string.Join("/", date);

            //Combine the time into a string
            int[] time = { Hour, Minutes, Seconds };
            var writeTime = string.Join(":", time);

            Console.WriteLine("\nThe food get's delivered " + writeDate + " at " + writeTime + " O'Clock.");

            using StreamWriter File = new(@"C:\Users\zbctoli\source\repos\FoodOrderSoftware\exsitingorder.txt.txt", append: true);

            await File.WriteLineAsync("The food get's delivered " + writeDate + " at " + writeTime + " O'Clock.");
        }

        public static void MenuOption()
        {
            #region Processes the entire menu card
            //Read the menu card from a text document into a list
            #region read text document
            List<string> list = new List<string>();

            string text = File.ReadAllText(@"C:\Users\zbctoli\source\repos\FoodOrderSoftware\getMenu.txt");

            var result = Regex.Split(text, "\r\n|\r|\n");

            foreach (string item in result)
            {
                list.Add(item);
            }
            #endregion

            //This were we enter all the data into diffrent menu options
            #region data entering
            FoodMenu englishBeef = new FoodMenu(0, list[0], 125, "150 g");
            FoodMenu hamburger = new FoodMenu(1, list[1], 90, "100 g");
            FoodMenu cheeseburger = new FoodMenu(2, list[2], 95, "100 g");
            FoodMenu baconcheeseburger = new FoodMenu(3, list[3], 100, "100 g");
            FoodMenu saladPizza = new FoodMenu(4, list[4], 125, "all accessories incl.");
            FoodMenu hamPizza = new FoodMenu(5, list[5], 115, "all accessories incl.");
            FoodMenu pepperoniPizza = new FoodMenu(6, list[6], 115, "all accessories incl.");
            FoodMenu cola = new FoodMenu(7, list[7], 19, "600 ml");
            FoodMenu faxeKondi = new FoodMenu(8, list[8], 17, "550 ml");
            FoodMenu fanta = new FoodMenu(9, list[9], 15, "500 ml");
            FoodMenu sport = new FoodMenu(10, list[10], 12, "475 ml");
            FoodMenu blueKell = new FoodMenu(11, list[11], 13, "525 ml");
            FoodMenu aquaDor = new FoodMenu(12, list[12], 13, "525 ml");
            FoodMenu coffee = new FoodMenu(13, list[13], 11, "225 ml");
            FoodMenu tea = new FoodMenu(14, list[14], 11, "225 ml");
            FoodMenu belgianWaffles = new FoodMenu(15, list[15], 55, "chocolate suace and jam");
            FoodMenu strawberryCake = new FoodMenu(16, list[16], 45, "one plateful");
            FoodMenu iceCream = new FoodMenu(17, list[17], 50, "4 ice cream scoops");
            #endregion

            //Here is were we write out all the info about the menu
            #region List to all menu info
            List<FoodMenu> menu = new List<FoodMenu>();

            menu.Add(englishBeef);
            menu.Add(hamburger);
            menu.Add(cheeseburger);
            menu.Add(baconcheeseburger);
            menu.Add(saladPizza);
            menu.Add(hamPizza);
            menu.Add(pepperoniPizza);
            menu.Add(cola);
            menu.Add(faxeKondi);
            menu.Add(fanta);
            menu.Add(sport);
            menu.Add(blueKell);
            menu.Add(aquaDor);
            menu.Add(coffee);
            menu.Add(tea);
            menu.Add(belgianWaffles);
            menu.Add(strawberryCake);
            menu.Add(iceCream);
            #endregion

            //This is were we store all the prices to order food from
            #region List to all menu prices
            List<double> menuPrices = new List<double>();

            menuPrices.Add(englishBeef.price);
            menuPrices.Add(hamburger.price);
            menuPrices.Add(cheeseburger.price);
            menuPrices.Add(baconcheeseburger.price);
            menuPrices.Add(saladPizza.price);
            menuPrices.Add(hamPizza.price);
            menuPrices.Add(pepperoniPizza.price);
            menuPrices.Add(cola.price);
            menuPrices.Add(faxeKondi.price);
            menuPrices.Add(fanta.price);
            menuPrices.Add(sport.price);
            menuPrices.Add(blueKell.price);
            menuPrices.Add(aquaDor.price);
            menuPrices.Add(coffee.price);
            menuPrices.Add(tea.price);
            menuPrices.Add(belgianWaffles.price);
            menuPrices.Add(strawberryCake.price);
            menuPrices.Add(iceCream.price);
            #endregion

            //This is were we store all the names to see what we have ordered
            #region List to all menu names
            List<string> menuNames = new List<string>();

            menuNames.Add(englishBeef.name);
            menuNames.Add(hamburger.name);
            menuNames.Add(cheeseburger.name);
            menuNames.Add(baconcheeseburger.name);
            menuNames.Add(saladPizza.name);
            menuNames.Add(hamPizza.name);
            menuNames.Add(pepperoniPizza.name);
            menuNames.Add(cola.name);
            menuNames.Add(faxeKondi.name);
            menuNames.Add(fanta.name);
            menuNames.Add(sport.name);
            menuNames.Add(blueKell.name);
            menuNames.Add(aquaDor.name);
            menuNames.Add(coffee.name);
            menuNames.Add(tea.name);
            menuNames.Add(belgianWaffles.name);
            menuNames.Add(strawberryCake.name);
            menuNames.Add(iceCream.name);
            #endregion
            #endregion

            Console.WriteLine("Will you see the menu/1 or order/2?");
            int opt = int.Parse(Console.ReadLine());
            List<string> menuNamesList = new List<string>();

            if (opt == 1)
            {
                foreach (FoodMenu item in menu)
                {
                    Console.WriteLine(item.id + ": " + item.name + ", " + item.price + " kr. " + item.size);
                }

                Console.WriteLine("\nPress ENTER when you're done");
                Console.ReadKey();
                Console.Clear();

                InGame.Menu();
            }
            else if (opt == 2)
            {
                bool order = true;
                double sum = 0;

                Console.WriteLine("Here can you order food");
                Console.WriteLine("Press enter to continue... ");
                Console.ReadKey();

                while (order)
                {
                    Console.Write("Enter the order number(q/quit): ");
                    string input = Console.ReadLine();

                    //Checks if the order number is correct and sum up the prices
                    #region Checks order & Sum up
                    if (input == "0")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[0] * amount;
                        menuNamesList.Add(menuNames[0] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "1")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[1] * amount;
                        menuNamesList.Add(menuNames[1] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "2")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[2] * amount;
                        menuNamesList.Add(menuNames[2] + " x" + amount);

                        sum = sum + res;
                    }
                    else if(input == "3")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[3] * amount;
                        menuNamesList.Add(menuNames[3] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "4")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[4] * amount;
                        menuNamesList.Add(menuNames[4] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "5")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[5] * amount;
                        menuNamesList.Add(menuNames[5] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "6")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[6] * amount;
                        menuNamesList.Add(menuNames[6] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "7")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[7] * amount;
                        menuNamesList.Add(menuNames[7] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "8")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[8] * amount;
                        menuNamesList.Add(menuNames[8] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "9")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[9] * amount;
                        menuNamesList.Add(menuNames[9] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "10")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[10] * amount;
                        menuNamesList.Add(menuNames[10] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "11")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[11] * amount;
                        menuNamesList.Add(menuNames[11] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "12")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[12] * amount;
                        menuNamesList.Add(menuNames[12] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "13")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[13] * amount;
                        menuNamesList.Add(menuNames[13] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "14")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[14] * amount;
                        menuNamesList.Add(menuNames[14] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "15")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[15] * amount;
                        menuNamesList.Add(menuNames[15] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "16")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[16] * amount;
                        menuNamesList.Add(menuNames[16] + " x" + amount);

                        sum = sum + res;
                    }
                    else if (input == "17")
                    {
                        Console.Write("How many: ");
                        int amount = int.Parse(Console.ReadLine());
                        double res = menuPrices[17] * amount;
                        menuNamesList.Add(menuNames[17] + " x" + amount);

                        sum = sum + res;
                    }
                    #endregion
                    else if (input == "q")
                    {
                        order = false;
                        Console.Clear();
                        Console.WriteLine("Ordered food: ");
                        foreach (var item in menuNamesList)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("\nWhen should the food orders too?");
                        InputDelTime();

                        Console.WriteLine("You should pay: " + sum + " kr.");

                        Console.WriteLine("\nAre you ready to pay? Press ENTER: ");
                        Console.ReadKey();

                        UserSystem.Payment();
                        Console.WriteLine(sum + " kr. has now been withdrawn from your account.");

                        Console.WriteLine("\nAre you ready to pay? Press ENTER: ");
                        Console.ReadKey();
                        InGame.Menu();

                        using (StreamWriter sw = new StreamWriter(File.Create(@"C:\Users\zbctoli\source\repos\FoodOrderSoftware\exsitingorder.txt.txt")))
                        {
                            sw.WriteLine("Ordered food: ");
                            foreach (var item in menuNamesList)
                            {
                                sw.WriteLine(item);
                            }
                            sw.WriteLine("\nYou should pay: " + sum + " kr.");
                            sw.WriteLine("");
                        }

                    }
                }

            }
        }

        public static void Existing()
        {
            string readText = File.ReadAllText(@"C:\Users\zbctoli\source\repos\FoodOrderSoftware\exsitingorder.txt.txt");
            Console.WriteLine(readText);
        }
    }

}
