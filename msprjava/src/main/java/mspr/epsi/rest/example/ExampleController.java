package mspr.epsi.rest.example;

import mspr.epsi.rest.example.entity.Example;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.ArrayList;
import java.util.List;

@RestController
public class ExampleController {
    ExampleService exempleService;

    public ExampleController(ExampleRepository exampleRepository) {
       this.exempleService = new ExampleService(exampleRepository);
    }

    @GetMapping("/examples")
    public List<Example> getAllExample() throws  Exception {
        List<Example> examples = this.exempleService.findAll();
        System.out.println(examples);
        return examples;
    }

}
