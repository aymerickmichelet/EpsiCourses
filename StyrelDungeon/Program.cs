using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using StyrelDungeon.Characters.Monsters;

namespace StyrelDungeon
{
    class Program
    {
        public const int STARTING_WEAPON_NUMBER = 10;
        public const int NUMBER_ROOM_DUNGEON = 5;

        static void Main(string[] args)
        {
            //We instanciate a Dungeon and a Hero who will clean the Dungeon
            //Dungeon Dungeon = new Dungeon();
            //Heros heros = new Heros(Dungeon);
            //Console.WriteLine("Welcome to Styrel Dungeon");
            //heros.EnterDungeon();
            //Console.WriteLine("Thank you for playing");
            //Console.ReadLine();

            if(UserInterface.MainMenu() == 1)
            {
                Dungeon dungeon = new Dungeon();
                Heros hero = new Heros(dungeon);
                hero.EnterDungeon();
                dungeon.EnterRoom(hero, 2);
            }
        }
    }
}
