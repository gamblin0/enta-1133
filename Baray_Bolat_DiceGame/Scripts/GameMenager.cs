using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baray_Bolat_DiceGame.Scripts
{
   internal class DieRoller
    {
        Random random = new Random();

        internal void Rolling()
        {
            int d6 = random.Next(1, 7); //created random number generator for d6
            int d8 = random.Next(1, 9); //created random number generator for d8
            int d12 = random.Next(1, 13); //created random number generator for d12
            int d20 = random.Next(1, 21); //created random number generator for d20
            int total = d6 + d8 + d12 + d20; //created total to write the sum of the outcomes

            //printing each roll outcome
            Console.WriteLine("Your d6 rolled " + d6 + "!");
            

            Console.WriteLine("Your d8 rolled " + d8 + "!");


            Console.WriteLine("Your d12 rolled " + d12 + "!");


            Console.WriteLine("Your d20 rolled " + d20 + "!");

            //printing the total outcome
            Console.WriteLine(" Your total point is " + total + "!");
            
        }
        
        
    }
    
    
    
    
    
    
    
    
    internal class GameMenager
    {
        //created a function to play the game
        internal void Playgame()
        {
            //welcome message
            Console.WriteLine("Welcome player, it's Baray and today's date is 2025-09-17!");

            //created an instance to call Dieroller class to GameMenager class
            DieRoller DieRollerInstance = new DieRoller();

            //activated Rolling function that was inside the DieRoller class
            DieRollerInstance.Rolling();

        }

    }
}
