using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baray_Bolat_DiceGame.Scripts
{
    internal class DiceRoller
    {

        //private Die[] allDiceTypes;
        //private int[] diceSizes = new int[] {4,6,8,12,20};

        // public void SetupDice() // set up dice once when the game starts or any time the dice change
        // {
        // allDiceTypes = new Die[diceSizes.Length];
        // for(int i = 0; i < allDiceTypes.Length; i++)
        //{
        //   allDiceTypes[i] = new Die();
        //   allDiceTypes[i].SetDiceMaxValue(diceSizes[i]);
        //}
        // }
        int playerScore; 

        int cpuScore;

       private Random random = new Random();


       // public void Scores()
        //{
            




       // }

        internal int Roller(int sides)
        {
            
            return random.Next(1, sides + 1);
            
  


        }





            

        }

        


       // public void RollAndScore(Player currentTurn)
        //{
            //int toRoll = GetRollForPlayer(currentTurn);
            

       // }

        //private int GetRollForPlayer(Player currentTurn)
       // {
           // if (currentTurn.IsPlayer) //checking if it is player's roll
           // {
           //     return GetUserInputForDiceRoll();
           // }
           // else
           // {
            //    return GetCpuInputForDiceRoll();
           // }
       // }


       // private int GetUserInputForDiceRoll()
       // {
           // return 0; //get the number that was written
       // }

       // private int GetCpuInputForDiceRoll()
       // {
          //  return 0; //get the random number
      //  }




        //public class Die()
       // {
            //public int minRoll = 1;
            //public int maxRollInclusive = 4; //made the default max roll 4

            //public void SetDiceMaxValue(int maxInclusive) //setting the max value for the dice
           // {
              //  maxRollInclusive = maxInclusive;
            //}

           // public int Roll(Random r)
           // {
            //    return r.Next(minRoll, maxRollInclusive + 1);
           // }
       // }


    }



