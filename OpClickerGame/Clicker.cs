using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpClickerGame
{
    internal class Clicker
    {
        public int PointsPerClick = 1;
        public char KeyPress = 's';
        public string Press {get; set;}
        public int Count = 0;
        public int TotalPoints = 0;

        public void ClickForPoints()
        {
            Console.Clear();
            TotalPoints += PointsPerClick;
                //Console.ReadKey();
                Console.WriteLine("Total Points: " + TotalPoints);
              

        }

        public void Upgrade1()
        {
            if (TotalPoints >= 10)
            {
                TotalPoints -= 10;
                PointsPerClick++;
                Console.WriteLine("Bought Upgrade 1 for 10 Points. +1 PPC");
                Console.WriteLine($"Total Points: {TotalPoints}");
            }
            else
            {
                Console.WriteLine("Du har ikke nok poeng til oppgradering!");
            }
        }

    }
}
