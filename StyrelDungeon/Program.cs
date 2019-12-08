using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using StyrelDungeon.Characters.Monsters;
using DungeonStyrel.Utils;

namespace StyrelDungeon
{
    class Program
    {
        public const int STARTING_WEAPON_NUMBER = 10;
        public const int NUMBER_ROOM_DUNGEON = 5;

        static void Main(string[] args)
        {
            do
            {
                if(UserInterface.MainMenu() == 1)
                {
                    Dungeon dungeon = new Dungeon();
                    Heros hero = new Heros(dungeon);
                    hero.EnterDungeon();
                    for(int i = 1, imax = 5; i < imax; i++)
                    {
                        if(hero.IsDead == false)
                        {
                            dungeon.EnterRoom(hero, i);
                        }
                    }
                    if (hero.IsDead == false)
                    {
                        dungeon.EnterDragonsLair(hero);
                    }

                }
                else
                {
                    return;
                }
            } while (true);
        }
    }
}
