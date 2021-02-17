package com.cli.trainclimbing.utils;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

import androidx.annotation.Nullable;

public class MySQLiteOpenHelper extends SQLiteOpenHelper {

    private static final  String nameDB = "bdTraining.db";
    private static final int versionDB = 1;

    public MySQLiteOpenHelper(@Nullable Context context) {
        super(context, nameDB, null, versionDB);
        getWritableDatabase();
        getReadableDatabase();
        Log.d("SQL", "SQL Init");
    }


    @Override
    public void onCreate(SQLiteDatabase db) {

        String tableTraining = "CREATE TABLE training (id_training INTEGER PRIMARY KEY AUTOINCREMENT," +
                "date INTEGER, time INTEGER);";

        String tableLevel = "CREATE TABLE level (id_level INTEGER PRIMARY KEY AUTOINCREMENT," +
                "id_training INTEGER, number INTEGER, name TEXT," +
                "FOREIGN KEY(id_training) REFERENCES training(id_training));";

       // String creation = tableTraining +" " +tableLevel;

        db.execSQL(tableTraining);
        db.execSQL(tableLevel);
    }


    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }
}
