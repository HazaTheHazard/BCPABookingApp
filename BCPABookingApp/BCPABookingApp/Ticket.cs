using System;
using System.Collections.Generic;
using System.Text;

namespace BCPABookingApp
{
    class Ticket : Seat
    {
        public decimal price;

        public Ticket()
        {
            price = 0.00m;
        }

        public decimal GetFormattedSeatPrice(string seatNum)
        {
            decimal value = GetSeatPrice(seatNum);
            value = Math.Round(value, 2);
            return value;
        }

        public decimal GetSeatPrice(string seatNum)
        {
            switch (seatNum)
            {
                case "34H":
                    return 6.50m;
                case "18B":
                    return 14.00m;
                case "23C":
                    return 12.25m;
                default:
                    return 0.00m;
            }
        }

    }
}
