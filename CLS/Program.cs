using System;
using System.Threading;

namespace game_quick_response
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quick Response!");

            Console.WriteLine("Please Choose a Game Level (E)asy, (M)edicore, or (H)ard?");
            int inputRead = Console.Read();
            Char gameLevel = Convert.ToChar(inputRead);
            Console.WriteLine(inputRead.ToString());
            Thread.Sleep(1000);

            Console.WriteLine("You Choose " + gameLevel);
        }
    }
}
