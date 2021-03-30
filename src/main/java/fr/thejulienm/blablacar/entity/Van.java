package fr.thejulienm.blablacar.entity;

import javax.persistence.Entity;

@Entity
public class Van extends Vehicle {

    private int maxWeight;

    public Van()
    {
        super();
    }

    public Van(String plateNumber, String brand, int price, int maxWeight) {
        super(plateNumber, brand, price);
        this.maxWeight = maxWeight;
    }

    public int getMaxWeight() {
        return maxWeight;
    }

    public void setMaxWeight(int maxWeight) {
        this.maxWeight = maxWeight;
    }
}
