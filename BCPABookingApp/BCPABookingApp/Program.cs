using System;
using System.Linq;

namespace BookingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch = 0;
            Customer newCustomer = new Customer();

            if (newCustomer.LoggedIn())
            {
                ch = MainMenu(ch);
                MainMenuSelection(ch, newCustomer);

            }

            Console.ReadKey();

        }

        private static int MainMenu(int ch)
        {
            Console.WriteLine("{0}" +
                "-------------------------------------------------------MAIN MENU------------------------------------------------------- {0}" +
                "1. Buy tickets for upcoming Shows {0}" +
                "2. Log Out {0}" +
                "3. View Profile Details {0}", Environment.NewLine);

            Console.WriteLine("Please enter a menu choice number:");

            ch = Convert.ToInt32(Console.ReadLine());

            while (!new[] { 1, 2, 3 }.Contains(ch))
            {
                Console.WriteLine("Invalid selection. Please select a valid menu choice number.");
                ch = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You have selected option: " + ch);
            return ch;
        }

        private static void MainMenuSelection(int ch, Customer newCustomer)
        {
            if (ch == 1)
            {
                Show show = new Show();
                show.SelectShow();

                Console.WriteLine("Please select a show:");

                ch = Convert.ToInt32(Console.ReadLine());

                while (!new[] { 1, 2, 3 }.Contains(ch))
                {
                    Console.WriteLine("Invalid selection. Please select a valid menu choice number.");
                    ch = Convert.ToInt32(Console.ReadLine());
                }

                string selectedShow = show.GetShowByID(ch);
                Console.WriteLine("You have selected the show: " + selectedShow);


                //select show
                //select show time

                //confirm show and show time

                //select seat
                //calc seat prices 

                //apply discounts etc

                //payment

            }
            else if (ch == 2)
            {
                bool logOut = Confirmation("Are you sure you wish to Log out? [Y/N]");
                if (logOut)

                    ExitApp();
                else
                    MainMenu(ch);

            }
            else if (ch == 3)
            {

                newCustomer = newCustomer.GetProfileInfo(newCustomer);
                Console.WriteLine("Name: {0} {1} {3}" +
                    "Address: {2}", newCustomer.first, newCustomer.last, newCustomer.address, Environment.NewLine);

                MainMenu(ch);
            }
        }

        public static bool Confirmation(string title)
        {
            ConsoleKey response;
            do
            {
                Console.WriteLine(title);
                response = Console.ReadKey(false).Key;
                if (response != ConsoleKey.Enter)
                {
                    Console.WriteLine();
                }
            } while (response != ConsoleKey.Y && response != ConsoleKey.N);

            return (response == ConsoleKey.Y);
        }

        private static void ExitApp()
        {
            Console.WriteLine("Press any key to close the Booking app...");
            Console.ReadKey();
        }
    }
}
