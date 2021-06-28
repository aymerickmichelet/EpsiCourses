package mspr.epsi.rest.subcontractor.entity;

import com.fasterxml.jackson.annotation.JsonIgnore;
import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.project.entity.Project;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity
public class Subcontractor {

    @Id
    @GeneratedValue(strategy =  GenerationType.AUTO)
    private long id;

    private String name;

    @ManyToOne(cascade = {CascadeType.PERSIST, CascadeType.MERGE})
    private Job job;

    @ManyToMany
    @JsonIgnore
    private List<Capture> captures;

    @ManyToMany(cascade = {CascadeType.PERSIST, CascadeType.MERGE, CascadeType.REMOVE})
    @JsonIgnore
    private List<Project> projects;

    public Subcontractor() { super(); }

    public Subcontractor(String name, Job job) {
        this.name = name;
        this.job = job;
        this.captures = new ArrayList<>();
        this.projects = new ArrayList<>();
    }

    public long getId() {
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
