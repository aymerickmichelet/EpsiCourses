package fr.thejulienm.blablacar.repository;

import fr.thejulienm.blablacar.entity.Vehicle;
import org.springframework.data.repository.CrudRepository;

import java.util.List;

public interface VehicleRepository extends CrudRepository<Vehicle, Long> {
    List<Vehicle> findByPlateNumber(String plateNumber);
}
