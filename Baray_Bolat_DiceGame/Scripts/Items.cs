using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baray_Bolat_DiceGame.Scripts
{
    internal abstract class Items
    {

        public string ItemName { get; set; }

        Random coinFound = new Random();

        Random heal = new Random();

        Random damage = new Random();

        Player inventory = new Player();


        public Items()
        {
            //calls the lists to get acces to inventory
            DiceRoller dice = new DiceRoller();
        }

       



        internal interface IWeapon { }

        internal interface IConsumable { }

        internal interface ITool { }

        internal interface ILoot { }





        public virtual void OnUse()
        {
            Console.WriteLine($"You used {ItemName}.");
        }

        public virtual void OnFound()
        {
            Console.WriteLine("You searched the room...\n");
        }

       // public virtual void Healed()
       // {
            
       // }

       // public virtual void DamageDone()
       // {
            
       // }




        public virtual void ItemDescription()
        {
            
        }

        public class Dagger : Items, IWeapon
        {
              //GameManager Lists = new GameManager();

              //List<string> playerList = 
              

            //will be d6 damage

            public Dagger()
            {
                string dagger = null;
                ItemName = dagger;
            }
        }

        public class Hatchet : Items, IWeapon
        {
            //will be d8 damage

            public Hatchet()
            {
                string hatchet = null;
                ItemName = hatchet;
            }

            public override void OnFound()
            {
               
            }
        }

        public class Axe : Items, IWeapon
        {
            //will be d12 damage


            public Axe()
            {
                string axe = null;
                ItemName = axe;
            }
        }

        public class Baretta : Items, IWeapon
        {
            //will be d20 damage

            public Baretta() 
            {
                string baretta = null;
                ItemName = baretta;
            }
        }

        public class GOLD : Items, ILoot
        {
            //adds random amount of gold to inventory

            public GOLD()
            {
                string gold = null;
                ItemName = gold;
            }

            public override void OnFound()
            {
                Console.WriteLine("You found some GOLD!");
                // will say "+" (random number for item count) GOLD

                coinFound.Next(1, 82);

                Console.WriteLine($"   + {coinFound}");
            }

            public override void OnUse()
            {
                
            }

        }

        public class DonerKebap : Items, ILoot, IConsumable
        {

            //will be d20 heal

            public DonerKebap()
            {
                string doner = null;
                ItemName = doner;
            }

            public override void OnFound()
            {
                Console.WriteLine("You found a juicy and delicious Doner Kebap!");
                // will say "+" (random number for item count) Doner (this random number range will be lower than random gold range.)

                
            }

            public override void OnUse()
            {
                heal.Next(1, 26);

                Console.WriteLine($"You ate the Doner and restored {heal} health.");
            }
        }
    }
}
