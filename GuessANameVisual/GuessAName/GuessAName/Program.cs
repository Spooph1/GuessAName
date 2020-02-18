using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessAName
{
    class Program
    {
            // the "const" keyword makes the value of the variable final, meaning it can never be modified
            // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
            const int MaxTrials = 10;

            static void Main(string[] args)
            {
            /* TO DO: here is where you add your code! */
            int GuessCounter = 0;
            string TheName = "Jesper";
            bool EndGame = false;

            do { 
                Console.WriteLine("Please make a guess of the name:");
                string input = Console.ReadLine();
                if (GuessCounter < MaxTrials-1)
                {
                    if (input == TheName)
                    {
                        Console.WriteLine("Congratualtion! You guessed the name, which makes you the new champ of guessing!");
                        Console.ReadLine();
                        EndGame = true;
                    }
                    else if(input != TheName)
                    {
                        GuessCounter++;
                        Console.WriteLine("You guessed wrong. You now have " + (10 - GuessCounter).ToString() + " guesses left");

                    }
                }
                else
                {
                    Console.WriteLine("You are out of guesses. Better luck next time");
                    Console.ReadLine();
                    EndGame = true;
                }
            }
            while (EndGame == false);
            }
    }
}


