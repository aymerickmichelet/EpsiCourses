package Character.Monster;

import Character.Character;

public class Monster extends Character {
    public String m_sEffectiveWeaponType;
    public static int s_iNbZombieInstances = 0;
    public static int s_iNbThiefInstances = 0;
    public static int s_iNbSorcerInstances = 0;
    public static int s_iNbBarbarianInstances = 0;
    public static int s_iNbTrollInstances = 0;
    private boolean m_bSearchDone;

    public Monster(){

    }

    public String getEffectiveWeaponType(){
        return this.m_sEffectiveWeaponType;
    }

    @Override
    public void attack(Character p_TargetCharacter){
        super.attack(p_TargetCharacter);
    }

    public boolean isWeaponEfficient(){
        return s_iNbBarbarianInstances
                + s_iNbSorcerInstances
                + s_iNbThiefInstances
                + s_iNbTrollInstances
                + s_iNbZombieInstances > 0;
    }
}