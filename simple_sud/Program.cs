using System;

namespace simple_sud
{
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("SUD, World!");
            // Build the map

            Room room1 = new Room { Description = "Room 1" };
            Room room2 = new Room { Description = "Room 2" };
            Room room3 = new Room { Description = "Room 3" };
            Room room4 = new Room { Description = "Room 4" };
            Room room5 = new Room { Description = "Room 5" };
            Room room6 = new Room { Description = "Room 6" };
            Room room7 = new Room { Description = "Room 7" };

            room1.AddToNorth(room2);
            room1.AddToEast(room4);
            room4.AddToEast(room5);
            room5.AddToNorth(room6);
            room5.AddToSouth(room7);
            room2.AddWest(room3);

            // Add Startroom
            Room currentRoom = room1;

            // Gameloop
            while (true)
            {
                Console.Write("Where do you want to go? (n, s, e, w) : ");
                var keyInfo = Console.ReadKey(true);

                Room tmpRoom = null;
                switch (keyInfo.Key)
                {
                    case ConsoleKey.N:
                        tmpRoom = currentRoom.GoNorth;
                        break;
                    case ConsoleKey.S:
                        tmpRoom = currentRoom.GoSouth;
                        break;
                    case ConsoleKey.E:
                        tmpRoom = currentRoom.GoEast;
                        break;
                    case ConsoleKey.W:
                        tmpRoom = currentRoom.GoWest;
                        break;
                    default:
                        System.Console.Write("I don't understand that, and ");
                        break;
                }

                if (tmpRoom == null)
                {
                    System.Console.WriteLine("you can't go that direction");
                    continue;
                }
                currentRoom = tmpRoom;
                Console.WriteLine($"You are in {currentRoom.Description}");
            }

        }
    }
}
