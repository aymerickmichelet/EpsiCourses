package fr.thejulienm.blablacar.repository;

import fr.thejulienm.blablacar.entity.User;
import org.springframework.data.repository.CrudRepository;

public interface UserRepository extends CrudRepository<User, Long> {

}
