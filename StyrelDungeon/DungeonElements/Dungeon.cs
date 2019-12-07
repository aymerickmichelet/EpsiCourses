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
        private DragonsLair m_Lair;

        public Dungeon()
        {
            for(int i = 0, imax = 5; i < imax; i++)
            {
                this.rooms.Add(new Room(i));
            }
            Console.WriteLine("Rooms: " + this.Rooms.ToString());
            Console.WriteLine("Rooms[0]: " + this.Rooms[0].ToString());
            Console.WriteLine("Rooms[1]: " + this.Rooms[1].ToString());
            Console.WriteLine("Rooms[2]: " + this.Rooms[2].ToString());
            Console.WriteLine("Rooms[3]: " + this.Rooms[3].ToString());
            Console.WriteLine("Rooms[4]: " + this.Rooms[4].ToString());
            m_Lair = new DragonsLair();
        }

        public void EnterRoom(Heros p_Heros, int p_iRoomIndex)
        {
            // p_Heros.SelectProtection();
            this.rooms[p_iRoomIndex].OpenDoor(p_Heros);
        }
    }
}
