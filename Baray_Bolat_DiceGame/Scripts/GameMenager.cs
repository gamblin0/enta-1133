using Baray_Bolat_DiceGame.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Baray_Bolat_DiceGame.Scripts
{
    internal class Player
    {
        internal string GetPlayerName()
        {
            Console.WriteLine("What is your name?");

            string playerName = Console.ReadLine();

            Console.WriteLine("Hello, " + playerName + " let's roll");

            return playerName;


        }



    }





    internal class Die
    {


        internal void Rolling()
        {
            Player user = new Player();

            Player cpu = new Player();

            Random turnOrder = new Random();

            int playerScore = 0;

            int cpuScore = 0;

            int playerOutcome = 0;

            int cpuOutcome = 0;

            int coinFlip = turnOrder.Next(2);

            bool playerTurn = coinFlip > 0;

            user.GetPlayerName();

            if (playerTurn)
            {
                Console.WriteLine("Which die do you want to roll? (write 6, 8, 12 or 20 to pick the dice.)");

                if (int.TryParse(Console.ReadLine(), out int number))
                {

                    if (number == 6)
                    {
                        Random prandom = new Random();
                        int pd6 = prandom.Next(1, 7); //named pd6 for player d6
                        Console.WriteLine("You rolled " + pd6 + " !");

                        playerOutcome += pd6;
                    }

                    if (number == 8)
                    {
                        Random prandom = new Random();
                        int pd8 = prandom.Next(1, 9); //named pd8 for player d8
                        Console.WriteLine("You rolled " + pd8 + " !");

                        playerOutcome += pd8;
                    }

                    if (number == 12)
                    {
                        Random prandom = new Random();
                        int pd12 = prandom.Next(1, 13); //named pd12 for player d12
                        Console.WriteLine("You rolled " + pd12 + " !");

                        playerOutcome += pd12;
                    }

                    if (number == 20)
                    {
                        Random prandom = new Random();
                        int pd20 = prandom.Next(1, 21); //named pd20 for player d20
                        Console.WriteLine("You rolled " + pd20 + " !");

                        playerOutcome += pd20;
                    }

                    Console.WriteLine("It's your opponent's turn!");

                    Random random = new Random();

                    Random randomPick = new Random();

                    int picker = randomPick.Next(1, 5);



                    if (picker == 1)
                    {
                        int cd6 = random.Next(1, 7);
                        Console.WriteLine("Opponent is rolling a d6");
                        Console.WriteLine("Opponent rolled " + cd6 + " !");

                        cpuOutcome += cd6;
                    }

                    if (picker == 2)
                    {
                        int cd8 = random.Next(1, 9);
                        Console.WriteLine("Opponent is rolling a d8");
                        Console.WriteLine("Opponent rolled " + cd8 + " !");
                        cpuOutcome += cd8;
                    }

                    if (picker == 3)
                    {
                        int cd12 = random.Next(1, 13);
                        Console.WriteLine("Opponent is rolling a d12");
                        Console.WriteLine("Opponent rolled " + cd12 + " !");
                        cpuOutcome += cd12;
                    }

                    if (picker == 4)
                    {
                        int cd20 = random.Next(1, 21);
                        Console.WriteLine("Opponent is rolling a d20");
                        Console.WriteLine("Opponent rolled " + cd20 + " !");
                        cpuOutcome += cd20;
                    }


                }
                else
                {
                    Console.WriteLine("Please enter 6, 8, 12 or 20.");
                }
            }
            else
            {

                Random random = new Random();

                Random randomPick = new Random();

                int picker = randomPick.Next(1, 5);



                if (picker == 1)
                {
                    int cd6 = random.Next(1, 7);
                    Console.WriteLine("Opponent is rolling a d6");
                    Console.WriteLine("Opponent rolled " + cd6 + " !");

                    cpuOutcome += cd6;
                }

                if (picker == 2)
                {
                    int cd8 = random.Next(1, 9);
                    Console.WriteLine("Opponent is rolling a d8");
                    Console.WriteLine("Opponent rolled " + cd8 + " !");
                    cpuOutcome += cd8;
                }

                if (picker == 3)
                {
                    int cd12 = random.Next(1, 13);
                    Console.WriteLine("Opponent is rolling a d12");
                    Console.WriteLine("Opponent rolled " + cd12 + " !");
                    cpuOutcome += cd12;
                }

                if (picker == 4)
                {
                    int cd20 = random.Next(1, 21);
                    Console.WriteLine("Opponent is rolling a d20");
                    Console.WriteLine("Opponent rolled " + cd20 + " !");
                    cpuOutcome += cd20;
                }

                Console.WriteLine("Which die do you want to roll? (write 6, 8, 12 or 20 to pick the dice.)");

                if (int.TryParse(Console.ReadLine(), out int number))
                {

                    if (number == 6)
                    {
                        Random randoma = new Random();
                        int pd6 = randoma.Next(1, 7); //named pd6 for player d6
                        Console.WriteLine("You rolled " + pd6 + " !");

                        playerOutcome += pd6;
                    }

                    if (number == 8)
                    {
                        Random randoma = new Random();
                        int pd8 = randoma.Next(1, 9); //named pd8 for player d8
                        Console.WriteLine("You rolled " + pd8 + " !");

                        playerOutcome += pd8;
                    }

                    if (number == 12)
                    {
                        Random randoma = new Random();
                        int pd12 = randoma.Next(1, 13); //named pd12 for player d12
                        Console.WriteLine("You rolled " + pd12 + " !");

                        playerOutcome += pd12;
                    }

                    if (number == 20)
                    {
                        Random randoma = new Random();
                        int pd20 = randoma.Next(1, 21); //named pd20 for player d20
                        Console.WriteLine("You rolled " + pd20 + " !");

                        playerOutcome += pd20;
                    }







                }

                


            }

            if (playerOutcome > cpuOutcome)
            {
                playerScore++;

            }
            else if (playerOutcome < cpuOutcome)
            {
                cpuScore++;
            }

            Console.WriteLine("Here are the results:");

            Console.WriteLine("You: " + playerScore);

            Console.WriteLine("Opponent: " + cpuScore);
        }








        internal class GameMenager
        {








            //created a function to play the game
            internal void Playgame()
            {


                //welcome message
                Console.WriteLine("Welcome player, it's Baray and today's date is 2025-09-25.");








                //created an instance to call Dieroller class to GameManager class
                Die DieRollerInstance = new Die();

                //activated Rolling function that was inside the DieRoller class
                DieRollerInstance.Rolling();

                Console.WriteLine("");
                Console.WriteLine("");



            }

        }
    }
}

