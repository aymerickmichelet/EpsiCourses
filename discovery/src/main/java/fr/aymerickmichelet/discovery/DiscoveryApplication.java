package fr.aymerickmichelet.discovery;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class DiscoveryApplication {

	public static void main(String[] args) {
		SpringApplication.run(DiscoveryApplication.class, args);
	}

}


@RestController
public class FrontwebserviceApplication {
	@Autowired
	DiscoveryClient discoveryClient;
	@GetMapping("/")
	public String hello() {
		List<ServiceInstance> instances = discoveryClient.getInstances("webservice1");
		ServiceInstance test = instances.get(0);
		String hostname = test.getHost();
		int port = test.getPort();
		RestTemplate restTemplate = new RestTemplate();
		String microservice1Address = "http://" + hostname + ":" + port;
		ResponseEntity<String> response =
				restTemplate.getForEntity(microservice1Address, String.class);
		String s = response.getBody();
		Return s;
	}
}