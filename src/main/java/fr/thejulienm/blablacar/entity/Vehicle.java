package fr.thejulienm.blablacar.entity;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import java.util.Date;

@Entity
public class Vehicle {

    private long id;
    private String brand;
    private int price;
    private boolean isRented;
    private Date rentBegin;
    private Date rentEnd;


    public Vehicle(){
        super();
    }


    public Vehicle(String plateNumber, String brand, int price) {
        super();
//        this.plateNumber = plateNumber;
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

//    public String getPlateNumber() {
//        return plateNumber;
//    }

//    public void setPlateNumber(String plateNumber) {
//        this.plateNumber = plateNumber;
//    }

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

    public Date getRentBegin() {
        return rentBegin;
    }

    public void setRentBegin(Date rentBegin) {
        this.rentBegin = rentBegin;
    }

    public Date getRentEnd() {
        return rentEnd;
    }

    public void setRentEnd(Date rentEnd) {
        this.rentEnd = rentEnd;
    }

}
