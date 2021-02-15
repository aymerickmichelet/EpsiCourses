package com.cli.trainclimbing.controller;

import android.content.Context;

import com.cli.trainclimbing.model.AccesLocal;
import com.cli.trainclimbing.model.Stat;
import com.cli.trainclimbing.model.Training;

import java.util.ArrayList;

public final class Controller {

    private static Controller instance = null;
    private static AccesLocal accesLocal;

    private Controller() {super();}

    public static final Controller getInstance(Context context) {
        if(Controller.instance == null) {
            Controller.instance = new Controller();
            accesLocal = new AccesLocal(context);
        }
        return Controller.instance;
    }

    public void AddTraining(Training training) {
        accesLocal.addTrainingAndLevel(training);
    }

    public int getLastIdTraining() {
        return accesLocal.getLastIdTraining();
    }

    public ArrayList<Training> getTraining() {
        return accesLocal.getTraining();

    }

    public Stat getStat() {
        return accesLocal.getStat();
    }


    public void addExample() {
        accesLocal.addExample();
    }


}
