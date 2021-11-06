package mspr.epsi.rest.capture;

import mspr.epsi.rest.capture.dto.CaptureSubDto;
import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.subcontractor.entity.Subcontractor;
import mspr.epsi.rest.utils.DateUtils;

import java.util.*;

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
            captures.add(new Capture("https://perdu.com", date, "Incident", 44.63f, (float) -1.08, "Etape 1",
                    subcontractors));

        }
        return captures;
    }

    public List<Capture> detectDuplicateCapture(List<Capture> captures) {

        List<Capture> duplicateCaptureList = new ArrayList<>();
        Set<String> incidents = new HashSet<String>();
        Set<Date> dates = new HashSet<Date>();
        Set<Float> lats = new HashSet<Float>();
        Set<Float> longs = new HashSet<Float>();

        for(Capture capture: captures) {

            if (incidents.contains(capture.getIncident())
                    && dates.contains(capture.getDate())
                    && lats.contains(capture.getLatitude())
                    && longs.contains(capture.getLongitude())
            ) {
                duplicateCaptureList.add(capture);
            } else {
                incidents.add(capture.getIncident());
                dates.add(capture.getDate());
                lats.add(capture.getLatitude());
                longs.add(capture.getLongitude());
            }
        }

        return duplicateCaptureList;
    }

    public List<Capture> getDuplicateCatpure(long idProject) {
        List<Capture> captures = this.captureRepository.getCaptureByProjectId(idProject);
        return detectDuplicateCapture(captures);
    }

    public List<Capture> getCapturesIdenticals(Capture capture) {
        List<Capture> captures = this.captureRepository.getCapturesIdenticals(capture.getProject().getId(),
                capture.getIncident(), capture.getLatitude(), capture.getLongitude(), capture.getDate()
                );
        return captures;
    }

    public List<CaptureSubDto> findCapturesByProjectIdAndStep(long projectId, String step) {
        return this.captureRepository.findCapturesByProjectIdAndStep(projectId, step);
    }

    public List<CaptureSubDto> findCapturesByProjectIdAndStep(long projectId, String step, Date startDate, Date endDate) {
        return this.captureRepository.findCapturesByProjectIdAndStep(projectId, step, startDate, endDate);
    }

    public Capture addCapture(Capture capture){
        return this.captureRepository.save(capture);
    }
}
