package fr.aymerickmichelet.webservice1;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@SpringBootApplication
public class Webservice1Application {

	public static void main(String[] args) {
		SpringApplication.run(Webservice1Application.class, args);
	}

}

//Je ne suis pas du tout sur de cette implementation de code

@RestController
public class WebServiceExample {
	@GetMapping("/")
	public String sayHello(){
		return "Hello !";
	}
}