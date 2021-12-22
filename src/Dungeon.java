import java.util.ArrayList;

import Character.Hero;

public class Dungeon {

    private final ArrayList<Room> m_RoomsArray = new ArrayList<>(); // 25

    public Dungeon(int nbRooms, boolean b) {
        for (int i = 0, imax = nbRooms; i < imax; i++){
            m_RoomsArray.add(new Room(i));
        }
    }

    public Room getRoom(int p_iRoomIndex){
        return m_RoomsArray.get(p_iRoomIndex);
    }

    public void greetHeros(Hero p_Hero){
        // dialogue
    }
}