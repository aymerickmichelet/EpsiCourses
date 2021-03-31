package fr.thejulienm.blablacar.repository;

import fr.thejulienm.blablacar.entity.Van;
import org.springframework.data.repository.CrudRepository;

import java.util.List;

public interface VanRepository extends CrudRepository<Van, Long> {
    List<Van> findByPlateNumber(String plateNumber);
}