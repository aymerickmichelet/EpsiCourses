package fr.thejulienm.blablacar.repository;

import fr.thejulienm.blablacar.entity.Car;
import org.springframework.data.repository.CrudRepository;

//import java.util.List;

public interface CarRepository extends CrudRepository<Car, Long> {
//    List<Car> findByPlateNumber(String plateNumber);
}
