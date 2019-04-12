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

        public decimal GetFormattedSeatPrice(int tier)
        {
            decimal value = GetSeatPrice(tier);
            value = Math.Round(value, 2);
            return value;
        }

        public decimal GetSeatPrice(int tier)
        {
            switch (tier)
            {
                case 3:
                    return 6.50m;
                case 2:
                    return 12.25m;
                case 1:
                    return 15.00m;
                default:
                    return 0.00m;
            }
        }

    }
}
