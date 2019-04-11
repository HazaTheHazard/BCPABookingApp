using System;
using System.Collections.Generic;
using System.Text;

namespace BCPABookingApp
{
    public class Customer
    {
        public string last;
        public string first;
        public string address;

        public Customer()
        {
            last = "";
            first = "";
            address = "";
        }

        public Customer(Customer customer)
        {
            last = customer.last;
            first = customer.first;
            address = customer.address;
        }

        public bool LoggedIn()
        {
            string username;

            Console.WriteLine("-------------------------------------------------------LOG IN-------------------------------------------------------");
            Console.WriteLine("Welcome to the Bucks Centre for the Performing Arts Ticket Booking System");


            Console.WriteLine("Please enter your username: ");
            username = Console.ReadLine();

            while (username.Length < 6)
            {
                Console.WriteLine("Your username is too short");
                Console.WriteLine("Please re-enter your username: ");
                username = Console.ReadLine();
            }

            Console.WriteLine("Welcome back, " + username + ".");

            return true;
        }

        public Customer GetProfileInfo(Customer customer)
        {
            customer.first = "Harry";
            customer.last = "Keogh";
            customer.address = "123 Test Street";

            return customer;
        }


    }
}
