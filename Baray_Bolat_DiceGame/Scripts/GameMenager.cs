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

            string playerName = Console.ReadLine(); // I get the player's input

            Console.WriteLine("Hello, " + playerName + " let's roll"); // I respond to player's input

            return playerName; // I return it to be able to use it.


        }



    }





    internal class Die
    {

        
        internal void Rolling()
        {
            Player user = new Player();

            Player cpu = new Player();

            Random turnOrder = new Random();

            int playerScore = 0; //these are used later to compare the results and give a point to the winning side

            int cpuScore = 0; //these are used later to compare the results and give a point to the winning side

            int playerOutcome = 0; // these are to store the random outcome that will be used later to compare the outcomes

            int cpuOutcome = 0; // these are to store the random outcome that will be used later to compare the outcomes

            int coinFlip = turnOrder.Next(2); // this is to decide which side goes first

            bool playerTurn = coinFlip > 0; // if the coinflip is 1 it is player's turn and I use this in the next if to make it player's tirn first

            user.GetPlayerName();

            if (playerTurn)
            {
                //here, is when it is player's turn first. Player is asked to roll and then the cpu rolls. There is most probably a better way to do it with functions but I couldn't make it work when I tried. Might need help with that.
                Console.WriteLine("Which die do you want to roll? (write 6, 8, 12 or 20 to pick the dice.)");

                if (int.TryParse(Console.ReadLine(), out int number))
                {

                    if (number == 6)
                    {
                        Random prandom = new Random();
                        int pd6 = prandom.Next(1, 7); //named pd6 for player d6
                        Console.WriteLine("You rolled " + pd6 + " !");

                        playerOutcome += pd6; //the outcome is the roll that was made and this will be used to compare
                    }

                    if (number == 8)
                    {
                        Random prandom = new Random();
                        int pd8 = prandom.Next(1, 9); //named pd8 for player d8
                        Console.WriteLine("You rolled " + pd8 + " !");

                        playerOutcome += pd8;  //the outcome is the roll that was made and this will be used to compare
                    }

                    if (number == 12)
                    {
                        Random prandom = new Random();
                        int pd12 = prandom.Next(1, 13); //named pd12 for player d12
                        Console.WriteLine("You rolled " + pd12 + " !");

                        playerOutcome += pd12;  //the outcome is the roll that was made and this will be used to compare
                    }

                    if (number == 20)
                    {
                        Random prandom = new Random();
                        int pd20 = prandom.Next(1, 21); //named pd20 for player d20
                        Console.WriteLine("You rolled " + pd20 + " !");

                        playerOutcome += pd20;  //the outcome is the roll that was made and this will be used to compare
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

                        cpuOutcome += cd6;  //the outcome is the roll that was made and this will be used to compare
                    }

                    if (picker == 2)
                    {
                        int cd8 = random.Next(1, 9);
                        Console.WriteLine("Opponent is rolling a d8");
                        Console.WriteLine("Opponent rolled " + cd8 + " !");

                        cpuOutcome += cd8;  //the outcome is the roll that was made and this will be used to compare
                    }

                    if (picker == 3)
                    {
                        int cd12 = random.Next(1, 13);
                        Console.WriteLine("Opponent is rolling a d12");
                        Console.WriteLine("Opponent rolled " + cd12 + " !");

                        cpuOutcome += cd12;  //the outcome is the roll that was made and this will be used to compare
                    }

                    if (picker == 4)
                    {
                        int cd20 = random.Next(1, 21);
                        Console.WriteLine("Opponent is rolling a d20");
                        Console.WriteLine("Opponent rolled " + cd20 + " !");

                        cpuOutcome += cd20;  //the outcome is the roll that was made and this will be used to compare
                    }

                    if (playerOutcome > cpuOutcome)
                    {
                        playerScore++; // if player's role is bigger than cpu's role, player gets a point

                    }
                    else if (playerOutcome < cpuOutcome)
                    {
                        cpuScore++; // if cpu's role is bigger than player's role, player gets a point
                    }

                }
                else
                {
                    Console.WriteLine("Please enter 6, 8, 12 or 20.");
                }
            }
            else
            {
                //here, is when it is cpu's turn first. Cpu rolls and then player is asked to roll. There is most probably a better way to do it with functions but I couldn't make it work when I tried. Might need help with that.
                Random random = new Random();

                Random randomPick = new Random();

                int picker = randomPick.Next(1, 5);



                if (picker == 1)
                {
                    int cd6 = random.Next(1, 7);
                    Console.WriteLine("Opponent is rolling a d6");
                    Console.WriteLine("Opponent rolled " + cd6 + " !");

                    cpuOutcome += cd6;  //the outcome is the roll that was made and this will be used to compare
                }

                if (picker == 2)
                {
                    int cd8 = random.Next(1, 9);
                    Console.WriteLine("Opponent is rolling a d8");
                    Console.WriteLine("Opponent rolled " + cd8 + " !");

                    cpuOutcome += cd8;  //the outcome is the roll that was made and this will be used to compare
                }

                if (picker == 3)
                {
                    int cd12 = random.Next(1, 13);
                    Console.WriteLine("Opponent is rolling a d12");
                    Console.WriteLine("Opponent rolled " + cd12 + " !");

                    cpuOutcome += cd12;  //the outcome is the roll that was made and this will be used to compare
                }

                if (picker == 4)
                {
                    int cd20 = random.Next(1, 21);
                    Console.WriteLine("Opponent is rolling a d20");
                    Console.WriteLine("Opponent rolled " + cd20 + " !");

                    cpuOutcome += cd20;  //the outcome is the roll that was made and this will be used to compare
                }

                Console.WriteLine("Which die do you want to roll? (write 6, 8, 12 or 20 to pick the dice.)");

                if (int.TryParse(Console.ReadLine(), out int number))
                {

                    if (number == 6)
                    {
                        Random randoma = new Random();
                        int pd6 = randoma.Next(1, 7); //named pd6 for player d6
                        Console.WriteLine("You rolled " + pd6 + " !");

                        playerOutcome += pd6;  //the outcome is the roll that was made and this will be used to compare
                    }

                    if (number == 8)
                    {
                        Random randoma = new Random();
                        int pd8 = randoma.Next(1, 9); //named pd8 for player d8
                        Console.WriteLine("You rolled " + pd8 + " !");

                        playerOutcome += pd8;  //the outcome is the roll that was made and this will be used to compare
                    }

                    if (number == 12)
                    {
                        Random randoma = new Random();
                        int pd12 = randoma.Next(1, 13); //named pd12 for player d12
                        Console.WriteLine("You rolled " + pd12 + " !");

                        playerOutcome += pd12;  //the outcome is the roll that was made and this will be used to compare
                    }

                    if (number == 20)
                    {
                        Random randoma = new Random();
                        int pd20 = randoma.Next(1, 21); //named pd20 for player d20
                        Console.WriteLine("You rolled " + pd20 + " !");

                        playerOutcome += pd20;  //the outcome is the roll that was made and this will be used to compare
                    }







                }

                if (playerOutcome > cpuOutcome)
                {
                    playerScore++; // if player's role is bigger than cpu's role, player gets a point

                }
                else if (playerOutcome < cpuOutcome)
                {
                    cpuScore++; // if cpu's role is bigger than player's role, player gets a point
                }


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

                Console.WriteLine("Thank you for playing!");



            }

        }
    }
}

