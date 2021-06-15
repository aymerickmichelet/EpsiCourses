package mspr.epsi.rest.subcontractor.entity;

import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.project.entity.Project;

import javax.persistence.*;
import java.util.List;

@Entity
public class Subcontractor {

    @Id
    @GeneratedValue(strategy =  GenerationType.AUTO)
    private int id;

    private String name;

    @ManyToOne
    private Job job;

    @ManyToMany
    private List<Capture> captures;

    @ManyToMany
    private List<Project> projects;

    public Subcontractor() { super(); }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Job getJob() {
        return job;
    }

    public void setJob(Job job) {
        this.job = job;
    }

    public List<Capture> getCaptures() {
        return captures;
    }

    public void setCaptures(List<Capture> captures) {
        this.captures = captures;
    }

    public List<Project> getProjects() {
        return projects;
    }

    public void setProjects(List<Project> projects) {
        this.projects = projects;
    }
}
