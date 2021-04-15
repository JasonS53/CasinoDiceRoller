using System;
using System.Collections.Generic;

namespace CasinoDiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Circus Casino!");
            Random rand = new Random();

            getDiceResults(rand);
        }
        static void getDiceResults(Random rand)
        {
            Console.WriteLine("How many sides do you want the dice to have?");
            int sides;
            while (true)
            {
                try
                {
                    sides = int.Parse(Console.ReadLine());
                    if (sides < 0)
                    {
                        throw new Exception("That number is too low");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That was not a number");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            int dice1 = rand.Next(1, sides);
            int dice2 = rand.Next(1, sides);
            int results = dice1 + dice2;
            Console.WriteLine($"You rolled a {dice1} and a {dice2} ({results} total)");

            if (sides == 6)
            {
                showDiceOutputMessage(dice1, dice2, results);
            }
            bool RunProgram = true;
            while (RunProgram)
            {
                Console.WriteLine();
                Console.WriteLine("Roll again? (y/n)");
                string yesno = Console.ReadLine();
                if (yesno == "y")
                    
                {
                    RunProgram = false;
                }
                else if (yesno == "n")
                {
                    Console.WriteLine("Thanks for playing!!");
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid input.  Please chose y/n");
                }
            }
        }
        static void showDiceOutputMessage(int dice1, int dice2, int results)
        {
            if (dice1 == 1 && dice2 == 1)
            {
                Console.WriteLine("Snake Eyes");
                Console.WriteLine("Craps!");
            }
            else if (dice1 == 1 && dice2 == 2)
            {
                Console.WriteLine("Ace Deuce");
                Console.WriteLine("Craps!");
            }
            else if (dice1 == 2 && dice2 == 1)
            {
                Console.WriteLine("Ace Deuce");
                Console.WriteLine("Craps!");
            }
            else if (dice1 == 6 && dice2 == 6)
            {
                Console.WriteLine("Boxcars");
                Console.WriteLine("Craps!");
            }
            else if (results == 7 || results == 11)
            {
                Console.WriteLine("Win!");
            }
        }
    }
}

