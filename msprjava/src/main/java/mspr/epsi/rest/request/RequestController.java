package mspr.epsi.rest.request;

import com.fasterxml.jackson.annotation.JsonFormat;
import mspr.epsi.rest.request.entity.Request;
import mspr.epsi.rest.request.repository.RequestRepository;
import mspr.epsi.rest.request.response.RequestResponse;
import mspr.epsi.rest.utils.DateUtils;
import mspr.epsi.rest.utils.Response;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;


import java.util.Date;
import java.util.List;

@RestController
public class RequestController {

    private RequestService requestService;

    public RequestController(RequestRepository requestRepository){
        this.requestService = new RequestService(requestRepository);
    }

    @GetMapping("/request")
    @JsonFormat
    public ResponseEntity<Response> getRequestsAfterDate (@RequestParam(defaultValue = "") String year,
                                                          @RequestParam(defaultValue = "") String month,
                                                          @RequestParam(defaultValue = "") String day) {


        Date dateCompare = DateUtils.getDate(year + "-" + month + "-" + day);

        //Test si date is OK
        if(!DateUtils.compareDate(Integer.parseInt(year), Integer.parseInt(month), Integer.parseInt(day),
                                    dateCompare)){
            return new ResponseEntity<>(
                    new Response(HttpStatus.BAD_REQUEST.value(),"The date isn't correct"),
                    HttpStatus.BAD_REQUEST);
        }

        List<Request> requests = this.requestService.findRequestsAfterDate(dateCompare);

        return new ResponseEntity<>(
                new RequestResponse(HttpStatus.OK.value(), "Ok Request", requests),
                        HttpStatus.OK);
    }
}
