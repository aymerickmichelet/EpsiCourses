/**
 * 
 */
public class Weapon {

    /**
     * Default constructor
     */
    public Weapon() {
        m_iAttackPoints = 10;
    }

    /**
     *
     */
    protected int m_iAttackPoints;


    /**
     * @param p_TargetCharacter
     */
    public void inflictDamage(Character p_TargetCharacter) {
        p_TargetCharacter.receiveDamages(m_iAttackPoints);
    }

}