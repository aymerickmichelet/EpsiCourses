using StyrelDungeon.Characters;
using StyrelDungeon.Characters.Monsters;
using StyrelDungeon.DungeonElements;
using System;
using System.Collections.Generic;
using System.Text;
using DungeonStyrel.Utils;

namespace StyrelDungeon
{
    public class Room
    {
        //A room contains a monster and a chest
        public Monster m_RoomMonster;
        private Chest m_Chest;
        private int m_iRoomNumber;

        public Room(int index)
        {
            m_iRoomNumber = index;
            switch (index)
            {
                case 0:
                    m_RoomMonster = new Barbarian();
                    m_Chest = new Chest();
                    break;
                case 1:
                    m_RoomMonster = new Barbarian();
                    m_Chest = new Chest();
                    break;
                case 2:
                    m_RoomMonster = new Thief();
                    m_Chest = new Chest();
                    break;
                case 3:
                    m_RoomMonster = new Sorcerer();
                    m_Chest = new Chest();
                    break;
                case 4:
                    m_RoomMonster = new Sorcerer();
                    m_Chest = new Chest();
                    break;
            }
        }



        virtual internal void OpenDoor(Heros p_heros) //If heros has won the battle he can clean the room before opening next door
        {
            p_heros.DiscoverEnnemy(m_RoomMonster); // lance combat
            // chest
            FinishCleaningRoom(p_heros);
        }

        private void FinishCleaningRoom(Heros p_heros)
        {
            Console.Clear();
            Util.Display("DS");
            Util.Display("Bravo vous avez fini la salle n°" + (p_heros.IndexRoom + 1).ToString());
            Util.Display("Vous entrez à présent dans la prochaine salle.");
            Util.Pause();
        }
    }
}
