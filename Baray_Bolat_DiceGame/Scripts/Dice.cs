using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baray_Bolat_DiceGame.Scripts
{
    internal class DiceRoller
    {

        
        int playerScore; 

        int cpuScore;

       private Random random = new Random();


        

        internal int Roller(int sides)
        {

            return random.Next(1, sides + 1);


        }

        //List<int> playerDice = new List<int>//dice list of player
        //{
        //    6, 8, 12, 20
        //};
       // public List<int> PlayerDice => new List<int>(playerDice);



       //List<int> cpuDice = new List<int>//dice list of cpu
       // {
       //     0, 1, 2, 3
       // };
       // public List<int> CpuDice => new List<int>(cpuDice);






    }

        


      


    }



