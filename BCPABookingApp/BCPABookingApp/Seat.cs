using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BCPABookingApp
{
    class Seat
    {
        public int seatNum;
        public string seatRow;
        public int tier;

        public Seat()
        {
            seatNum = 0;
            seatRow = "";
            tier = 0;
        }

        public Seat(Seat seat)
        {
            seatNum = seat.seatNum;
            seatRow = seat.seatRow;
            tier = seat.tier;
        }

        public Seat SelectSeat(Seat seat)
        {
            Console.WriteLine("{0}" +
                "-------------------------------------------------------SELECT SEAT----------------------------------------------------- {0}" +
                "1. 34H Upper Tier {0}" +
                "2. 18B Lower Tier {0}" +
                "3. 23C Middle Tier {0}", Environment.NewLine);

            Console.WriteLine("Please select an available Seat:");

            var ch = Convert.ToInt32(Console.ReadLine());

            while (!new[] { 1, 2, 3 }.Contains(ch))
            {
                Console.WriteLine("Invalid selection. Please select a valid menu choice number.");
                ch = Convert.ToInt32(Console.ReadLine());
            }

            switch (ch)
            {
                case 1:
                    seat.seatNum = 34; seat.seatRow = "H"; seat.tier = 3;
                    return seat;
                case 2:
                    seat.seatNum = 18; seat.seatRow = "B"; seat.tier = 1;
                    return seat;
                case 3:
                    seat.seatNum = 23; seat.seatRow = "C"; seat.tier = 2;
                    return seat;
                default:
                    Console.WriteLine("There are no seats with this Seat ID" + Environment.NewLine);
                    return seat;

            }
        }
    }
}
