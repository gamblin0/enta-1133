using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baray_Bolat_DiceGame.Scripts
{
    internal abstract class Room
    {
        public bool WasVisited { get; set; }
        public int RoomNumber { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

        public Room North { get; set; }
        public Room East { get; set; }
        public Room South { get; set; }
        public Room West { get; set; }

        // Constructor
        public Room(int roomNumber, int row, int column)
        {
            RoomNumber = roomNumber;
            Row = row;
            Column = column;
            WasVisited = false;
        }

        //map visual generator
        public void MapVisual(Room[,] dungeon, Room playerRoom)
        {
            for(int i = 0; i <3;  i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (dungeon[i, j] == playerRoom)
                        Console.Write("[x]");
                    else
                    {
                        Console.Write("[ ]");
                    }
                }
                Console.WriteLine();
            }
        }
       

        // Room methods
        public virtual void RoomDescription()
        {
            if (!WasVisited)
            {
                Console.WriteLine("\nYou don't see anything worth your time in this room.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nYou have been in this room before.");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        public virtual void OnRoomEntered()
        {
            
            Console.WriteLine($"\nYou are entering room {RoomNumber}");

            Console.WriteLine($"\nYou currently have (inventory will be shown here) in your inventory");

            if (WasVisited)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nYou have already been in this room.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            WasVisited = true;

        }

        public virtual void OnRoomSearched(Player player)
        {
            Player playerInventory = new Player();
            Items possibleItems;

            List<Items> loot = new List<Items>();

            Random randomSearch = new Random();
            int searchornot = randomSearch.Next(0, 2);

            //player.AddItems(Items loot);
            Random randomLoot = new Random();
            int foundLoot = randomLoot.Next(0, 6);


            if (searchornot == 0)
            {
                Console.WriteLine("\nYou search the room but couldn't find anything worth your time.");
            }
            if (searchornot == 1)
            {
              switch(foundLoot)
                {
                    //case 0:
                       // playerInventory.AddItems(possibleItems.Hatchet);
                       // break;

                }

                    
                       
                    
            }
                        
            
        }

        public virtual void OnRoomExit()
        {
            Console.WriteLine($"\nYou are leaving room {RoomNumber}");
        }

        // Room subclasses
        public class EmptyRoom : Room
        {
            public EmptyRoom(int roomNumber, int row, int column) : base(roomNumber, row, column)
            {

            }

            public override void RoomDescription()
            {
                Console.WriteLine("\n\nThe room looks empty...");
            }
        }
        public class TreasureRoom : Room
        {
            public TreasureRoom(int roomNumber, int row, int column) : base(roomNumber, row, column)
            {

            }

            public override void RoomDescription()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n\nYou found a treasure room!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public class CombatRoom : Room
        {
            public CombatRoom(int roomNumber, int row, int column) : base(roomNumber, row, column)
            {

            }
            public override void RoomDescription()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nYou encountered an enemy!");
                Console.ForegroundColor = ConsoleColor.White;
                GameManager dicegame = new GameManager();
                dicegame.Playgame();
            }
        }

    }
}
