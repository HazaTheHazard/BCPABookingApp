using System;
using System.Linq;

namespace BCPABookingApp
{
    class Program
    {
        public static int choiceID;

        private static void Main(string[] args)
        {
            Customer newCustomer = new Customer();

            if (newCustomer.LoggedIn())
            {
                choiceID = Menu.MainMenu();
                Menu.MainMenuShowSelection(choiceID, newCustomer);
            }
            Console.ReadKey();
        }

        public static void ExitApp()
        {
            Console.WriteLine("Press any key to close the Booking app...");
            Console.ReadKey();
        }

    }
}
