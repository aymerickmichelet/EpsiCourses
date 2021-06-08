package mspr.epsi.rest.example;

import mspr.epsi.rest.example.entity.Example;

import java.util.ArrayList;
import java.util.List;


public class ExampleService {
    ExampleRepository exampleRepository;

    public ExampleService(ExampleRepository exampleRepository) {
        this.exampleRepository = exampleRepository;
        this.exampleRepository.save(new Example("Exemple 1"));
        this.exampleRepository.save(new Example("Exemple 2"));
        this.exampleRepository.save(new Example("Exemple 3"));
    }

    public List<Example>findAll() {
        List<Example> examples = new ArrayList<Example>();
        this.exampleRepository.findAll().forEach(examples::add);
        return examples;
    }

}
