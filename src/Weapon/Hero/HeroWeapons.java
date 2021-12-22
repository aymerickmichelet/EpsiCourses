package Weapon.Hero;

import Character.Character;
import Weapon.Weapon;
import Interface.Searchable;
import Items.Item;

public class HeroWeapons extends Weapon implements Searchable {

    private int m_iAttackBonus;

    public HeroWeapons(){

    }

    public void inflictDamage(Character o_TargetCharacter){

    }

    public void setAttackBonus(int p_iBonus){

    }

    @Override
    public Item search() {
        return null;
    }
}