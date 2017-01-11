using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{
  class BlackJack
  {
        static void Main()
        {
            MBlackjack();
            Veikkaus.Lotto.DrawLotto();
        }
        static void MBlackjack()
        { 
      int myNumber;
      int theirNumber= 0;
      string exit = "null";

                Random rnd = new Random();
                myNumber = rnd.Next(10, 22);
                Console.WriteLine("*** BlackJack! ***");

            do {
                Console.Write("Can you beat my number? Enter any number between 1-21: ");
                
                //reading and converting
                theirNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                //comparing that given number is valid
                while (theirNumber < 1 || theirNumber > 21)
                {
                    Console.Write("The given number is out of limits! From between the numbers 1-21, try again: ");
                    theirNumber = Convert.ToInt32(Console.ReadLine());
                }
                               
                //comparing
                if (theirNumber >= myNumber && theirNumber <= 21)
                {
                        Console.WriteLine("My number: " + myNumber + ". You win.");
                        Console.WriteLine();
                }
                else
                {
                        Console.WriteLine("My number: " + myNumber + ". You lose.");
                        Console.WriteLine();
                }
                Console.WriteLine("Play again? Press any number to replay. Type 'x' or 'exit' to exit.");
                
                exit = Console.ReadLine();
               /* if (exit != "x" && exit != "exit")
                {
                    if (theirNumber == )
                    Console.WriteLine("Plese, do not deviate from the given options!");
                }
                */

             } while (exit != "x" && exit != "exit");
    }
  }
}