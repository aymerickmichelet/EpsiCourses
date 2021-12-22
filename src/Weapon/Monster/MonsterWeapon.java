package Weapon.Monster;

import Character.Character;
import Weapon.Weapon;
import Interface.Searchable;
import Items.Item;

class MonsterWeapons extends Weapon implements Searchable {

    private int m_iCriticalCountDown;
    private static int s_iMaxRoundBeforeCritical; // READONLY

    public MonsterWeapons(){

    }

    public void inflictDamage(Character o_TargetCharacter){

    }

    @Override
    public Item search() {
        return null;
    }
}