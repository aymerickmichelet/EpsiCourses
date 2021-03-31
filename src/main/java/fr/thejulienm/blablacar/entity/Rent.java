package fr.thejulienm.blablacar.entity;

import com.fasterxml.jackson.annotation.JsonIgnore;

import javax.persistence.*;
import java.util.Date;

@Entity
public class Rent {

    private long id;
    private Vehicle vehicle;
    private User user;
    private Date rentBegin;
    private Date rentEnd;

    public Rent(){
        super();
    }

    public Rent(User user, Vehicle vehicle)
    {
        super();
        this.user = user;
        this.vehicle = vehicle;
        this.rentBegin = null;
        this.rentEnd = null;
    }

    public Rent(User user, Date rentBegin, Date rentEnd)
    {
        super();
        this.user = user;
        this.vehicle = null;
        this.rentBegin = rentBegin;
        this.rentEnd = rentEnd;
    }

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
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

    @ManyToOne
    @JsonIgnore
    public Vehicle getVehicle() {
        return vehicle;
    }

    public void setVehicle(Vehicle vehicle) {
        this.vehicle = vehicle;
    }

    @ManyToOne
    @JsonIgnore
    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }
}
