using StyrelDungeon;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StyrelDungeon.Characters
{
    public class Dragon : Monster
    {
        private bool m_bWeaponChange = true;
        public Dragon()
        {
            Name = "Dragon";
            LifePoint = 200;
        }

        public override void Attack(Character p_Heros)
        {
            this.ChangeAttack(p_Heros);
        }
        private void ChangeAttack(Character p_Heros)
        {
            base.Attack(p_Heros);
            ApplyDamagesToEnemy(p_Heros);
        }
        public override int ReceiveDamage(Character p_Heros)
        {
            m_sMessageToPlayer = "The Ice Arrow has pierced through the skin of the dragon\n";
            LifePoint -= 10;
            return base.ReceiveDamage(p_Heros);
        }
        public override void ApplyDamagesToEnemy(Character p_Heros)
        {
            base.ApplyDamagesToEnemy(p_Heros);
        }

      
    }
}
