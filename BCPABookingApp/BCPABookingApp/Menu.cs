using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BCPABookingApp
{
    class Menu : Program
    {
        public static int MainMenu()
        {
            Console.WriteLine("{0}" +
                "-------------------------------------------------------MAIN MENU------------------------------------------------------- {0}" +
                "1. Buy tickets for upcoming Shows {0}" +
                "2. Log Out {0}" +
                "3. View Profile Details {0}", Environment.NewLine);

            Console.WriteLine("Please enter a menu choice number:");

            choiceID = Convert.ToInt32(Console.ReadLine());

            while (!new[] { 1, 2, 3 }.Contains(choiceID))
            {
                Console.WriteLine("Invalid selection. Please select a valid menu choice number.");
                choiceID = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You have selected option: " + choiceID);
            return choiceID;
        }

        public static void MainMenuShowSelection(int choice, Customer customer)
        {
            if (choice == 1)
            {
                Show show = new Show();

                string selectedShow = show.SelectShow();
                Console.WriteLine("You have selected the show: " + selectedShow + Environment.NewLine);

                string showTime = show.SelectShowTime();
                Console.WriteLine("You have selected the show time: " + showTime + Environment.NewLine);

                bool confirmShowAndTime = Confirmation($"Are you sure you wish to proceed to Seat selection for {selectedShow} at {showTime}? [Y/N]");

                if (confirmShowAndTime)
                {
                    Seat seat = new Seat();
                    seat = seat.SelectSeat(seat);
                    string selectedSeat = Convert.ToString(seat.seatNum + seat.seatRow);
                    Console.WriteLine("You have selected the Seat: " + selectedSeat + Environment.NewLine);
                    Console.WriteLine($"This is a Tier {seat.tier} Seat.", Environment.NewLine);

                    Ticket ticket = new Ticket();
                    ticket.price = ticket.GetFormattedSeatPrice(seat.tier);
                    Console.WriteLine($"The price of Seat {selectedSeat} is: £{ticket.price}." + Environment.NewLine);

                    bool ticketPurchased = Confirmation($"Ticket for {selectedShow} at {showTime} for £{ticket.price} will be added to your account." +
                        $" Is this correct? [Y/N]");

                    if (ticketPurchased)
                        Success();
                }
                else
                    MainMenu();
                
            }
            else if (choice == 2)
            {
                bool logOut = Confirmation("Are you sure you wish to Log out? [Y/N]");
                if (logOut)
                    Program.ExitApp();
                else
                    MainMenu();

            }
            else if (choice == 3)
            {

                customer = customer.GetProfileInfo(customer);
                Console.WriteLine("Name: {0} {1} {3}" +
                    "Address: {2}", customer.first, customer.last, customer.address, Environment.NewLine);

                Console.WriteLine("{0}Press any key to return to the Main Menu...", Environment.NewLine);
                Console.ReadKey();
                MainMenu();
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

        private static void Success()
        {
            Console.WriteLine("{0}" +
                        "*********************************************************************************************************************** " +
                        "                            SUCCESS - Your ticket has been added to your account! {0}" +
                        "*********************************************************************************************************************** {0}",
                        Environment.NewLine);

            bool startAgain = Confirmation("Would you like to return to the main menu? [Y/N]");

            if (startAgain)
                MainMenu();
            else
                Program.ExitApp();
        }
    }
}
