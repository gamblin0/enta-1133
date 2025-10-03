using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baray_Bolat_DiceGame.Scripts
{



    internal class GameMenager
    {
        Player user = new Player();

        Player cpu = new Player();

        bool playerTurn;

        int playerOutcome;

        int cpuOutcome;

        bool playingGame = true;

        public int CoinFlip()
        {
            Random turnOrder = new Random();

            int coinFlip = turnOrder.Next(2);

            playerTurn = coinFlip > 0;

            Console.WriteLine("Flipping a coin to decide who goes first...");

            return coinFlip;
        }




        //created a function to play the game
        public void Playgame()
        {



            Player user = new Player();
            Player cpu = new Player();
            Random r = new Random();
            DiceRoller roller = new DiceRoller();
            // roller.SetupDice();


            //user.Askname();
            //cpu.SetName();

            //int coinflip = r.Next(0, 2);
            //Player currentTurn;


            //if (coinflip == 0)
            // {
            //currentTurn = user;

            //Console.WriteLine("cpu's turn");
            //}

            // else
            //currentTurn = cpu;

            user.Askname();
            cpu.SetName();

            CoinFlip();


            

            do
            {
                TurnLoop();

            } while (playingGame);
        }


        private void CompareTurns(Player firstPlayer, int firstPlayerRoll, Player secondPlayer, int secondPlayerRoll)
        {
            if (firstPlayerRoll > secondPlayerRoll)
            {
                Console.WriteLine(firstPlayer.PlayerName + " wins this round!");
                firstPlayer.Score++;
            }
            else if (firstPlayerRoll < secondPlayerRoll)
            {
                Console.WriteLine(secondPlayer.PlayerName + " wins this round!");
                secondPlayer.Score++;
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("No points this round.");
            }
        }



        public void ContinuePlaying()
        {

            Console.WriteLine("Do you want to keep playing?");
            Console.WriteLine("Type 'y' for yes and 'n' for no");
            string continueInput = Console.ReadLine();

            if (continueInput == "y")
            {
                TurnLoop();
            }
            else if (continueInput == "n")
            {
                Console.WriteLine("Thanks for playing!");
                playingGame = false;    
            }
        }


        public void CpuTurn()
        {

            DiceRoller dice = new DiceRoller();

            

            Random random = new Random();

            Random randomPick = new Random();

            int picker = randomPick.Next(1, 5);



            if (picker == 1)
            {
                cpuOutcome = dice.Roller(6);
                Console.WriteLine("Opponent is rolling a d6");
                Console.WriteLine("Opponent rolled " + cpuOutcome + " !");
            }

            if (picker == 2)
            {
                cpuOutcome = dice.Roller(8);
                Console.WriteLine("Opponent is rolling a d8");
                Console.WriteLine("Opponent rolled " + cpuOutcome + " !");
            }

            if (picker == 3)
            {
                cpuOutcome = dice.Roller(12);
                Console.WriteLine("Opponent is rolling a d12");
                Console.WriteLine("Opponent rolled " + cpuOutcome + " !");
            }

            if (picker == 4)
            {
                cpuOutcome = dice.Roller(20);
                Console.WriteLine("Opponent is rolling a d20");
                Console.WriteLine("Opponent rolled " + cpuOutcome + " !");
            }


        }

        public void PlayerTurn()
        {

            DiceRoller dice = new DiceRoller();


           
               
                //here, is when it is player's turn first. Player is asked to roll and then the cpu rolls. There is most probably a better way to do it with functions but I couldn't make it work when I tried. Might need help with that.
                Console.WriteLine("Which die do you want to roll? (write 6, 8, 12 or 20 to pick the dice.)");

                if (int.TryParse(Console.ReadLine(), out int number))
                {


                    if (number == 6)
                    {
                        playerOutcome = dice.Roller(6);

                        Console.WriteLine("You rolled " + playerOutcome + " !");


                    }

                    if (number == 8)
                    {

                        playerOutcome = dice.Roller(8);

                        Console.WriteLine("You rolled " + playerOutcome + " !");
                    }

                    if (number == 12)
                    {
                        playerOutcome = dice.Roller(12);

                        Console.WriteLine("You rolled " + playerOutcome + " !");
                    }

                    if (number == 20)
                    {

                        playerOutcome = dice.Roller(20);

                        Console.WriteLine("You rolled " + playerOutcome + " !");
                    }



                }
                else
                {
                    Console.WriteLine("Please enter 6, 8, 12 or 20.");
                    PlayerTurn();   
                }
            
        }
        public void TurnLoop()
        {

            DiceRoller rolling = new DiceRoller();
            //rolling.Roller();


            int playerOutcome = 0;

            int cpuOutcome = 0;

            if(playerTurn)
            {
                Console.WriteLine("It's your turn!");
                PlayerTurn();
                CpuTurn();
            }
            else
            {
                Console.WriteLine("It's your opponent's turn!");
                CpuTurn();
                PlayerTurn();
            }

        
            
            ScoreCheck();
            ContinuePlaying();




        }
        internal void ScoreCheck()
        {

            if (playerOutcome > cpuOutcome)
            {
                user.Score++; // if player's role is bigger than cpu's role, player gets a point

            }
            else if (playerOutcome < cpuOutcome)
            {
                cpu.Score++; // if cpu's role is bigger than player's role, player gets a point
            }

            Console.WriteLine("Your score: " + user.Score + " !");
            Console.WriteLine("Opponent's score: " + cpu.Score + " !");

        }
    }
}


        
           
        
        
        //private bool CheckGameAvailability()
        //{
            //if there is dice left
        //}
     
    


