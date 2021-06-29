package mspr.epsi.rest.capture;

import mspr.epsi.rest.capture.entity.Capture;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.data.repository.query.Param;

import java.util.Date;
import java.util.List;

public interface CaptureRepository  extends CrudRepository<Capture, Long> {

    @Query("SELECT c FROM Capture c WHERE c.project.id = :projectId")
    public List<Capture> getCaptureByProjectId(@Param("projectId") long projectId);

    @Query("SELECT c FROM Capture c WHERE c.project.id = :projectId AND c.incident = :incident AND c.latitude = :lat AND c.longitude = :longs and c.date = :date")
    public List<Capture> getCapturesIdenticals(@Param("projectId") long projectId,
                                             @Param("incident") String incident,
                                             @Param("lat") float lat,
                                             @Param("longs") float longs,
                                            @Param("date") Date date
                                             );
}
