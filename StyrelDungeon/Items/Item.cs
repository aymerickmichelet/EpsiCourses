using StyrelDungeon.Characters;
using StyrelDungeon.DungeonElements.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace StyrelDungeon
{
    #region Declaration des Enum
    public enum ITEM_TYPE
    {
        DAGGER_SET,
        WATER_FLASK_SET,
        ICE_ARROW_SET,
        SHIELD_RESTORE,
        MAGIC_HOOD_RESTORE,
        PENDANT_RESTORE,
        HEALTH_POTION,
        SWORD_IMPROVE_DAMAGE,
        DAGGER_IMPROVE_DAMAGE,
        WATER_FLASK_IMPROVE_DAMAGE,
        ICE_ARROW_IMPROVE_DAMAGE
    }

    public enum ITEM_CLASS
    {
        SET,
        RESTORE,
        POTION,
        DAMAGE
    }
    #endregion

    public class Item
    {
        #region Public

        public void ApplyEffect(Heros hero)
        {

        }

        #endregion
        #region Ici sont regroupé les methodes privees
        private void ImproveWeaponDamage(Heros hero) { }
        private void HealHero(Heros hero) { }
        private void RestoreProtection(Heros hero) { }
        private void AddWeaponToInventory(Heros hero) { }
        #endregion
    }
}
