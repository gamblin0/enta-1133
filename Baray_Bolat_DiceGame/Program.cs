using Baray_Bolat_DiceGame.Scripts;

namespace Baray_Bolat_DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //created an instance to call the gamemenager to program
           GameManager manager = new GameManager(); //constuctor
            manager.Start();

        }
    }
}
