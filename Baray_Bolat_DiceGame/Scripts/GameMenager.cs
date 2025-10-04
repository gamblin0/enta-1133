using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
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

        bool playingGame;

        

        List<int> playerDice = new List<int>
        {
            6, 8, 12, 20
        };
        

        List<int> cpuDice = new List<int>
        {
            0,1, 2, 3
        };
    

        public void GameChecker()
        {
            if(playerDice.Count == 0 && cpuDice.Count == 0)
            {
               
                playingGame = false;
                GameWinner();
                GoodbyeMessage();
            }
            else
            {
                playingGame = true; 
            }

           

        }


        public void GoodbyeMessage()
        {
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Thank you for playing!");

        }



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
           

            user.Askname();
            cpu.SetName();
            Rules();
            

            Ready();

            CoinFlip();


            GameChecker();



            do
            {
                
                TurnLoop();
                //gain();
                

            } while (playingGame);

           

        }
        public void Again()
        {
            Console.WriteLine("Do you want to play again?");
            string continueInputAgain = Console.ReadLine();

            if (continueInputAgain == "y")
            {
                Console.WriteLine("Let's roll!!");
                TurnLoop();

            }
            else if (continueInputAgain == "n")
            {
                Console.WriteLine("Well, see you another time!");
                playingGame = false;

            }

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

        public void Ready()
        {
            Console.WriteLine("Are you ready?");
            Console.WriteLine("Type 'y' for yes and 'n' for no");
            string continueInput = Console.ReadLine();

            if (continueInput == "y")
            {
                Console.WriteLine("Let's roll!!");
                
            }
            else if (continueInput == "n")
            {
                Console.WriteLine("Well, you better be because the game is starting!");
                
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
            else
            {
                Console.WriteLine("Please type y/n");
                ContinuePlaying();  
            }
        }

        public void Rules()
        {
            Console.WriteLine("###############################################################################################");
            Console.WriteLine("                                          RULES                                                ");
            Console.WriteLine("###############################################################################################");
            Console.WriteLine("");
            Console.WriteLine("You have 4 dice; 6, 8, 12 and 20.");
            Console.WriteLine("");
            Console.WriteLine("You can only roll each dice once and after you roll the die gets removed from your inventory.");
            Console.WriteLine("");
            Console.WriteLine("Both players roll dice once every turn,");
            Console.WriteLine("");
            Console.WriteLine("Higher roll for that round gets a point.");
            Console.WriteLine("");
            Console.WriteLine("Game continues until there is no dice left in any inventory.");
            Console.WriteLine("");
            Console.WriteLine("The player who has more points at the end of the game wins the game");
            Console.WriteLine("");
            Console.WriteLine("GOOD LUCK!");
            Console.WriteLine("");
            Console.WriteLine("###############################################################################################");
        }

        public void CpuTurn()
        {


            DiceRoller dice = new DiceRoller();

            
            
            Random random = new Random();

            Random randomPick = new Random();

            int picker = randomPick.Next(1, 5);



            if (picker == 1)
            {
                if (cpuDice.Contains(0))
                {
                    cpuOutcome = dice.Roller(6);
                    cpuDice.Remove(0);

                    Console.WriteLine("Opponent is rolling a d6");
                    Console.WriteLine("Opponent rolled " + cpuOutcome + " !");
                }
                else
                {
                    CpuTurn();
                }

                    
            }

            if (picker == 2)
            {
                if (cpuDice.Contains(1))
                {
                    cpuOutcome = dice.Roller(8);
                    cpuDice.Remove(1);

                    Console.WriteLine("Opponent is rolling a d8");
                    Console.WriteLine("Opponent rolled " + cpuOutcome + " !");
                }
                else
                {
                    CpuTurn();
                }
            }

            if (picker == 3)
            {
                if (cpuDice.Contains(2))
                {
                    cpuOutcome = dice.Roller(12);
                    cpuDice.Remove(2);

                    Console.WriteLine("Opponent is rolling a d12");
                    Console.WriteLine("Opponent rolled " + cpuOutcome + " !");
                }
                else
                {
                    CpuTurn();
                }
            }

            if (picker == 4)
            {
                if (cpuDice.Contains(3))
                {
                    cpuOutcome = dice.Roller(20);
                    cpuDice.Remove(3);

                    Console.WriteLine("Opponent is rolling a d20");
                    Console.WriteLine("Opponent rolled " + cpuOutcome + " !");
                }
                else
                {
                    CpuTurn();
                }
            }


        }//the whole loopable cpu turn

        public void PlayerTurn()
        {

            DiceRoller dice = new DiceRoller();


           
               
                //here, is when it is player's turn first. Player is asked to roll and then the cpu rolls. There is most probably a better way to do it with functions but I couldn't make it work when I tried. Might need help with that.
                Console.WriteLine("Which die do you want to roll? (write 6, 8, 12 or 20 to pick the dice.)");
            Console.WriteLine("Dice left: " + string.Join(", ", playerDice));

            if (int.TryParse(Console.ReadLine(), out int number))
                {


                    if (number == 6)
                    {
                    if (playerDice.Contains(6))
                    {
                        playerOutcome = dice.Roller(6);
                        playerDice.Remove(6);


                        Console.WriteLine("You rolled " + playerOutcome + " !");
                    }
                    else
                    {
                        Console.WriteLine("Please pick a different die");
                        PlayerTurn();
                    }

                    }

                    if (number == 8)
                    {

                    if (playerDice.Contains(8))
                    {
                        playerOutcome = dice.Roller(8);
                        playerDice.Remove(8);


                        Console.WriteLine("You rolled " + playerOutcome + " !");
                    }
                    else
                    {
                        Console.WriteLine("Please pick a different die");
                        PlayerTurn();
                    }
                }

                    if (number == 12)
                {
                    if (playerDice.Contains(12))
                    {
                        playerOutcome = dice.Roller(12);
                        playerDice.Remove(12);


                        Console.WriteLine("You rolled " + playerOutcome + " !");
                    }
                    else
                    {
                        Console.WriteLine("Please pick a different die");
                        PlayerTurn();
                    }
                }

                    if (number == 20)
                    {

                    if (playerDice.Contains(20))
                    {
                        playerOutcome = dice.Roller(20);
                        playerDice.Remove(20);


                        Console.WriteLine("You rolled " + playerOutcome + " !");
                    }
                    else
                    {
                        Console.WriteLine("Please pick a different die");
                        PlayerTurn();
                    }
                }



                }
                else
                {
                    Console.WriteLine("Please enter 6, 8, 12 or 20.");
                    PlayerTurn();   
                }
            
        }//the whole loopable player turn
        public void TurnLoop()
        {

            DiceRoller rolling = new DiceRoller();
            //rolling.Roller();


            int playerOutcome = 0;

            int cpuOutcome = 0;



            if (playerTurn)
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

            if (playingGame = true)
            {
                ContinuePlaying();
            }
            else
            {
                Again();
            }
        }

        public void GameWinner()
        {
            if (user.Score > cpu.Score)
            {
                Player player = new Player();

                Console.WriteLine("###############################################################################################");
                Console.WriteLine("THE WINNER IS");
                Console.WriteLine(user.FetchPlayerName());
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("Here are the final scores:");
                Console.WriteLine(user.FetchPlayerName() + ": " + user.Score);
                Console.WriteLine("CPU: " + cpu.Score);
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("###############################################################################################");
            }
            else if (user.Score < cpu.Score)
            {
                Console.WriteLine("###############################################################################################");
                Console.WriteLine("THE WINNER IS");
                Console.WriteLine("THE CPU");
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("Here are the final scores:");
                Console.WriteLine("CPU: " + cpu.Score);
                Console.WriteLine(user.FetchPlayerName() + ": " + user.Score);
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("###############################################################################################");
            }
            else
            {
                Console.WriteLine("###############################################################################################");
                Console.WriteLine("THE GAME TIED!!!");
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("Here are the final scores:");
                Console.WriteLine("CPU: " + cpu.Score);
                Console.WriteLine(user.FetchPlayerName() + ": " + user.Score);
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("###############################################################################################");
            }
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
            else
            {
                Console.WriteLine("It's a TIE!!!");
                Console.WriteLine("No points awarded this round.");
            }
            Console.WriteLine("Your score: " + user.Score + " !");
            Console.WriteLine("Opponent's score: " + cpu.Score + " !");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            GameChecker();

        }
    }
}


        
           
        
        
        //private bool CheckGameAvailability()
        //{
            //if there is dice left
        //}
     
    


