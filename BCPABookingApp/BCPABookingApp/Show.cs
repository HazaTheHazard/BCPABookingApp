using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApplication
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


        Dictionary<int, string> showDict = new Dictionary<int, string>();

        public string GetShowByID(int id)
        {
            if (id == 1)
                showName = "Avengers: Endgame";
            else if (id == 2)
                showName = "Jurassic World III";
            else if (id == 3)
                showName = "Star Wars: Episode IX";

            return showName;
        }

        public int SelectShowID()
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

            return ch;
        }


    }
}
