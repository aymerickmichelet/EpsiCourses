package com.cli.trainclimbing.model;

import java.util.ArrayList;
import java.util.Date;

public class Training {

    private int id;
    private Date date;
    private float time;
    private ArrayList<Level> listLevel;

    public Training(int id, Date date, float time, ArrayList<Level> listLevel) {
        this.id = id;
        this.date = date;
        this.time = time;
        this.listLevel = listLevel;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public float getTime() {
        return time;
    }

    public void setTime(float time) {
        this.time = time;
    }

    public ArrayList<Level> getListLevel() {
        return listLevel;
    }

    public void setListLevel(ArrayList<Level> listLevel) {
        this.listLevel = listLevel;
    }
}
