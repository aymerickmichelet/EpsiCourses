package com.cli.trainclimbing.model;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.util.Log;

import com.cli.trainclimbing.utils.MySQLiteOpenHelper;

import java.util.Calendar;
import java.util.Date;
import java.sql.Timestamp;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class AccesLocal {

    private MySQLiteOpenHelper accesDB;
    private SQLiteDatabase db;

    /**
     * Constructor
     * @param context
     */
    public AccesLocal(Context context) {
        accesDB = new MySQLiteOpenHelper(context);
    }

    public void addTrainingAndLevel(Training training) {
        long date = training.getDate().getTime();

        db = accesDB.getWritableDatabase();
        String insertTraining = "INSERT INTO training(date, time) VALUES" +
                "("+ date +"," + training.getTime() +");";

        db.execSQL(insertTraining);

        for(Level level: training.getListLevel()) {
           String insertLevel = "INSERT INTO level(id_training, number, name) VALUES" +
                   "("+ training.getId() +"," + level.getNumber() +",'" + level.getName() +"');";

         db.execSQL(insertLevel);
       }
    }

    public int getLastIdTraining() {
        db = accesDB.getReadableDatabase();
        String req = "SELECT id_training from training ORDER BY id_training DESC limit 1;";

        Cursor cursor = db.rawQuery(req, null);
        cursor.moveToLast();

        int lastId = 0;
        if(!cursor.isAfterLast()) {
            lastId = cursor.getInt(0);
        }

        return lastId;
    }

    public ArrayList<Training> getTraining() {
        db = accesDB.getReadableDatabase();
        ArrayList<Training> listTraining = new ArrayList<Training>();

        String req = "SELECT training.id_training AS id, date, time, number, name FROM training " +
                "INNER JOIN level ON training.id_training = level.id_training";

        Cursor cursor = db.rawQuery(req, null);

        listTraining = this.setTrainingWithCursor(cursor);

        return listTraining;
    }

    public Stat getStat() {
        db = accesDB.getReadableDatabase();

        ArrayList<Training> listTraining = new ArrayList<Training>();

        //get startMonth
        Calendar calendar = Calendar.getInstance();
        int year = calendar.get(Calendar.YEAR);
        int month = calendar.get(Calendar.MONTH);
        int day = 1;
        long startMonth = new Date(year - 1900, month, day, 0, 0, 0).getTime();

        String req = "SELECT training.id_training AS id, date, time, number, name FROM training " +
                "INNER JOIN level ON training.id_training = level.id_training" +
                " WHERE date >= " + startMonth +";";

        Cursor cursor = db.rawQuery(req, null);
        listTraining = this.setTrainingWithCursor(cursor);

        //Création des stats
        int numberTrainingMonth = listTraining.size();
        float averageTimeTraining = 0;
        String levelUser = "EASY";
        HashMap<String, Integer> averageLevelTraining = new HashMap<String, Integer>();

        HashMap<String, Integer> levelTraining = new HashMap<String, Integer>();

        levelTraining.put("EASY", 0);
        levelTraining.put("MEDIUM", 0);
        levelTraining.put("HIGHT", 0);
        levelTraining.put("HARDCORE", 0);

        //parcours training
        for(Training training : listTraining) {
            averageTimeTraining += training.getTime();

            //parcours level
            for(Level level: training.getListLevel()) {

                switch (level.getName()){
                    case "EASY":
                        levelTraining.put("EASY", levelTraining.get("EASY") + level.getNumber());
                        break;
                    case "MEDIUM":
                        levelTraining.put("MEDIUM", levelTraining.get("MEDIUM") + level.getNumber());
                        break;
                    case "HIGHT":
                        levelTraining.put("HIGHT", levelTraining.get("HIGHT") + level.getNumber());
                        break;
                    case "HARDCORE":
                        levelTraining.put("HARDCORE", levelTraining.get("HARDCORE") + level.getNumber());
                        break;
                }
            }
        }

        averageTimeTraining = averageTimeTraining / numberTrainingMonth;

        int levelUserData = 0;
        for(String key: levelTraining.keySet()) {
            averageLevelTraining.put(key, levelTraining.get(key)/numberTrainingMonth);
            if(levelTraining.get(key) >= levelUserData && levelTraining.get(key) > 0) {
                levelUserData = levelTraining.get(key);
                levelUser = key;
            }
        }

        Stat stat = new Stat(numberTrainingMonth, averageTimeTraining, levelUser, averageLevelTraining);
        return stat;
    }

    public ArrayList<Training> setTrainingWithCursor(Cursor cursor) {
        ArrayList<Training> listTraining = new ArrayList<Training>();

        cursor.moveToFirst();
        //loop cursor
        while(!cursor.isAfterLast()) {

            Level newLevel = new Level(cursor.getString(4), cursor.getInt(3));
            boolean findTraining = false;
            for(Training training: listTraining) {

                //if training existe
                if(training.getId() == cursor.getInt(0)) {
                    //add level
                    training.addLevel(newLevel);
                    findTraining = true;
                    break;
                }
            }
            //create new element
            if(!findTraining) {
                Date date = new Date(cursor.getLong(1));

                Training newTraining = new Training(cursor.getInt(0),
                        date, cursor.getFloat(2), new ArrayList<Level>()
                );
                newTraining.addLevel(newLevel);
                listTraining.add(newTraining);
            }
            cursor.moveToNext();
        }
        return listTraining;

    }

    public void addExample() {
        db = accesDB.getWritableDatabase();
        String req = "insert into training(date , time) VALUES";
        req += "(11, 11)";
        db.execSQL(req);
    }
}
