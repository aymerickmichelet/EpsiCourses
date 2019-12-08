using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace StyrelDungeon.Characters.Monsters
{
    public class Sorcerer : Monster
    {
        public Sorcerer()
        {
            Name = "Sorciere";
            LifePoint = 100;
        }
        public override void Attack(Character p_Heros)
        {
            Console.WriteLine(this.Name + " invoque un éclair");
            base.Attack(p_Heros);
        }
        public override int ReceiveDamage(Character p_Heros)
        {
            m_sMessageToPlayer = "The Sorcerer has been drenched by the water. ";
            LifePoint -= 10;
            return base.ReceiveDamage(p_Heros); ;
        }
        public override void ApplyDamagesToEnemy(Character p_Heros)
        {
            Console.WriteLine("The Sorcerer has hit you");
            base.ApplyDamagesToEnemy(p_Heros);
        }

    }
}
