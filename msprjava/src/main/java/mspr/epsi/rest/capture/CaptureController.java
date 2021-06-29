package mspr.epsi.rest.capture;

import mspr.epsi.rest.capture.Params.AddCapture;
import mspr.epsi.rest.capture.Response.CaptureResponse;
import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.project.ProjectService;
import mspr.epsi.rest.project.entity.Project;
import mspr.epsi.rest.project.repository.ProjectRepository;
import mspr.epsi.rest.subcontractor.SubcontractorService;
import mspr.epsi.rest.subcontractor.entity.Subcontractor;
import mspr.epsi.rest.subcontractor.repository.SubcontractorRepository;
import mspr.epsi.rest.utils.Response;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;

@RestController
public class CaptureController {

    private CaptureService captureService;
    private ProjectService projectService;
    private SubcontractorService subcontractorService;

    public CaptureController(CaptureRepository captureRepository, ProjectRepository projectRepository,
                             SubcontractorRepository subcontractorRepository) {
        this.captureService = new CaptureService(captureRepository);
        this.projectService = new ProjectService(projectRepository, captureRepository,subcontractorRepository);
        this.subcontractorService = new SubcontractorService(subcontractorRepository);
    }

    @GetMapping("/duplicate-capture/{idProject}")
    public List<Capture> getDuplicate(@PathVariable("idProject") long idProject) {
        return this.captureService.getDuplicateCatpure(idProject);
    }

    @PostMapping("/capture")
    public ResponseEntity<Response> addCapture( @RequestParam("verifDuplicate") boolean verifDuplicate,
                            @RequestBody AddCapture captureParams
    ) {

        //create object Capture
        Project project = new Project();
        List<Subcontractor> subcontractors = new ArrayList<>();

        try {
            project = this.projectService.findById(captureParams.getProjectId());
            subcontractors = this.subcontractorService.getListSubcontractorById(captureParams.getSubcontractorsId());

            if(subcontractors.size() != captureParams.getSubcontractorsId().size()) {
                throw new Exception("Error get subcontractor");
            }

        } catch(Exception e) {
            String errorMsg = "Error get project or subcontractors";
            if(e.getMessage().equals("Project not found") || e.getMessage().equals("Error get subcontractor")) {
                errorMsg = e.getMessage();
            }
            Response response = new Response(HttpStatus.NOT_FOUND.value(), errorMsg);
            return new ResponseEntity(response, HttpStatus.NOT_FOUND);
        }

        Capture capture = captureParams.getCapture(project, subcontractors);


        //verif duplicate
        List<Capture> duplicateCaptures = new ArrayList<>();
        if(verifDuplicate) {
            duplicateCaptures = this.captureService.getCapturesIdenticals(capture);
        }

        if(duplicateCaptures.size() == 0) {
            Capture newCapture = this.captureService.addCapture(capture);

            CaptureResponse response = new CaptureResponse(HttpStatus.OK.value(), "add captures", newCapture);
            return new ResponseEntity(response, HttpStatus.OK);
        }


        return new ResponseEntity<>(
                new Response(HttpStatus.BAD_REQUEST.value(),"Captures with duplication"),
                HttpStatus.BAD_REQUEST);

    }

}
