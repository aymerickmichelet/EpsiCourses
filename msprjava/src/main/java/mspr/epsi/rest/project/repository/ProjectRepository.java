package mspr.epsi.rest.project.repository;

import mspr.epsi.rest.project.entity.Project;
import mspr.epsi.rest.project.entity.CountSubContractorJob;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.data.repository.query.Param;

import java.util.Date;
import java.util.List;


public interface ProjectRepository extends CrudRepository<Project, Long> {


    @Query("SELECT COUNT(p.startDate) FROM Project p WHERE p.startDate <= :compareDate AND p.endDate >= :compareDate")
    public long countBetweenDate(@Param("compareDate") Date compareDate);


    @Query("SELECT new mspr.epsi.rest.project.entity.CountSubContractorJob(COUNT(j.id), j.name, j.id) FROM Project p INNER JOIN p.subcontractors s INNER JOIN s.job j WHERE p.id = :projectId GROUP BY j.id")
    public List<CountSubContractorJob> countSubcontractorForeachJob(@Param("projectId") long projectId);



}


