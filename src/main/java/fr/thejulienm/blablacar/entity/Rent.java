package fr.thejulienm.blablacar.entity;

import com.fasterxml.jackson.annotation.JsonIgnore;

import javax.persistence.*;
import java.util.Date;

@Entity
public class Rent {

    private long id;
    //private long idUser;
    private Date rentBegin;
    private Date rentEnd;
    private boolean isRented;
    private Vehicle vehicle;

    public Rent(){
        super();
    }

    public Rent(/*User user,*/ Vehicle vehicle)
    {
        super();
        //this.idUser = user.getId();
        this.vehicle = vehicle;
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

//    public long getIdUser() {
//        return idUser;
//    }
//
//    public void setIdUser(long idUser) {
//        this.idUser = idUser;
//    }

//    public long getIdVehicle() {
//        return idVehicle;
//    }
//
//    public void setIdVehicle(long idVehicle) {
//        this.idVehicle = idVehicle;
//    }

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

    @OneToOne
    @JsonIgnore
    public Vehicle getVehicle() {
        return vehicle;
    }

    public void setVehicle(Vehicle vehicle) {
        this.vehicle = vehicle;
    }
}
