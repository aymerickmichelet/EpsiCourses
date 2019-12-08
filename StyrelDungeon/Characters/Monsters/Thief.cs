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
            Name = "Voleur";
            LifePoint = 100;
        }
        public override void Attack(Character p_Heros)
        {
            Console.WriteLine(this.Name + " tire des flèches sur " + p_Heros.Name);
            base.Attack(p_Heros);
        }
        public override int ReceiveDamage(Character p_Heros)
        {
            m_sMessageToPlayer = "The Thief has received your flying knife in the chest. ";
            LifePoint -= 10;
            return base.ReceiveDamage(p_Heros); ;
        }
        public override void ApplyDamagesToEnemy(Character p_Heros)
        {
            Console.WriteLine("The Thief has hit you");
            base.ApplyDamagesToEnemy(p_Heros);
        }
    }
}
