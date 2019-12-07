using System;
using System.Collections.Generic;
using System.Text;

namespace StyrelDungeon.DungeonElements.Items
{
    public enum WEAPON_TYPE
    {
        LIGHTNING,
        WATER_FLASK,
        ARROW,
        DAGGER,
        SWORD,
        FLAME,
        CLAW,
        SPIKE,
        ICE_ARROW
    }

    public class Weapon
    {
        public WEAPON_TYPE m_WeaponType;
        public PROTECTION_TYPE m_EffectiveProtection;
        public int m_iWeaponDamage;

        public Weapon(WEAPON_TYPE p_WT)
        {
            m_WeaponType = p_WT;
            Random random = new Random();
            switch (m_WeaponType)
            {
                case WEAPON_TYPE.LIGHTNING:
                    m_iWeaponDamage = random.Next(30, 40);
                    m_EffectiveProtection = PROTECTION_TYPE.PENDANT;
                    break;
                case WEAPON_TYPE.WATER_FLASK:
                    m_iWeaponDamage = random.Next(10, 20);
                    break;
                case WEAPON_TYPE.ARROW:
                    m_iWeaponDamage = random.Next(20, 30);
                    m_EffectiveProtection = PROTECTION_TYPE.MAGIC_HOOD;
                    break;
                case WEAPON_TYPE.DAGGER:
                    m_iWeaponDamage = random.Next(10, 20);
                    break;
                case WEAPON_TYPE.SWORD:
                    m_iWeaponDamage = random.Next(10, 20);
                    m_EffectiveProtection = PROTECTION_TYPE.SHIELD;
                    break;
                case WEAPON_TYPE.FLAME:
                    m_iWeaponDamage = random.Next(30, 40);
                    m_EffectiveProtection = PROTECTION_TYPE.PENDANT;
                    break;
                case WEAPON_TYPE.CLAW:
                    m_iWeaponDamage = random.Next(30, 40);
                    m_EffectiveProtection = PROTECTION_TYPE.SHIELD;
                    break;
                case WEAPON_TYPE.SPIKE:
                    m_iWeaponDamage = random.Next(30, 40);
                    m_EffectiveProtection = PROTECTION_TYPE.MAGIC_HOOD;
                    break;
                case WEAPON_TYPE.ICE_ARROW:
                    m_iWeaponDamage = random.Next(10, 20);
                    break;
                default:
                    break;
            }
        }
    }
}
