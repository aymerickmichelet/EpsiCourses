package fr.thejulienm.blablacar;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.util.Date;

@SpringBootApplication
public class BlablacarApplication {

	public static void main(String[] args) {
		System.out.println(new Date().toString());
		SpringApplication.run(BlablacarApplication.class, args);
	}

}
