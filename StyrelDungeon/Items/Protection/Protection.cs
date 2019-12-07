using System;
using System.Collections.Generic;
using System.Text;

namespace StyrelDungeon.DungeonElements.Items
{
    public enum PROTECTION_TYPE
    {
        PENDANT,
        MAGIC_HOOD,
        SHIELD
    }
    public class Protection
    {
        public PROTECTION_TYPE m_ProtectionType;
        public int m_iAbsorbingDamage;

        public Protection(PROTECTION_TYPE p_PT)
        {
            m_ProtectionType = p_PT;
            Random random = new Random();
            switch (m_ProtectionType)
            {
                case PROTECTION_TYPE.PENDANT:
                    m_iAbsorbingDamage = random.Next(40, 60);
                    break;
                case PROTECTION_TYPE.MAGIC_HOOD:
                    m_iAbsorbingDamage = random.Next(60, 80);
                    break;
                case PROTECTION_TYPE.SHIELD:
                    m_iAbsorbingDamage = random.Next(20, 40);
                    break;
                default:
                    break;
            }
        }
    }
}