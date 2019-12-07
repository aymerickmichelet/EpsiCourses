using StyrelDungeon.Characters;
using StyrelDungeon.Characters.Monsters;
using StyrelDungeon.DungeonElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace StyrelDungeon
{
    public class Room
    {
        //A room contains a monster and a chest
        protected Monster m_RoomMonster;
        private Chest m_Chest;
        private int m_iRoomNumber;

        public Room(int index)
        {
            m_RoomMonster = new Barbarian();
            m_Chest = new Chest();
            m_iRoomNumber = index;
        }

        virtual internal void OpenDoor(Heros p_heros)
        {
            p_heros.DiscoverEnnemy(m_RoomMonster);
            m_RoomMonster.Attack(p_heros);
            //If heros has won the battle he can clean the room before opening next door
            FinishCleaningRoom(p_heros);
        }

        private void FinishCleaningRoom(Heros p_heros)
        {

        }
    }
}
