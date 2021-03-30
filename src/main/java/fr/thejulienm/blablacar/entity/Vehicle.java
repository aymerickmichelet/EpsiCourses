package fr.thejulienm.blablacar.entity;
import com.fasterxml.jackson.annotation.JsonIgnore;

import javax.persistence.*;
import java.util.Date;
import java.util.List;

@Entity
public class Vehicle {

    protected long id;
    protected String plateNumber;
    protected String brand;
    protected int price;
    protected boolean isRented;
    protected List<Rent> rentList;


    public Vehicle(){
        super();
    }

    public Vehicle(String plateNumber, String brand, int price) {
        super();
        this.plateNumber = plateNumber;
        this.brand = brand;
        this.price = price;
        this.isRented = false;
    }

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    public long getId() {
        return id;
    }

    public void setId(long key) {
        this.id = key;
    }

    public String getPlateNumber() {
        return plateNumber;
    }

    public void setPlateNumber(String plateNumber) {
        this.plateNumber = plateNumber;
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public int getPrice() {
        return price;
    }

    public void setPrice(int price) {
        this.price = price;
    }

    public boolean isRented() {
        return isRented;
    }

    public void setRented(boolean rented) {
        isRented = rented;
    }

    @OneToMany
    @JsonIgnore
    public List<Rent> getRentList() {
        return rentList;
    }

    public void setRentList(List<Rent> rent) {
        this.rentList = rent;
    }

    public void addRentToList(Rent rent){
        rentList.add(rent);
    }
}
