using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baray_Bolat_DiceGame.Scripts
{
    internal abstract class Items
    {
        public Items()
        {

        }

        internal interface IWeapon { }

        internal interface IConsumable { }

        internal interface ITool { }

        internal interface ILoot { }

        public class Dagger : Items, IWeapon
        {

        }

        public class Hatchet : Items, IWeapon
        {

        }

        public class Axe : Items, IWeapon
        {

        }

        public class Baretta : Items, IWeapon
        {

        }

        public class GOLD : Items, ILoot
        {

        }

        public class DonerKebap : Items, ILoot
        {

        }
    }
}
