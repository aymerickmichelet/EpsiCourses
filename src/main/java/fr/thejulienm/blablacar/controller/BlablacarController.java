package fr.thejulienm.blablacar.controller;

import fr.thejulienm.blablacar.entity.Car;
import fr.thejulienm.blablacar.repository.CarRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
public class BlablacarController {

    CarRepository carRepository;

    @Autowired
    public BlablacarController(CarRepository carRepository) {
        super();
        this.carRepository = carRepository;
    }

    @GetMapping(value = "/cars")
    public Iterable<Car> getListOfCars() {
        return carRepository.findAll();
    }

    @GetMapping(value="/cars/getCarByPlateNumber") // ?plateNumber=...
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
                c.setRentBegin(car.getRentBegin());
                c.setRentEnd(car.getRentEnd());
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
                c.setRentBegin(null);
                c.setRentEnd(null);
                carRepository.save(c);
                return c;
            }
        }
        return null;
    }

}
