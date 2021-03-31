package fr.thejulienm.blablacar.entity;
import javax.persistence.Entity;

@Entity
public class Car extends Vehicle {

    private int numberOfSeats;

    public Car(){
        super();
    }

    public Car(String plateNumber, String brand, int price, int numberOfSeats) {
        super(plateNumber,brand,price);
        this.numberOfSeats = numberOfSeats;
    }

    public int getNumberOfSeats() {
        return numberOfSeats;
    }

    public void setNumberOfSeats(int numberOfSeats) {
        this.numberOfSeats = numberOfSeats;
    }
}
