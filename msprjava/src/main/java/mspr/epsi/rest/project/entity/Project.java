package mspr.epsi.rest.project.entity;

import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.request.entity.Request;
import mspr.epsi.rest.subcontractor.entity.Subcontractor;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

@Entity
public class Project {

    @Id
    @GeneratedValue(strategy =  GenerationType.AUTO)
    private int id;

    private String name;

    private Date date;

    @OneToMany
    private List<UserProject> userProjects;

    @OneToMany
    private List<Request> request;

    @OneToMany
    private List<Capture> captures;

    @ManyToMany
    private List<Subcontractor> subcontractors;


    public Project() { super();}

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

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public List<UserProject> getUserProject() {
        return userProjects;
    }

    public void setUserProjects(List<UserProject> userProjects) {
        this.userProjects = userProjects;
    }

    public List<UserProject> getUserProjects() {
        return userProjects;
    }

    public List<Request> getRequest() {
        return request;
    }

    public void setRequest(List<Request> request) {
        this.request = request;
    }

    public List<Capture> getCaptures() {
        return captures;
    }

    public void setCaptures(List<Capture> captures) {
        this.captures = captures;
    }

    public List<Subcontractor> getSubcontractors() {
        return subcontractors;
    }

    public void setSubcontractors(List<Subcontractor> subcontractors) {
        this.subcontractors = subcontractors;
    }
}
