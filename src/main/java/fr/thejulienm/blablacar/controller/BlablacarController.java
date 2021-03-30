package fr.thejulienm.blablacar.controller;

import fr.thejulienm.blablacar.entity.Car;
import fr.thejulienm.blablacar.entity.Van;
import fr.thejulienm.blablacar.repository.CarRepository;
import fr.thejulienm.blablacar.repository.VanRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
public class BlablacarController {

    CarRepository carRepository;
    VanRepository vanRepository;

    @Autowired
    public BlablacarController(CarRepository carRepository, VanRepository vanRepository) {
        super();
        this.carRepository = carRepository;
        this.vanRepository = vanRepository;
    }

    @GetMapping(value = "/cars")
    public Iterable<Car> getListOfCars() {
        return carRepository.findAll();
    }

    @GetMapping(value="/cars/getCarByPlateNumber")// ?plateNumber=...
    public Car getCarByplateNumber(@RequestParam String plateNumber) {
        for(Car car: carRepository.findAll())
        {
            if(car.getPlateNumber().equals(plateNumber))
            {
                return car;
            }
        }
        return null;
    }

    @PostMapping("/cars")
    public Iterable<Car> addCar(@RequestBody Car car) {
        carRepository.save(car);
        return carRepository.findAll();
    }

    @PutMapping(value = "/cars/rentCar")
    public Car setCarRental(@RequestBody Car car) {
        for (Car c : carRepository.findAll()) {
            if (c.getPlateNumber().equalsIgnoreCase(car.getPlateNumber())){
                c.setRented(true);
                c.addRentToList(car.getRentList().get(0));
                carRepository.save(c);
                return c;
            }
        }

        return null;

    }

    @PutMapping(value = "/cars/rentCarReset")
    public Car setCarRentalReset(@RequestBody Car car) {
        for (Car c : carRepository.findAll()) {
            if (c.getPlateNumber().equalsIgnoreCase(car.getPlateNumber())){
                c.setRented(false);
                carRepository.save(c);
                return c;
            }
        }
        return null;
    }

    // VANS

    @PostMapping("/vans")
    public Iterable<Van> addVan(@RequestBody Van van) {
        vanRepository.save(van);
        return vanRepository.findAll();
    }

}
