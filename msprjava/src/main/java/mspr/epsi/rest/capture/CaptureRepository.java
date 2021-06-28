package mspr.epsi.rest.capture;

import mspr.epsi.rest.capture.entity.Capture;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;

public interface CaptureRepository  extends CrudRepository<Capture, Long> {

    @Query("SELECT c from Capture C where C.project.id = :projectId")
    public List<Capture >getCaptureByProjectId();
}
