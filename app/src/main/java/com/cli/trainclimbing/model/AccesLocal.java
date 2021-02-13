package com.cli.trainclimbing.model;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

import com.cli.trainclimbing.utils.MySQLiteOpenHelper;

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

    public void addExample() {
        db = accesDB.getWritableDatabase();
        String req = "insert into training(date , time) VALUES";
        req += "(11, 11)";
        db.execSQL(req);
    }





}
