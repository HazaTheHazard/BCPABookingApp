using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BCPABookingApp
{
    class Show
    {
        public string showName;
        public string showDate;
        public string showTime;

        public Show()
        {
            showName = "";
            showDate = "";
            showTime = "";
        }

        public Show(Show show)
        {
            showName = show.showName;
            showDate = show.showDate;
            showTime = show.showTime;
        }

        public string SelectShow()
        {
            Console.WriteLine("{0}" +
                "-------------------------------------------------------SELECT SHOW----------------------------------------------------- {0}" +
                "1. Avengers: Endgame {0}" +
                "2. Jurassic World III {0}" +
                "3. Star Wars: Episode IX {0}", Environment.NewLine);

            Console.WriteLine("Please select a show:");

            var ch = Convert.ToInt32(Console.ReadLine());

            while (!new[] { 1, 2, 3 }.Contains(ch))
            {
                Console.WriteLine("Invalid selection. Please select a valid menu choice number.");
                ch = Convert.ToInt32(Console.ReadLine());
            }

            switch (ch)
            {
                case 1:
                    return "Avengers: Endgame";
                case 2:
                    return "Jurassic World III";
                case 3:
                    return "Star Wars: Episode IX";
                default:
                    return "There are no shows with this ID";

            }

        }

        public string SelectShowTime()
        {
            Console.WriteLine("{0}" +
                 "----------------------------------------------------SELECT SHOW TIME-------------------------------------------------- {0}" +
                 " There are 3 showings available today: {0}" +
                 "1. 13:30 {0}" +
                 "2. 19:00 {0}" +
                 "3. 22:30 {0}", Environment.NewLine);

            Console.WriteLine("Please select a show time:");

            var ch = Convert.ToInt32(Console.ReadLine());

            while (!new[] { 1, 2, 3 }.Contains(ch))
            {
                Console.WriteLine("Invalid selection. Please select a valid menu choice number.");
                ch = Convert.ToInt32(Console.ReadLine());
            }

            switch (ch)
            {
                case 1:
                    return "13:30";
                case 2:
                    return "19:00";
                case 3:
                    return "22:30";
                default:
                    return "There are no shows with this ID";

            }
        }

    }
}
