using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FoodOrderSoftware
{
    public class Menu
    {
        //This is the start menu (choose between login an create a new user)
        public static void StartMenu()
        {
            Console.WriteLine("Login or NewUser?");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                UserSystem.Login();
            }
            else if (num == 2)
            {
                UserSystem.NewUser();
            }
        }

    }

    //This  is were the user will make a new or login into an user and see the Account Settings
    //All things related to user
    internal class UserSystem
    {
        //Here is were you make a new user and save it in a txt document
        public static void NewUser()
        {
            Console.Clear();
            Console.WriteLine("This is where you make a new user!");

            //Empty varibles are created and filled with the inputs from the user
            string username, email, password, cardnumber = string.Empty;
            
            Console.Write("\nMake a username: ");
            username = Console.ReadLine();

            Console.Write("Enter your Email: ");
            email = Console.ReadLine();

            Console.Write("\nMake a password: ");
            password = Console.ReadLine();

            Console.Write("\nEnter cardnumber: ");
            cardnumber = Console.ReadLine();

            //Writes the info into a txt document
            using (StreamWriter sw = new StreamWriter(File.Create(@"C:\Users\zbctoli\source\repos\FoodOrderSoftware\info.txt.txt")))
            {
                sw.WriteLine(username);
                sw.WriteLine(email);
                sw.WriteLine(password);
                sw.WriteLine(cardnumber);
                sw.Close();
            }
        }

        //This is were you login if you already have an user and checks if it's correct
        public static void Login()
        {
            Console.Clear();
            Console.WriteLine("This is the login screen!");


            string username1, email1, password1, username2, email2, password2 = string.Empty;

            Console.Write("\nEnter username: ");
            username1 = Console.ReadLine();

            Console.Write("Enter your Email: ");
            email1 = Console.ReadLine();

            Console.Write("\nEnter password: "); 
            password1 = Console.ReadLine();

            //Reading the information from the txt document
            using (StreamReader sr = new StreamReader(File.Open(@"C:\Users\zbctoli\source\repos\FoodOrderSoftware\info.txt.txt", FileMode.Open)))
            {
                username2 = sr.ReadLine();
                email2 = sr.ReadLine();
                password2 = sr.ReadLine();
                sr.Close();
            }

            if (username1 == username2 && email1 == email2 && password1 == password2)
            {
                Console.Clear();
                Console.WriteLine("Login successful!!");
                InGame.Menu();
            } else
            {
                Console.WriteLine("Failed to login");
            }
        }

        //This is were you pay and it checks if the input info is correct
        public static void Payment()
        {

            Console.WriteLine("This is the where you pay!");


            string username1, email1, password1, cardnumber1, username2, email2, password2, cardnumber2 = string.Empty;

            Console.Write("\nEnter username: ");
            username1 = Console.ReadLine();

            Console.Write("\nEnter your Email: ");
            email1 = Console.ReadLine();

            Console.Write("\nEnter password: ");
            password1 = Console.ReadLine();

            Console.Write("\nEnter cardnumber: ");
            cardnumber1 = Console.ReadLine();

            //Reading the information from the txt document
            using (StreamReader sr = new StreamReader(File.Open(@"C:\Users\zbctoli\source\repos\FoodOrderSoftware\info.txt.txt", FileMode.Open)))
            {
                username2 = sr.ReadLine();
                email2 = sr.ReadLine();
                password2 = sr.ReadLine();
                cardnumber2 = sr.ReadLine();
                sr.Close();
            }

            if (username1 == username2 && email1 == email2 && password1 == password2 && cardnumber1 == cardnumber2)
            {
                Console.Clear();
                Console.WriteLine("payment successful!!");
            }
            else
            {
                Console.WriteLine("Failed to pay");
            }
        }
    }

    internal class InGame
    {
        //You choose between setting, new orders and existing orders here
        static public void Menu()
        {
            #region Menu options
            List<string> option = new List<string>();
            option.Add("1: Settings");
            option.Add("2: New Orders");
            option.Add("3: Existing Orders");

            foreach (string line in option)
            {
                Console.WriteLine(line);
            }
            #endregion

            #region Menu Choice
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            choice = choice.ToLower();


            if (choice == "1" || choice == "settings")
            {
                Settings();
            }
            else if (choice == "2" || choice == "new order")
            {
                NewOrders();
            }
            else if (choice == "3" || choice == "existing order")
            {
                ExistingOrders();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            #endregion
        }

        //Here can you see and update settings
        public static void Settings()
        {
            Console.Clear();
            Console.WriteLine("This is the setting screen");
            


            Menu();
        }

        //New orders are created and handled
        static public void NewOrders()
        {
            Console.Clear();
            Console.WriteLine("Here can you make new orders");

            FoodOption.MenuOption();
        }

        //Shows the existing orders
        static public void ExistingOrders()
        {
            Console.Clear();
            Console.WriteLine("Here can you see the existing orders");
            FoodOption.Existing();
        }

    }
}
