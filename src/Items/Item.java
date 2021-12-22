package Items;

import Character.Hero;

public abstract class Item {
    protected int m_iEffectValue;

    public void applyEffect(Hero p_Hero) {

    }

    public void setValue(int p_iValue){
        this.m_iEffectValue = p_iValue;
    }
}