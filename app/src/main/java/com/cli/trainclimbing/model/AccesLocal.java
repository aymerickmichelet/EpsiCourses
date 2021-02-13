package com.cli.trainclimbing.model;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.util.Log;

import com.cli.trainclimbing.utils.MySQLiteOpenHelper;

import java.sql.Timestamp;
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

    public void addExample() {
        db = accesDB.getWritableDatabase();
        String req = "insert into training(date , time) VALUES";
        req += "(11, 11)";
        db.execSQL(req);
    }
}
