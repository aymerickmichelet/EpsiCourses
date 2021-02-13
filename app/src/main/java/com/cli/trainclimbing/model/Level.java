package com.cli.trainclimbing.model;

public class Level {

    private NameLevel name;
    private int number;

    public Level(NameLevel name, int number) {
        this.name = name;
        this.number = number;
    }

    public NameLevel getName() {
        return name;
    }

    public void setName(NameLevel name) {
        this.name = name;
    }

    public int getNumber() {
        return number;
    }

    public void setNumber(int number) {
        this.number = number;
    }
}
