package fr.aymerickmichelet.primevideo;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.cloud.netflix.eureka.server.EnableEurekaServer;

@SpringBootApplication
@EnableEurekaServer
public class PrimeVideoApplication {

	public static void main(String[] args) {
		SpringApplication.run(PrimeVideoApplication.class, args);
	}

}
