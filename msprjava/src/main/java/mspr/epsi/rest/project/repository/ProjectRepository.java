package mspr.epsi.rest.project.repository;

import mspr.epsi.rest.project.entity.Project;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.data.repository.query.Param;

import java.util.Date;

public interface ProjectRepository extends CrudRepository<Project, Long> {


    @Query("SELECT COUNT(p.startDate) FROM Project p WHERE p.startDate <= :compareDate AND p.endDate >= :compareDate")
    public long countBetweenDate(@Param("compareDate") Date compareDate);

}
