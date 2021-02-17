package com.cli.trainclimbing.model;

import java.text.SimpleDateFormat;
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

    public String formatDate() {
        SimpleDateFormat simpleDateFormat = new SimpleDateFormat("dd/MM/yyyy");
        return simpleDateFormat.format(this.date);
    }

    public String formatTimes() {
        int hours = time / 60;
        int minutes = time % 60;
        if(minutes < 10) {
            return hours + "h0" + minutes;
        }
        return hours + "h" + minutes;
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
