using System;

namespace OpClickerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clicker = new Clicker();
            Console.WriteLine("WELCOME TO THA OP CLICKA GAME!!!");

            while (true)
            {
                var command = Console.ReadKey(true);
                if (command.KeyChar == '1')
                {
                    clicker.ClickForPoints();
                }
                else if (command.KeyChar == '2')
                {
                    clicker.Upgrade1();
                }
            }
        }
    }
}
/*
 - Poeng per klikk
 - Oppgradering for å få flere poeng per klikk?
 - Kan vinne klikkerspillet?
 - 
*/
