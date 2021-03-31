package fr.thejulienm.blablacar.controller;

import fr.thejulienm.blablacar.entity.*;
import fr.thejulienm.blablacar.repository.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
public class BlablacarController {

    VehicleRepository vehicleRepository;
    CarRepository carRepository;
    VanRepository vanRepository;
    RentRepository rentRepository;
    UserRepository userRepository;

    @Autowired
    public BlablacarController(
            VehicleRepository vehicleRepository,
            CarRepository carRepository,
            VanRepository vanRepository,
            RentRepository rentRepository,
            UserRepository userRepository
    ) {
        super();
        this.vehicleRepository = vehicleRepository;
        this.carRepository = carRepository;
        this.vanRepository = vanRepository;
        this.rentRepository = rentRepository;
        this.userRepository = userRepository;
    }

    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    //                         VEHICULES
    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

    private Vehicle getVehiculeByPlateNumber(String plateNumber){
        List<Vehicle> vehicules = vehicleRepository.findByPlateNumber(plateNumber);
        return vehicules.size() > 0 ? vehicules.get(0) : null;
    }

    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    //                            CARS
    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

    @GetMapping(value = "/cars")
    public Iterable<Car> getCars() {
        return carRepository.findAll();
    }

    @GetMapping(value="/cars/{plateNumber}")
    public Car getCarByPlateNumber(@PathVariable("plateNumber") String plateNumber) {
        return (Car) getVehiculeByPlateNumber(plateNumber);
    }

    @PostMapping("/cars")
    public Iterable<Car> addCar(@RequestBody Car car) {
        carRepository.save(car);
        return carRepository.findAll();
    }


    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    //                            VANS
    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

    @GetMapping(value = "/vans")
    public Iterable<Van> getListOfVans() {
        return vanRepository.findAll();
    }

    @GetMapping(value="/vans/{plateNumber}")
    public Van getVansByPlateNumber(@PathVariable("plateNumber") String plateNumber) {
        return (Van) getVehiculeByPlateNumber(plateNumber);
    }

    @PostMapping("/vans")
    public Iterable<Van> addVan(@RequestBody Van van) {
        vanRepository.save(van);
        return vanRepository.findAll();
    }

    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    //                            USERS
    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

    @GetMapping(value = "/users")
    public Iterable<User> getListOfUsers() {
        return userRepository.findAll();
    }

    @GetMapping(value="/users/{id}")
    public User getUserById(@PathVariable("id") long id) {
        Optional<User> users = userRepository.findById(id);
        return users.isEmpty() ? null : users.get();
    }

    @PostMapping("/users")
    public Iterable<User> addUser(@RequestBody User user) {
        userRepository.save(user);
        return userRepository.findAll();
    }

    @PutMapping("/users")
    public User setUser(@RequestBody User user) {
        if (userRepository.existsById(user.getId())){
            userRepository.save(user);
            return user;
        }
        return null;
    }

    @DeleteMapping("/users/{id}")
    public Iterable<User> removeUser(@PathVariable("id") long id) {
        if (userRepository.existsById(id)){
            userRepository.deleteById(id);
            return userRepository.findAll();
        }
        return null;
    }

    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    //                            RENTS
    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

    @GetMapping(value = "/rents")
    public Iterable<Rent> getRents() {
        return rentRepository.findAll();
    }

    @GetMapping(value="/rents/{id}")
    public Rent getRentById(@PathVariable("id") long id) {
        Optional<Rent> rents = rentRepository.findById(id);
        return rents.isEmpty() ? null : rents.get();
    }

    @PutMapping(value = "/{vehiculeType}/rent/{plateNumber}/{userId}")
    public Vehicle setRent(
            @PathVariable("plateNumber") String plateNumber,
            @PathVariable("userId") long userId,
            @RequestParam(value = "rent", required = true) boolean isRented,
            @RequestBody Rent rent) {

        rent.setVehicle(null);
        rent.setUser(null);

        Vehicle vehicule = getVehiculeByPlateNumber(plateNumber);
        User user = getUserById(userId);
        if (vehicule != null){
            vehicule.setRented(isRented);
            if (isRented){
                rent.setVehicle(vehicule);
                rent.setUser(user);
                vehicule.addRentToList(rent);
            }
            vehicleRepository.save(vehicule);
            return vehicule;
        }
        return null; // retourner erreur
    }
}
