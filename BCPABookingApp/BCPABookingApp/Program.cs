using System;
using System.Linq;

namespace BCPABookingApp
{
    class Program
    {
        public static int ch;

        private static void Main(string[] args)
        {
            Customer newCustomer = new Customer();

            if (newCustomer.LoggedIn())
            {
                ch = Menu.MainMenu();
                Menu.MainMenuShowSelection(ch, newCustomer);
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
