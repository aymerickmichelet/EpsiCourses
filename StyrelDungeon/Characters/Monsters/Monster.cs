using StyrelDungeon.DungeonElements.Items;
using System;
using System.Collections.Generic;
using System.Timers;

namespace StyrelDungeon
{
    public enum MONSTER_TYPE
    {
        SORCERER,
        THIEF,
        BARBARIAN
    }

    public abstract class Monster : Character
    {
        protected string m_sMessageToPlayer;

        public override void Attack(Character heros)
        {
            Console.WriteLine(m_sMessageToPlayer);
            heros.ReceiveDamage(this); // pour enlever point de vie a heros
        }
        public override int ReceiveDamage(Character character) { return 0; }
        public override void ApplyDamagesToEnemy(Character heros) { }
    }
}
