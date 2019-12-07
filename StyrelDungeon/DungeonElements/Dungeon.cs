using StyrelDungeon.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace StyrelDungeon
{
    public class Dungeon
    {
        //A dungeon is composed of rooms and a dragon's Lair
        private DragonsLair m_Lair;
        private List<Room> rooms;

        public Dungeon()
        {
            m_Lair = new DragonsLair();
            for(int i = 0, imax = 5; i < imax; i++)
            {
                rooms.Add(new Room(i));
            }
        }

        public void EnterRoom(Heros p_Heros, int p_iRoomIndex)
        {
            // p_Heros.SelectProtection();
            this.rooms[p_iRoomIndex].OpenDoor(p_Heros);
        }
    }
}
