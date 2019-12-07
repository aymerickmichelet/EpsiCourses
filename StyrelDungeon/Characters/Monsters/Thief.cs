using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace StyrelDungeon.Characters.Monsters
{
    public class Thief : Monster
    {
        public Thief()
        {
        }
        public override void Attack(Character p_Heros)
        {
            Console.WriteLine("The Thief is shooting arrows at you ");
            base.Attack(p_Heros);
        }
        public override int ReceiveDamage(Character p_Heros)
        {
            m_sMessageToPlayer = "The Thief has received your flying knife in the chest. ";
            return base.ReceiveDamage(p_Heros); ;
        }
        public override void ApplyDamagesToEnemy(Character p_Heros)
        {
            Console.WriteLine("The Thief has hit you");
            base.ApplyDamagesToEnemy(p_Heros);
        }
    }
}
