package Weapon;

import Character.Character;

public class Weapon {

    protected int m_iAttackPoints;

    public Weapon() {
        m_iAttackPoints = 10;
    }

    public void inflictDamage(Character p_TargetCharacter) {
        p_TargetCharacter.receiveDamages(m_iAttackPoints);
    }

}