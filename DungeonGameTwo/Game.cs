using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGameTwo
{
    enum weaponType { Sword, Bow, Mace, Axe, Crossbow }
    class Game
    {
        private int score = 0;
        private int lives = 3;
        private bool foundKey = false;
        private weaponType weapon;

        public void RoomOne()
        {
            Console.WriteLine("You're at the entrance of a dungeon, obvious exits are NORTH and EAST");

            string input = Console.ReadLine().ToLower();

            if(input == "north")
            {
                Console.WriteLine("You go North");
                Console.ReadKey();
                RoomTwo();
            }
            else if(input == "east")
            {
                Console.WriteLine("You go East");
                Console.ReadKey();
                RoomThree();
            }

        }

        public void RoomTwo()
        {
            Console.WriteLine("Dead end, you can only go SOUTH");
            string input = Console.ReadLine().ToLower();

            if(input == 'south')
            {
                Console.WriteLine("You go South");
                Console.ReadKey();
                RoomOne();
            }
        }

        public void RoomTwo()
        {
            Console.WriteLine("Dead end, you can only go SOUTH");
            string input = Console.ReadLine().ToLower();

            if (input == 'south')
            {
                Console.WriteLine("You go South");
                Console.ReadKey();
                RoomOne();
            }
        }
    }
}
