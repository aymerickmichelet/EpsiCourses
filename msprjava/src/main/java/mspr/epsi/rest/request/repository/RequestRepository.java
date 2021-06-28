package mspr.epsi.rest.request.repository;

import mspr.epsi.rest.request.entity.Request;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.data.repository.query.Param;

import java.util.Date;
import java.util.List;

public interface RequestRepository extends CrudRepository<Request, Long> {

    @Query("SELECT r FROM Request r WHERE r.date >= :dateLimit")

    List<Request> getRequestsAfterDate(@Param("dateLimit") Date dateLimit);

}
