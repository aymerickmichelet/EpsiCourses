package fr.thejulienm.blablacar.entity;

import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import java.util.Date;

public class Rent {

    private long id;
    private User user;
    private Car car;
    private Date rentBegin;
    private Date rentEnd;
    private boolean isRented;

    public Rent(){
        super();
    }

    public Rent(User user, Car car) {
        super();
        this.user = user;
        this.car = car;
        this.rentBegin = null;
        this.rentEnd = null;
        this.isRented = false;
    }

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }

    public Car getCar() {
        return car;
    }

    public void setCar(Car car) {
        this.car = car;
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

    public boolean isRented() {
        return isRented;
    }

    public void setRented(boolean rented) {
        isRented = rented;
    }
}
