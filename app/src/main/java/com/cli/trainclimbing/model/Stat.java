package com.cli.trainclimbing.model;

import java.util.HashMap;

public class Stat {

    private int numberTrainingMonth;
    private float averageTimeTraining;
    private String levelUser;
    private HashMap<String, Integer> averageLevelTraining;

    public Stat(int numberTrainingMonth, float averageTimeTraining, String levelUser, HashMap<String, Integer> averageLevelTraining) {
        this.numberTrainingMonth = numberTrainingMonth;
        this.averageTimeTraining = averageTimeTraining;
        this.levelUser = levelUser;
        this.averageLevelTraining = averageLevelTraining;
    }

    public int getNumberTrainingMonth() {
        return numberTrainingMonth;
    }

    public void setNumberTrainingMonth(int numberTrainingMonth) {
        this.numberTrainingMonth = numberTrainingMonth;
    }

    public float getAverageTimeTraining() {
        return averageTimeTraining;
    }

    public String formatTime(float averageTimeTraining)
    {
        String durationTraining;
        int hours = (int) averageTimeTraining / 60;
        int minutes = (int) averageTimeTraining % 60;

        if(minutes < 10) {
            durationTraining =  hours + "h0" + minutes;
        }

        else
        {
            durationTraining = hours + "h" + minutes;
        }

        return durationTraining;
    }

    public void setAverageTimeTraining(float averageTimeTraining) {
        this.averageTimeTraining = averageTimeTraining;
    }

    public String getLevelUser() {
        return levelUser;
    }

    public void setLevelUser(String levelUser) {
        this.levelUser = levelUser;
    }

    public HashMap<String, Integer> getAverageLevelTraining() {
        return averageLevelTraining;
    }

    public void setAverageLevelTraining(HashMap<String, Integer> averageLevelTraining) {
        this.averageLevelTraining = averageLevelTraining;
    }
}
