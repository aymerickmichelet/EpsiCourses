package mspr.epsi.rest.request;

import com.fasterxml.jackson.annotation.JsonFormat;
import mspr.epsi.rest.utils.DateUtils;
import mspr.epsi.rest.utils.Response;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

@RestController
public class RequestController {

    @GetMapping("/request")
    @JsonFormat
    public void getRequestsAfterDate (@RequestParam(defaultValue = "") String year,
                                      @RequestParam(defaultValue = "") String month,
                                      @RequestParam(defaultValue = "") String day) throws ParseException {


        Date dateCompare = DateUtils.getDate(year + "-" + month + "-" + day);

        System.out.println("dateCompare: "+dateCompare);
        System.out.println("year - month - day: " + year + "-" + month + "-" + day);

        //Test Years and month and day
        if(!DateUtils.compareDate(Integer.parseInt(year),
                                    Integer.parseInt(month),
                                    Integer.parseInt(day),
                                    dateCompare)){
            System.out.println("KO");
        }else{
            System.out.println("OK");
        }
    }
}
