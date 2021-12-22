import java.util.ArrayList;

import Character.Monster.*;
import Character.Hero;
import Items.HealthPotion;
import Items.Item;
import Items.StrengthPotion;

public class Room {

    private ArrayList<Item> m_Items; // *
    private Monster m_RoomMonster; // 1

    public Room(int p_iIndex) {
        if (p_iIndex % 4 == 0 && p_iIndex % 3 == 0) {
            Barbarian barbarian = new Barbarian();
        } else if (p_iIndex % 4 == 0) {
            Thief thief = new Thief();
        } else if (p_iIndex % 3 == 0) {
            Troll troll = new Troll();
        } else if (isPrime(p_iIndex)) {
            Sorcerer sorcerer = new Sorcerer();
        } else {
            Zombie zombie = new Zombie();
        }

        if (p_iIndex % 7 == 0); m_Items.add(new HealthPotion());
        if (p_iIndex % 4 == 0); m_Items.add(new StrengthPotion());
    }

    private boolean isPrime(int p_iIndex) {
        if (p_iIndex == 2)
            return true;
        if (p_iIndex % 2 == 0 || p_iIndex < 3)
            return false;
        for (int i = 3; i <= Math.pow(p_iIndex, 0.5) + 1; i += 2) {
            if (p_iIndex % i == 0) return false;
        }
        return true;
    }

    public Monster getMonster(){
        return m_RoomMonster;
    }

    public void enterRoom(Hero p_Hero){
        // changer la piece de p_Hero
        // dialogue
    }
}
