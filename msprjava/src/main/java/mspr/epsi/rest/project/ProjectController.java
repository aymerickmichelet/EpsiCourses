package mspr.epsi.rest.project;

import com.fasterxml.jackson.annotation.JsonFormat;
import mspr.epsi.rest.capture.CaptureRepository;
import mspr.epsi.rest.capture.CaptureService;
import mspr.epsi.rest.project.entity.Project;
import mspr.epsi.rest.project.repository.ProjectRepository;
import mspr.epsi.rest.project.response.ProjectResponse;
import mspr.epsi.rest.project.response.ProjectSizeResponse;
import mspr.epsi.rest.subcontractor.repository.SubcontractorRepository;
import mspr.epsi.rest.utils.DateUtils;
import mspr.epsi.rest.utils.Response;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.Date;
import java.util.List;

@RestController
public class ProjectController {

    private ProjectService projectService;

    public ProjectController(ProjectRepository projectRepository, CaptureRepository captureRepository,
                             SubcontractorRepository subcontractorRepository) {
        this.projectService = new ProjectService(projectRepository, captureRepository, subcontractorRepository);
    }

    @PostMapping("/add-projects")
    public List<Project> addProject() {
        return this.projectService.addProjects();
    }

    @GetMapping("/projects")
    public List<Project> getProjectsList() throws Exception {
        return this.projectService.findAll();
    }

    @GetMapping("/project/{id}")
    @ResponseBody
    public ResponseEntity<Response> getProject(@PathVariable("id") long idProject) {

        try {
            Project project = this.projectService.findById(idProject);
            ProjectResponse projectResponse = new ProjectResponse(HttpStatus.OK.value(), "Project found",
                    project);
            return new ResponseEntity<>(projectResponse, HttpStatus.OK);
        }
        catch(Exception e) {
            Response response = new Response(HttpStatus.BAD_REQUEST.value(), "Project not found");
            return new ResponseEntity<>(response, HttpStatus.BAD_REQUEST);
        }

    }

    @GetMapping("/projects-size")
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
