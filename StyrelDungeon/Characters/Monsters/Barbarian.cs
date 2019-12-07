using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace StyrelDungeon.Characters.Monsters
{
    public class Barbarian : Monster
    {
        public Barbarian()
        {
        }

        public override void Attack(Character p_Heros)
        {
            m_sMessageToPlayer = "The Barbarian is launching a close combat attack ";
            base.Attack(p_Heros);
        }
        public override int ReceiveDamage(Character p_Heros)
        {
            m_sMessageToPlayer = "The Barbarian has taken a blow of your sword. ";
            LifePoint -= 10; // réduire point de vie barbarian
            return base.ReceiveDamage(p_Heros);
        }
        public override void ApplyDamagesToEnemy(Character p_Heros)
        {
            Console.WriteLine("The Barbarian has hit you");
            base.ApplyDamagesToEnemy(p_Heros);
        }

    }
}
