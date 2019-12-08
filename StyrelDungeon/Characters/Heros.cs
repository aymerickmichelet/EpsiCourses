using StyrelDungeon.DungeonElements;
using System;
using DungeonStyrel.Utils;

namespace StyrelDungeon
{
    public class Heros : Character
    {
        private Dungeon m_Dungeon;
        private bool isDead = false;
        public bool IsDead {
            get
            {
                return isDead;
            }
            set
            {
                IsDead = value;
            }
        }
        private int index_room = 0;
        public int IndexRoom
        {
            get
            {
                return index_room;
            }
            set
            {
                index_room = value;
            }
        }

        public Heros(Dungeon p_Dungeon)
        {
            LifePoint = 100;
            m_Dungeon = p_Dungeon;
        }

        public void EnterDungeon()
        {
            this.name = UserInterface.GamesName();
            UserInterface.GamesIntro(this.name);
            m_Dungeon.EnterRoom(this, 0);
        }

        public void DiscoverEnnemy(Monster monster) // combat monster vs hero
        {
            UserInterface.Fight(this, monster);
        }

        public override void Attack(Character p_CharacterToAttack)
        {
            Util.Display(this.Name + " attaque " + p_CharacterToAttack.Name);
            this.ApplyDamagesToEnemy(p_CharacterToAttack);
        }

        public override void ApplyDamagesToEnemy(Character p_CharacterToApplyDamage)
        {
            p_CharacterToApplyDamage.ReceiveDamage(this);
        }

        public override int ReceiveDamage(Character p_CharacterApplyingDamage)
        {
            LifePoint -= 10;
            return 0;
        }

        public void SelectItemsFromChest(Chest RoomChest) 
        {
            // a faire
        }

        private void Dies(string p_sCause)
        {
            Console.WriteLine("Sorry you are dead because " + p_sCause);
        }
    }
}
