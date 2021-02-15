package com.cli.trainclimbing.model;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.util.Log;

import com.cli.trainclimbing.utils.MySQLiteOpenHelper;

import java.util.Date;
import java.sql.Timestamp;
import java.util.ArrayList;
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
        cursor.moveToFirst();
        //loop cursor
        while(!cursor.isAfterLast()) {

            Level newLevel = new Level(cursor.getString(3), cursor.getInt(4));
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
