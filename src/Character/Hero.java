package Character;

import java.util.ArrayList;
import Character.Monster.Monster;
import Weapon.Hero.HeroWeapons;
import Interface.Searchable;

public class Hero extends Character {

    private int m_iStrength;
    private ArrayList<HeroWeapons> m_Arsenal; // *

    public Hero(){

    }

    private void selectWeaponFromArsenal(String p_sWeaponClassName){

    }

    @Override
    public void attack(Character p_TargetCharacter) {
        super.attack(p_TargetCharacter);
    }

    public void discoverEnnemy(Monster p_Monster){

    }

    public void setStrength(int p_iStrength){

    }

    public void improveHealth(int p_iValue){

    }

    public void improveStrength(int p_iValue){

    }

    public void searchForPotions(Searchable p_Seacchable){

    }
}