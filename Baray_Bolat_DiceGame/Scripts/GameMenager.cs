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
              Console.WriteLine("Your total point is " + total + "!");
            
        }
        
        
    }
    
    
    internal class Operators //created a class to explain the operators
    {
        internal void Arihmetics()
        {
            int first = 16;
            int second = 4;

              Console.WriteLine("Hi again, this is to explain how arithmetic operators work! Our first number is 16 and the second one is 4!");
              Console.WriteLine("Our first number is 16 and the second one is 4!");

              Console.WriteLine("");


              Console.WriteLine(++first); //added 1 to the first number so until next usage, it will stay 17

              Console.WriteLine("We used '++' to add 1 to our first number");

              Console.WriteLine(""); //used this for space throughout the code


              Console.WriteLine(--first); //after subtracting 1 from the first number, it goes back to 16 so we can use it as 16 from now on

              Console.WriteLine("Then we used '--' to subtract 1 from our first number after we added 1 before that");

              Console.WriteLine("");


              Console.WriteLine(first + second); //added both numbers with +

              Console.WriteLine("We added both of our numbers to eachother using '+' (16 + 4 = 20)");

              Console.WriteLine("");


              Console.WriteLine(first - second); //subtracted both numbers with -

              Console.WriteLine("We subtracted secon number from the firts one using '-' (16 - 4 = 12)");

              Console.WriteLine("");


              Console.WriteLine(first * second); //multiplied numbers with *

              Console.WriteLine("We multiplied our nubers using '*' (16 x 4 = 64)");

              Console.WriteLine("");


              Console.WriteLine(first / second); //divided numbers wiht /

              Console.WriteLine("We divided our first number with the second one using '/' (16 / 4 = 4)");

              Console.WriteLine("");


              Console.WriteLine(first % second); //used remainder with %

              Console.WriteLine("We used remainder with '%' (16 - (16 / 4) x 4 = 0)");


        }
    }
    
    
    
    
    
    internal class GameManager
    {
        //created a function to play the game
        internal void Playgame()
        {
            //welcome message
            Console.WriteLine("Welcome player, it's Baray and today's date is 2025-09-17!");

            //created an instance to call Dieroller class to GameManager class
              DieRoller DieRollerInstance = new DieRoller();

            //activated Rolling function that was inside the DieRoller class
                DieRollerInstance.Rolling();

            Console.WriteLine("");
            Console.WriteLine("");

              Operators OperatorInstance = new Operators(); //called the operatorss class with the instance

                OperatorInstance.Arihmetics();

            Console.WriteLine("");

            Console.WriteLine("This has been fun! Today's date is 2025-09-18. Until next time, bye!");

        }

    }
}
