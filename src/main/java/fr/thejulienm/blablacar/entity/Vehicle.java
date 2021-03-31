package fr.thejulienm.blablacar.entity;
import com.fasterxml.jackson.annotation.JsonIgnore;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity
public class Vehicle {

    protected long id;
    protected String plateNumber;
    protected String brand;
    protected int price;
    protected boolean isRented;
    protected List<Rent> rents;


    public Vehicle(){
        super();
        this.rents = new ArrayList<>();
    }

    public Vehicle(String plateNumber, String brand, int price) {
        super();
        this.plateNumber = plateNumber;
        this.brand = brand;
        this.price = price;
        this.isRented = false;
        this.rents = new ArrayList<>();
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

    public void setPlateNumber(String plateNumber){
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

    @OneToMany(mappedBy = "vehicle", cascade = CascadeType.ALL)
    @JsonIgnore
    public List<Rent> getRents() {
        return rents;
    }

    public void setRents(List<Rent> rent) {
        this.rents = rent;
    }

    public void addRentToList(Rent rent){
        rents.add(rent);
    }
}
