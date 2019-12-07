﻿using StyrelDungeon.DungeonElements.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace StyrelDungeon
{ 
    abstract public class Character
    {
        protected int m_iLifePoint
        {
            get
            {
                return m_iLifePoint;
            }
            set
            {
                m_iLifePoint = value;
            }
        }

        public abstract void Attack(Character p_CharacterToAttack);
        public abstract void ApplyDamagesToEnemy(Character p_CharacterToApplyDamage);
        public abstract int ReceiveDamage(Character p_CharacterApplyingDamage);
    }
}
