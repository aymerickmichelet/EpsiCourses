package mspr.epsi.rest.example;

import mspr.epsi.rest.example.entity.Example;
import org.springframework.data.repository.CrudRepository;

public interface ExampleRepository extends CrudRepository<Example, Long> {
}
