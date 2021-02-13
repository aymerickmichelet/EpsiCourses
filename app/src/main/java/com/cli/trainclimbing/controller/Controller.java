package com.cli.trainclimbing.controller;

import android.content.Context;

import com.cli.trainclimbing.model.AccesLocal;

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

    public void addExample() {
        accesLocal.addExample();
    }


}
