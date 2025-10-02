using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baray_Bolat_DiceGame.Scripts
{
    internal class Player
    {
        public string PlayerName;
        public int Score = 0;
        public bool IsPlayer;

        public void Askname()
        {
            string asknameMessage = "What is your name?";
            Console.WriteLine(asknameMessage);
            PlayerName = Console.ReadLine();
            Console.WriteLine();
            IsPlayer = true;
        }


        public void SetName()
        {
            PlayerName = "cpu";
            IsPlayer = false;
        }

        public void Playerone()
        {
            DiceRoller roller = new DiceRoller();
        }
    }
}
