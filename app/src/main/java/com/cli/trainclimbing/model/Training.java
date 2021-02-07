package com.cli.trainclimbing.model;

//Ceci est un model provisoire, le temps de faire les views.
public class Training {
    private String date;
    private String hours;

    public Training(String date, String hours) {
        this.date = date;
        this.hours = hours;
    }

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    public String getHours() {
        return hours;
    }

    public void setHours(String hours) {
        this.hours = hours;
    }
}
