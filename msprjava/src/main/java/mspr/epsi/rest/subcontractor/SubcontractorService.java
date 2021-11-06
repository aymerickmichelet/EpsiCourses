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

    public List<Subcontractor> getListSubcontractorById(List<Long> ids) {

        List<Subcontractor> subcontractors = new ArrayList<>();
        for(Long id: ids) {

            if(this.subcontractorRepository.findById(id).isPresent()) {
                subcontractors.add(this.subcontractorRepository.findById(id).get());
            }
        }
        return subcontractors;
    }


}
