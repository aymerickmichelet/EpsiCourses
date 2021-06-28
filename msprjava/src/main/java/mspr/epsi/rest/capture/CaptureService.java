package mspr.epsi.rest.capture;

import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.project.ProjectService;
import mspr.epsi.rest.project.entity.Project;
import mspr.epsi.rest.project.repository.ProjectRepository;
import mspr.epsi.rest.subcontractor.entity.Subcontractor;
import mspr.epsi.rest.utils.DateUtils;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class CaptureService {

    private CaptureRepository captureRepository;

    public CaptureService(CaptureRepository captureRepository) {
        this.captureRepository = captureRepository;

        /* Date date = DateUtils.getDate("2021-06-28");
        Project project = projectService.findById(4);
        List<Subcontractor> subcontractors = new ArrayList<Subcontractor>(); */
    }

    public List<Capture> getListFictiveCapture() {
        Date date = DateUtils.getDate("2021-06-28");
        List<Subcontractor> subcontractors = new ArrayList<Subcontractor>();

        List<Capture> captures = new ArrayList<>();

        for(int i = 0; i < 5; i++) {
            captures.add(new Capture("https://perdu.com", date, 44.63f, (float) -1.08,
                    subcontractors));

        }
        return captures;
    }


}
