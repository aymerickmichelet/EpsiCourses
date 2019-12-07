using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace StyrelDungeon
{
    class Program
    {
        public const int STARTING_WEAPON_NUMBER = 10;
        public const int NUMBER_ROOM_DUNGEON = 5;

        static void Main(string[] args)
        {
            //We instanciate a Dungeon and a Hero who will clean the Dungeon
            Dungeon DungeonToClear = new Dungeon();
            Heros DungeonCleaner = new Heros(DungeonToClear);
            Console.WriteLine("Welcome to Styrel Dungeon");

            DungeonCleaner.EnterDungeon();
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();
        }
    }
}
