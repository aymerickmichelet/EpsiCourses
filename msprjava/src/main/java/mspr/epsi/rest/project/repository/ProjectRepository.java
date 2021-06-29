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

    @Query("SELECT COUNT(DISTINCT p.name) FROM Project p INNER JOIN p.subcontractors s WHERE p.startDate <= :compareDate AND p.endDate >= :compareDate AND p.name = :name AND p.address = :address AND s.id in :subcontractorsId")
    public long countProject(@Param("compareDate") Date compareDate,
                             @Param("name") String name,
                             @Param("address") String address,
                             @Param("subcontractorsId") List<Long> subcontractorsId
                             );

    @Query("SELECT new mspr.epsi.rest.project.entity.CountSubContractorJob(COUNT(j.id), j.name, j.id) FROM Project p INNER JOIN p.subcontractors s INNER JOIN s.job j WHERE p.id = :projectId GROUP BY j.id")
    public List<CountSubContractorJob> countSubcontractorForeachJob(@Param("projectId") long projectId);
}


