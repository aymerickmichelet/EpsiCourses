using System;
using StyrelDungeon.Characters;
using StyrelDungeon.Characters.Monsters;
using DungeonStyrel.Utils;

namespace StyrelDungeon
{
    public class DragonsLair : Room
    {
        //private Dragon m_FightingDragon;
        public DragonsLair() : base(0) 
        {
           m_RoomMonster = new Dragon();
        }

        internal override void OpenDoor(Heros p_heros)
        {
            p_heros.DiscoverEnnemy(m_RoomMonster);
            this.FinishCleaningRoom();
        }

        private void FinishCleaningRoom()
        {
            Console.Clear();
            Util.Display("DS");
            Util.Display("Bravo vous avez fini la derniere salle !");
            Util.Display("Vous avez sauvé la princesse ! Félicitation !!!");
            Util.Pause("Appuyez sur entrée pour revenir au menu...");
        }
    }
}