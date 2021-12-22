import java.util.ArrayList;

public class Room {
    public Room(int p_iIndex) {
        if (p_iIndex % 4 == 0 && p_iIndex % 3 == 0) {
            //Create a Barbarian
        } else if (p_iIndex % 4 == 0) {
            //Create a Thief
        } else if (p_iIndex % 3 == 0) {
            //Create a Troll
        } else if (isPrime(p_iIndex)) {
            //Create a Sorcerer
        } else {
            //Create a Zombie
        }

        if (p_iIndex % 7 == 0)
            //Make the room contains a HealthPotion
        if (p_iIndex % 4 == 0)
        //Make the room contains a  StrengthPotion()
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
}
