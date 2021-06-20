package mspr.epsi.rest.project;

import com.fasterxml.jackson.annotation.JsonFormat;
import mspr.epsi.rest.project.repository.ProjectRepository;
import mspr.epsi.rest.project.response.ProjectSizeResponse;
import mspr.epsi.rest.utils.DateUtils;
import mspr.epsi.rest.utils.Response;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.Date;

@RestController
public class ProjectController {

    private ProjectService projectService;

    public ProjectController(ProjectRepository projectRepository) {
        this.projectService = new ProjectService(projectRepository);
    }

    @GetMapping("/projects/size")
    @JsonFormat
    public ResponseEntity<Response> getSize(@RequestParam(defaultValue = "") String year,
                                            @RequestParam(defaultValue =  "") String month) {


        Date dateCompare = DateUtils.getDate(year + "-" + month + "-01");

        //Test Years and month
        if(!DateUtils.compareYears(Integer.parseInt(year), dateCompare) ||
                !DateUtils.compareMonth(Integer.parseInt(month), dateCompare)) {

            Response response = new Response(HttpStatus.BAD_REQUEST.value(), "Year and month not good");
            return new ResponseEntity<>(response, HttpStatus.BAD_REQUEST);

        }

        long size = this.projectService.findLength(dateCompare);
        String msg = "Ok Resquest";

        ProjectSizeResponse response = new ProjectSizeResponse(HttpStatus.OK.value(), msg, size);
        return new ResponseEntity<>(response, HttpStatus.OK);

    }

}
