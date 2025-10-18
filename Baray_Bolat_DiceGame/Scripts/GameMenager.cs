using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Baray_Bolat_DiceGame.Scripts
{




    internal class GameManager
    {
        Player user = new Player();//called player to get user

        Player cpu = new Player();//called player to get cpu

        bool playerTurn;//is it player turn? yes or no

        int playerOutcome;//player roll

        int cpuOutcome;//cpu roll

        bool playingGame;//is the game still going? yes or no


        //var playerInventory = new Dictionary<int, string>()
        // {

        // }



        List<int> playerDice = new List<int>//dice list of player
        {
            6, 8, 12, 20
        };
        public List<int> PlayerDice => new List<int>(playerDice);



        List<int> cpuDice = new List<int>//dice list of cpu
        {
            0, 1, 2, 3
        };
        public List<int> CpuDice => new List<int>(cpuDice);






        public void GameChecker()//checks the lists to see if the game should continue
        {

           // DiceRoller Lists = new DiceRoller();

            //List<string> playerList =Lists.PlayerDice;

            

            if(playerDice.Count == 0 && cpuDice.Count == 0)//if there is not any dice left in both of the lists
            {
               
                playingGame = false;//ends the game
                GameWinner();//game winner message
                GoodbyeMessage();//goodbye message
                Again();
                //Start();
            }
            else
            {
                playingGame = true; //game continues
            }

           

        }


        public void GoodbyeMessage()//goodbye message for when the game ends
        {
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Thank you for playing!");

        }



        public int CoinFlip()//coin flip to decide the turn order
        {
            Random turnOrder = new Random();//randomizer

            int coinFlip = turnOrder.Next(2);//random outcome out of 1 or 0

            playerTurn = coinFlip > 0;//if the random outcome is 1 then it is player's turn

            Console.WriteLine("Flipping a coin to decide who goes first...");

            return coinFlip;//returning so I can use it later
        }




        //created a function to play the game
        public void Playgame()
        {



            Player user = new Player();//introduce user to make a new player
            Player cpu = new Player();//introduce cpu  to make a new player
            Random r = new Random();//introduce r random  to make a new random
            DiceRoller roller = new DiceRoller();//introduce roller to make a new DiceRoller
           

           // user.Askname();//calls Askname and asks name for player
            cpu.SetName();//calls SetName andsets name for cpu

            Console.WriteLine("###############################################################################################");
            Console.WriteLine("                                      COMBAT STARTS                                            ");
            Console.WriteLine("###############################################################################################");
            Rules();//calls rules function
            

            Ready();//calls Ready function

            CoinFlip();//calls CoinFlip function


            GameChecker();//calls GameChecker function



            do
            {
                
                TurnLoop();//calls The turn loop
                
                

            } while (playingGame);//plays the turn while playingGame is true

           

        }
        public void Again()//asking if the player wants to play again
        {
            Console.WriteLine("Do you want to play again?");
            string continueInputAgain = Console.ReadLine();

            if (continueInputAgain == "y")//if they say yes (y) then the game restarts
            {
                Console.WriteLine("Let's roll!!");
                Playgame();

            }
            else if (continueInputAgain == "n")//if they say no (n) then I print a small goodbye message and ends the game
            {
                Console.WriteLine("Well, see you another time!");
                playingGame = false;

            }

        }

        

        public void Ready()//asks the player if they are ready
        {
            Console.WriteLine("Are you ready?");
            Console.WriteLine("Type 'y' for yes and 'n' for no");
            string continueInput = Console.ReadLine();//gets input

            if (continueInput == "y")//if they are ready we print this
            {
                Console.WriteLine("Let's roll!!");
                
            }
            else if (continueInput == "n")//even if they are not ready the game starts
            {
                Console.WriteLine("Well, you better be because the game is starting!");
                
            }
        }

        public void ContinuePlaying()//asking if they want to keep playing or leave the game
        {
           

            Console.WriteLine("Do you want to keep playing?");
            Console.WriteLine("Type 'y' for yes and 'n' for no");
            string continueInput = Console.ReadLine();

            if (continueInput == "y")//if they want to play, the game continues
            {
                
                TurnLoop();
            }
            else if (continueInput == "n")//if they dont want to play the game ends
            {
                Console.WriteLine("Thanks for playing!");
                playingGame = false;    
            }
            else//if they didnt write a correct input, we ask again
            {
                Console.WriteLine("Please type y/n");
                ContinuePlaying();  
            }
        }

        public void Rules()
        {
            Console.WriteLine("###############################################################################################");
            Console.WriteLine("                                          RULES                                                ");
            Console.WriteLine("###############################################################################################");
            Console.WriteLine("");
            Console.WriteLine("You have 4 dice; 6, 8, 12 and 20.");
            Console.WriteLine("");
            Console.WriteLine("You can only roll each dice once and after you roll the die gets removed from your inventory.");
            Console.WriteLine("");
            Console.WriteLine("Both players roll dice once every turn,");
            Console.WriteLine("");
            Console.WriteLine("Higher roll for that round gets a point.");
            Console.WriteLine("");
            Console.WriteLine("Game continues until there is no dice left in any inventory.");
            Console.WriteLine("");
            Console.WriteLine("The player who has more points at the end of the game wins the game");
            Console.WriteLine("");
            Console.WriteLine("GOOD LUCK!");
            Console.WriteLine("");
            Console.WriteLine("###############################################################################################");
        }//explains he rules

        public void CpuTurn()
        {
            //I will use switch case for this


            DiceRoller dice = new DiceRoller();

            
            
            Random random = new Random();

            Random randomPick = new Random();

            int picker = randomPick.Next(1, 5);//picks random dice from 1 to 4



            if (picker == 1)
            {
                if (cpuDice.Contains(0))//checks if the dice is still in the list
                {
                    cpuOutcome = dice.Roller(6);//if the dice is available it rolls
                    cpuDice.Remove(0);//removes rolled dice

                    Console.WriteLine("");
                    Console.WriteLine("Kelk the Horrible is rolling a d6");
                    Console.WriteLine("Kelk the Horrible rolled " + cpuOutcome + " !");//prints roll
                    Console.WriteLine("");
                }
                else
                {
                    CpuTurn();//if the die is already used, asks for a new die
                }

                    
            }

            if (picker == 2)
            {
                if (cpuDice.Contains(1))//checks if the dice is still in the list
                {
                    cpuOutcome = dice.Roller(8);//if the dice is available it rolls
                    cpuDice.Remove(1);//removes rolled dice

                    Console.WriteLine("");
                    Console.WriteLine("Kelk the Horrible is rolling a d8");
                    Console.WriteLine("Kelk the Horrible rolled " + cpuOutcome + " !");//prints roll
                    Console.WriteLine("");
                }
                else
                {
                    CpuTurn();//if the die is already used, asks for a new die
                }
            }

            if (picker == 3)
            {
                if (cpuDice.Contains(2))//checks if the dice is still in the list
                {
                    cpuOutcome = dice.Roller(12);//if the dice is available it rolls
                    cpuDice.Remove(2);//removes rolled dice

                    Console.WriteLine("");
                    Console.WriteLine("Kelk the Horrible is rolling a d12");
                    Console.WriteLine("Kelk the Horrible " + cpuOutcome + " !");//prints roll
                    Console.WriteLine("");
                }
                else
                {
                    CpuTurn();//if the die is already used, asks for a new die
                }
            }

            if (picker == 4)
            {
                if (cpuDice.Contains(3))//checks if the dice is still in the list
                {
                    cpuOutcome = dice.Roller(20);//if the dice is available it rolls
                    cpuDice.Remove(3);//removes rolled dice

                    Console.WriteLine("");
                    Console.WriteLine("Kelk the Horrible is rolling a d20");
                    Console.WriteLine("Kelk the Horrible rolled " + cpuOutcome + " !");//prints roll
                    Console.WriteLine("");
                }
                else
                {
                    CpuTurn();//if the die is already used, asks for a new die
                }
            }


        }//the whole loopable cpu turn

       

        public void PlayerTurn()
        {

            DiceRoller dice = new DiceRoller();


           
               
                //here, is when it is player's turn first. Player is asked to roll and then the cpu rolls. There is most probably a better way to do it with functions but I couldn't make it work when I tried. Might need help with that.
                Console.WriteLine("Which die do you want to roll? (write 6, 8, 12 or 20 to pick the dice.)");
            Console.WriteLine("Dice left: " + string.Join(", ", playerDice));

            if (int.TryParse(Console.ReadLine(), out int number))
                {


                    if (number == 6)
                    {
                    if (playerDice.Contains(6))//checks if the dice is still in the list
                    {
                        playerOutcome = dice.Roller(6); //if the dice is available it rolls
                        playerDice.Remove(6);//removes rolled dice

                        Console.WriteLine("");
                        Console.WriteLine("You rolled " + playerOutcome + " !");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Please pick a different die");
                        PlayerTurn();//if the die is already used, asks for a new die
                    }

                    }

                    if (number == 8)
                    {

                    if (playerDice.Contains(8))//checks if the dice is still in the list
                    {
                        playerOutcome = dice.Roller(8); //if the dice is available it rolls
                        playerDice.Remove(8);//removes rolled dice

                        Console.WriteLine("");
                        Console.WriteLine("You rolled " + playerOutcome + " !");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Please pick a different die");
                        PlayerTurn();//if the die is already used, asks for a new die
                    }
                }

                    if (number == 12)
                {
                    if (playerDice.Contains(12))//checks if the dice is still in the list
                    {
                        playerOutcome = dice.Roller(12);//if the dice is available it rolls
                        playerDice.Remove(12);//removes rolled dice

                        Console.WriteLine("");
                        Console.WriteLine("You rolled " + playerOutcome + " !");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Please pick a different die");
                        PlayerTurn();//if the die is already used, asks for a new die
                    }
                }

                    if (number == 20)
                    {

                    if (playerDice.Contains(20))//checks if the dice is still in the list
                    {
                        playerOutcome = dice.Roller(20);//if the dice is available it rolls
                        playerDice.Remove(20);//removes rolled dice

                        Console.WriteLine("");
                        Console.WriteLine("You rolled " + playerOutcome + " !");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Please pick a different die");
                        PlayerTurn();//if the die is already used, asks for a new die
                    }
                }



                }
                else
                {
                    Console.WriteLine("Please enter 6, 8, 12 or 20.");
                    PlayerTurn();   //if the they enter anything else than wanted input, it asks them to put a valid input
            }
            
        }//the whole loopable player turn
        public void TurnLoop()
        {

            DiceRoller rolling = new DiceRoller();
            //rolling.Roller();


            int playerOutcome = 0;

            int cpuOutcome = 0;



            if (playerTurn)//player turn
            {
                Console.WriteLine("It's your turn!");
                PlayerTurn();
                CpuTurn();
            }
            else//cpu turn
            {
                Console.WriteLine("It's Kelk the Horrible's turn!");
                CpuTurn();
                PlayerTurn();
            }



            ScoreCheck();//calls score checker

            if (playingGame = true)
            {
               // ContinuePlaying();//if there is still dice the game continues
               TurnLoop();
            }
            else
            {
                Again();//if the game is over, it asks if you want to play again
                //Start();
            }
        }

        public void GameWinner()//shows the winner
        {
            if (user.Score > cpu.Score)
            {
                Player player = new Player();

                Console.WriteLine("###############################################################################################");
                Console.WriteLine("THE WINNER IS");
                Console.WriteLine(user.FetchPlayerName());//player name
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("Here are the final scores:");
                Console.WriteLine(user.FetchPlayerName() + ": " + user.Score);//player name and score
                Console.WriteLine("CPU: " + cpu.Score);
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("###############################################################################################");
            }
            else if (user.Score < cpu.Score)
            {
                Console.WriteLine("###############################################################################################");
                Console.WriteLine("THE WINNER IS");
                Console.WriteLine("THE CPU");
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("Here are the final scores:");
                Console.WriteLine("CPU: " + cpu.Score);
                Console.WriteLine(user.FetchPlayerName() + ": " + user.Score);
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("###############################################################################################");
            }
            else
            {
                Console.WriteLine("###############################################################################################");
                Console.WriteLine("THE GAME TIED!!!");
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("Here are the final scores:");
                Console.WriteLine("CPU: " + cpu.Score);
                Console.WriteLine(user.FetchPlayerName() + ": " + user.Score);
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("###############################################################################################");
            }
        }
        
        internal void ScoreCheck()//checks the score
        {

            if (playerOutcome > cpuOutcome)//if player rolled higher
            {
                user.Score++; // if player's role is bigger than cpu's role, player gets a point

            }
            else if (playerOutcome < cpuOutcome)//if cpu rolled higher
            {
                cpu.Score++; // if cpu's role is bigger than player's role, player gets a point
            }
            else
            {
                Console.WriteLine("It's a TIE!!!");
                Console.WriteLine("No points awarded this round.");
            }
            Console.WriteLine("");

            Console.WriteLine("Your score: " + user.Score + " !");
            Console.WriteLine("Opponent's score: " + cpu.Score + " !");
            Console.WriteLine("------------------------------------------------------------------------------------------------");

            GameChecker();//checks if the game is still on

        }

        public void ClearScreen()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.Clear();
        }

        public void Start()
        {
             
            Console.WriteLine("You find yourself in a room...");
            Room[,] dungeon = new Room[3, 3]; //generates the rooms
            int roomNumber = 0; //sets the starting room
            Random random = new Random();



            // generating a random dungeon
            for (int x = 0; x < dungeon.GetLength(0); x++)
            {
                for (int y = 0; y < dungeon.GetLength(1); y++)
                {
                    int roomType = random.Next(0, 3);
                    switch (roomType)
                    {
                        case 0:
                            dungeon[x, y] = new Room.EmptyRoom(roomNumber, x, y);
                            break;
                        case 1:
                            dungeon[x, y] = new Room.TreasureRoom(roomNumber, x, y);
                            break;
                        case 2:
                            dungeon[x, y] = new Room.CombatRoom(roomNumber, x, y);
                            break;
                        default:
                            dungeon[x, y] = new Room.EmptyRoom(roomNumber, x, y);
                            break;
                    }
                    roomNumber++;
                }
            }

            //linking rooms
            for (int x = 0; x < dungeon.GetLength(0); x++)
            {
                for (int y = 0; y < dungeon.GetLength(1); y++)
                {

                    Room currentRoom = dungeon[x, y];
                    if (x > 0)
                        currentRoom.North = dungeon[x - 1, y];
                    if (x < dungeon.GetLength(0) - 1)
                        currentRoom.South = dungeon[x + 1, y];
                    if (y > 0)
                        currentRoom.West = dungeon[x, y - 1];
                    if (y < dungeon.GetLength(1) - 1)
                        currentRoom.East = dungeon[x, y + 1];

                }
            }

            //starting the game in first room
            Room current = dungeon[0, 0];

            current.OnRoomEntered(); //message for when you first enter
            current.MapVisual(dungeon, current); //generating visual for current room
            current.RoomDescription(); //description current room

            bool isPlaying = true;
            while (isPlaying)
            {
                Console.WriteLine("\nWhat would you like to do? ");
                Console.WriteLine("You can: ");
                Console.WriteLine("- To search the room, type 'search' ");
                Console.WriteLine("- To move rooms, type 'north, south, east or west' ");
                string input = Console.ReadLine().ToLower(); //makes every input lowercase
                switch (input)
                {
                    case "north":
                        if (current.North != null) //if the north isn't empty
                        {
                            current.OnRoomExit(); //exits the room before
                            current = current.North; //sets the current room as the new room
                            current.OnRoomEntered();
                            current.MapVisual(dungeon, current);
                            current.RoomDescription();
                        }
                        else
                        {
                            Console.WriteLine("You can't go that way.");
                        }
                        break;
                    case "south":
                        if (current.South != null)
                        {
                            current.OnRoomExit(); //exits the room before
                            current = current.South; //sets the current room as the new room
                            current.OnRoomEntered();
                            current.MapVisual(dungeon, current);
                            current.RoomDescription();
                        }
                        else
                        {
                            Console.WriteLine("You can't go that way.");
                        }
                        break;

                    case "east":
                        if (current.East != null)
                        {
                            current.OnRoomExit(); //exits the room before
                            current = current.East; //sets the current room as the new room
                            current.OnRoomEntered();
                            current.MapVisual(dungeon, current);
                            current.RoomDescription();
                        }
                        else
                        {
                            Console.WriteLine("You can't go that way.");
                        }
                        break;

                    case "west":
                        if (current.West != null)
                        {
                            current.OnRoomExit(); //exits the room before
                            current = current.West; //sets the current room as the new room
                            current.OnRoomEntered();
                            current.MapVisual(dungeon, current);
                            current.RoomDescription();
                        }
                        else
                        {
                            Console.WriteLine("You can't go that way.");
                        }
                        break;

                    case "search":
                        current.OnRoomSearched();
                        break;
                    default:
                        Console.WriteLine("Please write 'north, south, east, west'. ");
                        break;

                        

                }
               // ClearScreen();

            }





        }
    }
}


        
           
        
        
       
    


