package mspr.epsi.rest.subcontractor;

import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.subcontractor.entity.Job;
import mspr.epsi.rest.subcontractor.entity.Subcontractor;
import mspr.epsi.rest.subcontractor.repository.SubcontractorRepository;
import mspr.epsi.rest.utils.DateUtils;

import java.util.*;

public class SubcontractorService {
    private SubcontractorRepository subcontractorRepository;

    public SubcontractorService(SubcontractorRepository subcontractorRepository){
        this.subcontractorRepository = subcontractorRepository;
    }

    public List<Subcontractor> getListSubcontractor() {

       List<Subcontractor> subcontractors = new ArrayList<>();
        for(int i = 0; i < 5; i++) {
            Job job = new Job("job" + i);
            Subcontractor subconstractor = new Subcontractor("sous-traitant" + i, job);
            subcontractors.add(this.subcontractorRepository.save(subconstractor));

        }
        return subcontractors;

    }




    public List<Capture> getListFictiveCapture() {
        Date date = DateUtils.getDate("2021-06-28");
        List<Subcontractor> subcontractors = new ArrayList<Subcontractor>();

        List<Capture> captures = new ArrayList<>();

        for(int i = 0; i < 5; i++) {
            captures.add(new Capture("https://perdu.com", date,"Incident",  44.63f, (float) -1.08,
                    subcontractors));

        }
        return captures;
    }


}
