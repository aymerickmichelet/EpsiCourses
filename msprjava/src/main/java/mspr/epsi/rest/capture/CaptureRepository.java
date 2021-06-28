package mspr.epsi.rest.capture;

import mspr.epsi.rest.capture.entity.Capture;
import org.springframework.data.repository.CrudRepository;

public interface CaptureRepository  extends CrudRepository<Capture, Long> {
}
