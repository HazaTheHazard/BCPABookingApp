using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApplication
{
    class Show
    {
        private string showName;
        private string showDate;
        private string showTime;

        public Show()
        {
            showName = "";
            showDate = "";
            showTime = "";
        }

        Dictionary<int, string> showDict = new Dictionary<int, string>();

        public string GetShowByID(int id)
        {
            if (id == 1)
                return "Avengers: Endgame";
            else if (id == 2)
                return "Jurassic World III";
            else if (id == 3)
                return "Star Wars: Episode IX";

            return "No show with this ID";
        }

        public void SelectShow()
        {
            Console.WriteLine("{0}" +
                "-------------------------------------------------------SELECT SHOW----------------------------------------------------- {0}" +
                "1. Avengers: Endgame {0}" +
                "2. Jurassic World III {0}" +
                "3. Star Wars: Episode IX {0}", Environment.NewLine);

        }

    }
}
