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

        // Room methods
        public virtual void RoomDescription()
        {
            if (!WasVisited)
            {
                Console.WriteLine("You don't see anything worth your time in this room.");
            }
            else
            {
                Console.WriteLine("You have been in this room before.");
            }

        }

        public virtual void OnRoomEntered()
        {
            WasVisited = true;
            Console.WriteLine($"You are entering room {RoomNumber}");
        }

        public virtual void OnRoomSearched()
        {
            Console.WriteLine("You search the room but couldn't find anything worth your time.");
        }

        public virtual void OnRoomExit()
        {
            Console.WriteLine($"You are leaving room {RoomNumber}");
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
                Console.WriteLine("You found a treasure room!");
            }
        }

        public class CombatRoom : Room
        {
            public CombatRoom(int roomNumber, int row, int column) : base(roomNumber, row, column)
            {

            }
            public override void RoomDescription()
            {
                Console.WriteLine("You encountered an enemy!");
                GameMenager dicegame = new GameMenager();
                dicegame.Playgame();
            }
        }

    }
}
