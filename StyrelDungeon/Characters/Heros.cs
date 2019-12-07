using StyrelDungeon.DungeonElements;
using System;

namespace StyrelDungeon
{
    public class Heros : Character
    {
        private Dungeon m_Dungeon;
        private bool IsDead
        {
            get
            {
                return IsDead;
            }
            set
            {
                IsDead = value;
            }
        }
        //bool m_bFirstAttack = true;

        public Heros(Dungeon p_Dungeon)
        {
            LifePoint = 100;
            m_Dungeon = p_Dungeon;
        }

        public void EnterDungeon()
        {
            m_Dungeon.EnterRoom(this, 0);
        }

        public void SelectProtection()
        {
            // a faire
        }

        public void DiscoverEnnemy(Monster monster)
        {
            // a faire
        }

        public override void Attack(Character p_CharacterToAttack)
        {
            Console.WriteLine("Le Héros attaque " + p_CharacterToAttack.ToString());
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
