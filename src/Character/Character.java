package Character;

import Weapon.Weapon;

public class Character {

    protected int m_iLifePoints;
    protected Weapon m_Weapon;

    public Character() {

    }

    public void attack(Character p_TargetCharacter){
        return;
    }

    public int getNbLifePoints(){
        return this.m_iLifePoints;
    }

    public void receiveDamages(int p_iDamages){

    }

    public boolean isalive(){
        return getNbLifePoints() > 0;
    }
}