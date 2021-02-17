package com.cli.trainclimbing.model;

import java.util.ArrayList;
import java.util.Date;

public class Training {

    private int id;
    private Date date;
    private int time;
    private ArrayList<Level> listLevel;

    public Training(int id, Date date, int time, ArrayList<Level> listLevel) {
        this.id = id;
        this.date = date;
        this.time = time;
        this.listLevel = listLevel;
    }

    public void addLevel(Level level) {
        this.listLevel.add(level);
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

    public int getTime() {
        return time;
    }

    public void setTime(int time) {
        this.time = time;
    }

    public ArrayList<Level> getListLevel() {
        return listLevel;
    }

    public void setListLevel(ArrayList<Level> listLevel) {
        this.listLevel = listLevel;
    }
}
