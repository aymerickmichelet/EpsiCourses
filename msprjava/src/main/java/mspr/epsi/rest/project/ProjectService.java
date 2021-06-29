package mspr.epsi.rest.project;

import mspr.epsi.rest.capture.CaptureRepository;
import mspr.epsi.rest.capture.CaptureService;
import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.project.entity.Project;
import mspr.epsi.rest.project.repository.ProjectRepository;
import mspr.epsi.rest.project.entity.CountSubContractorJob;
import mspr.epsi.rest.subcontractor.SubcontractorService;
import mspr.epsi.rest.subcontractor.entity.Subcontractor;
import mspr.epsi.rest.subcontractor.repository.SubcontractorRepository;
import mspr.epsi.rest.utils.DateUtils;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class ProjectService {
    private ProjectRepository projectRepository;
    private CaptureService captureService;
    private SubcontractorService subcontractorService;

    public ProjectService(ProjectRepository projectRepository, CaptureRepository captureRepository,
                          SubcontractorRepository subcontractorRepository) {
        this.projectRepository = projectRepository;
        this.captureService = new CaptureService(captureRepository);
        this.subcontractorService = new SubcontractorService(subcontractorRepository);

    }

    public List<Project> addProjects() {

        // Création des dates de début et de fin
        Date start = DateUtils.getDate("2020-06-01");
        Date end = DateUtils.getDate("2020-12-01");

        Date start2 = DateUtils.getDate("2019-06-01");
        Date end2 = DateUtils.getDate("2019-12-01");


        //Get catpure and sous-traitants
        List<Capture> captures = this.captureService.getListFictiveCapture();
        List<Capture> captures2 = this.captureService.getListFictiveCapture();
        List<Capture> captures3 = this.captureService.getListFictiveCapture();
        List<Subcontractor> subcontractors = this.subcontractorService.getListSubcontractor();


        // Création des projets
        List<Project> projects = new ArrayList<Project>();

        Project project =  this.projectRepository.save(new Project("Project 1", start, end,
                "81 rue Julien Marfella Puteaux 92151" ,
                subcontractors, captures));
        Project project2 = this.projectRepository.save(new Project("Project 2", start, end,
                "82 rue Julien Marfella Puteaux 92151" ,
                subcontractors, captures2));
        Project project3 = this.projectRepository.save(new Project("Project 3", start2, end2,
                "83 rue Julien Marfella Puteaux 92151" ,
                subcontractors, captures3));

        projects.add(project);
        projects.add(project2);
        projects.add(project3);

        return projects;
    }

    public List<Project> findAll() {
        List<Project> projects = new ArrayList<Project>();
        this.projectRepository.findAll().forEach(projects::add);
        return projects;
    }

    public Project findById(long idProject) throws Exception {

        if(this.projectRepository.findById(idProject).isPresent()){
            return this.projectRepository.findById(idProject).get();
        }
        throw new Exception("Project not found");
    }

    public long findLength(Date dateCompare) {
        return this.projectRepository.countBetweenDate(dateCompare);
    }

    public long findLength(Date dateCompare, String name, String address, List<Long> subcontractorsId) {
        return this.projectRepository.countProject(dateCompare, name, address, subcontractorsId);
    }


    public List<CountSubContractorJob>  findLengthSub(long projectId) {
        return this.projectRepository.countSubcontractorForeachJob(projectId);
    }

}
