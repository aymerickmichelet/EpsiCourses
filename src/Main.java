import java.util.Scanner;

import static java.lang.System.exit;


class MainConsole {
    public static void main(String[] args) {
        Scanner myScanner = new Scanner(System.in);
        String option = myScanner.nextLine();
        //Check if Dungeons / Room / Character.Monster.Monster... creation respect sequence diagram
        if (option.equals("Create Dungeon")) {
            int nbRooms = myScanner.nextInt();
            Dungeon dungeon = new Dungeon(nbRooms, true);
            exit(0);
        }
    }
}
