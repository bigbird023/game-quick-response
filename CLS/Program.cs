using System;
using System.Threading;

namespace game_quick_response
{
    class Program
    {
        static int gameSpeed = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quick Response!");

            do {
                retrieveGameLevel();
                Thread.Sleep(1000);

            } while (continueGame());

            
        }

        static void retrieveGameLevel() {
            String inputGameLevel;
            do {
                Console.WriteLine("Please Choose a Game Level (E)asy, (M)edicore, or (H)ard?");
                inputGameLevel = Console.ReadLine();
                Console.WriteLine("You Choose " + inputGameLevel);
                
            } while (!(inputGameLevel.Equals("E") || inputGameLevel.Equals("M") || inputGameLevel.Equals("H")));

            switch (inputGameLevel) {
                case "E":
                    gameSpeed = 1000;
                    break;
                case "M":
                    gameSpeed = 500;
                    break;
                case "H":
                    gameSpeed = 100;
                    break;
               }
        }

        static Boolean continueGame() {
            String inputContinueGame;
            do {
                Console.WriteLine("(C)ontinue or (E)xit");
                inputContinueGame = Console.ReadLine();

                Console.WriteLine("You Choose " + inputContinueGame);
                
            } while (!inputContinueGame.Equals("C") && !inputContinueGame.Equals("E"));

            Boolean ret;
            if (inputContinueGame.Equals("C")) {
                ret = true;
            } else {
                ret = false;
            }
            return ret;
        }
    }
}
