package mspr.epsi.rest.project;

import mspr.epsi.rest.example.entity.Example;
import mspr.epsi.rest.project.entity.Project;
import mspr.epsi.rest.project.repository.ProjectRepository;
import mspr.epsi.rest.subcontractor.entity.Subcontractor;
import mspr.epsi.rest.utils.DateUtils;

import java.text.ParseException;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class ProjectService {
    private ProjectRepository projectRepository;

    public ProjectService(ProjectRepository projectRepository) {
        this.projectRepository = projectRepository;

        Date start = DateUtils.getDate("2020-06-01");
        Date end = DateUtils.getDate("2020-12-01");

        Date start2 = DateUtils.getDate("2019-06-01");
        Date end2 = DateUtils.getDate("2019-12-01");

        List<Subcontractor> subcontractors = new ArrayList<Subcontractor>();

        this.projectRepository.save(new Project("Project 1", start, end, "82 rue Julien Marfella Puteaux 92151" ,
                subcontractors));
        this.projectRepository.save(new Project("Project 2", start, end, "82 rue Julien Marfella Puteaux 92151" ,
                subcontractors));
        this.projectRepository.save(new Project("Project 3", start2, end2, "82 rue Julien Marfella Puteaux 92151" ,
                subcontractors));
    }

    public List<Project> findAll() {
        List<Project> projects = new ArrayList<Project>();
        this.projectRepository.findAll().forEach(projects::add);
        return projects;
    }

    public long findLength(Date dateCompare) {
       long length = this.projectRepository.countBetweenDate(dateCompare);
       return length;
    }

}
