package fr.thejulienm.blablacar.repository;

import fr.thejulienm.blablacar.entity.Rent;
import org.springframework.data.repository.CrudRepository;

//import java.util.List;

public interface RentRepository extends CrudRepository<Rent, Long> {
//   List<Car> findByPlateNumber(String plateNumber);
}