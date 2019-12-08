using StyrelDungeon.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace StyrelDungeon
{
    public class Dungeon
    {
        //A dungeon is composed of rooms and a dragon's Lair
        private List<Room> rooms = new List<Room>();
        public List<Room> Rooms
        {
            get
            {
                return rooms;
            }
            set
            {
                rooms = value;
            }
        }
        public DragonsLair m_Lair;

        public Dungeon()
        {
            for(int i = 0, imax = 5; i < imax; i++)
            {
                this.Rooms.Add(new Room(i));
            }
            m_Lair = new DragonsLair();
        }

        public void EnterRoom(Heros p_Heros, int p_iRoomIndex)
        {
            // p_Heros.SelectProtection();
            p_Heros.IndexRoom = p_iRoomIndex;
            this.Rooms[p_iRoomIndex].OpenDoor(p_Heros);
        }
        public void EnterDragonsLair(Heros p_Heros)
        {
            p_Heros.IndexRoom = 5;
            this.m_Lair.OpenDoor(p_Heros);
        }
    }
}
