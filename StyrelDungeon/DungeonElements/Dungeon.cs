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
        private Room m_Room;

        public Dungeon()
        {
            m_Lair = new DragonsLair();
            m_Room = new Room(0);
        }

        public void EnterRoom(Heros p_Heros, int p_iRoomIndex)
        {
            p_Heros.SelectProtection();
            m_Room.OpenDoor(p_Heros);
        }
    }
}
