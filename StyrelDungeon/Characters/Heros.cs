using StyrelDungeon.DungeonElements;
using System;

namespace StyrelDungeon
{
    public class Heros : Character
    {
        private String name;
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private Dungeon m_Dungeon;
        private bool isDead = false;
        public bool IsDead {
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
            this.name = UserInterface.GamesName();
            UserInterface.GamesIntro(this.name);
            m_Dungeon.EnterRoom(this, 0);
        }

        public void SelectProtection() // ?
        {
            // a faire
        }

        public void DiscoverEnnemy(Monster monster) // combat monster vs hero
        {
            //boucle (hero attaque, monstre attaque, test mort hero, test mort monstre...)
            monster.Attack(this);
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
