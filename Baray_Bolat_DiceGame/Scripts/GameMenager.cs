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








        //created a function to play the game
        internal void Playgame()
        {


            Player user = new Player();
            Player cpu = new Player();
            Random r = new Random();
            DiceRoller roller = new DiceRoller();
            roller.SetupDice();

            user.Askname();
            cpu.SetName();

            int coinflip = r.Next(0, 2);
            Player currentTurn;


            if (coinflip == 0)
                currentTurn = user;
            else
                currentTurn = cpu;


            bool playingGame = false;

            while (playingGame)
            {
                //int firstPlayerRoll = TurnLoop(currentTurn);

                if (currentTurn == user)

                    currentTurn = cpu;

                else currentTurn = user;

                //int secondPayerRoll = TurnLoop(currentTurn);


                //CompareTurns(firstPlayerRoll,secondPayerRoll);
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

       


          

        //DiceRoller roller = new DiceRoller();
       // roller.AskPlayerForDiceInput();


        public void TurnLoop(Player currentTurn)
        {


            Console.WriteLine("Player's turn");



        }








        //created an instance to call Dieroller class to GameManager class
     
        }
    }

