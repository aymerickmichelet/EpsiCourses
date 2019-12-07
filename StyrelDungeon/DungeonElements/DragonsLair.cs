using StyrelDungeon.Characters;
using StyrelDungeon.Characters.Monsters;

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
            m_RoomMonster.Attack(p_heros);
        }
    }
}