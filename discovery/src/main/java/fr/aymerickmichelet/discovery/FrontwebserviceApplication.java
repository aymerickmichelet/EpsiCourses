package fr.aymerickmichelet.discovery;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cloud.client.ServiceInstance;
import org.springframework.cloud.client.discovery.DiscoveryClient;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.client.RestTemplate;

import java.util.List;

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
        return s;
    }
}
