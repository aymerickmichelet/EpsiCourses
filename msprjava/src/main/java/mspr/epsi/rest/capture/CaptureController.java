package mspr.epsi.rest.capture;

import mspr.epsi.rest.project.repository.ProjectRepository;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class CaptureController {

    private CaptureService captureService;

    public CaptureController(CaptureRepository captureRepository) throws Exception {
        this.captureService = new CaptureService(captureRepository);
    }

    @GetMapping("/duplicate-capture/{idProject}")
    public void getDuplicate(@PathVariable("idProject") long idProject) {



    }

}
