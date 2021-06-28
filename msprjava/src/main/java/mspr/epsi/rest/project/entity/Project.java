package mspr.epsi.rest.project.entity;

import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.request.entity.Request;
import mspr.epsi.rest.subcontractor.entity.Subcontractor;

import javax.persistence.*;
import java.util.Date;
import java.util.List;

@Entity
public class Project {

    @Id
    @GeneratedValue(strategy =  GenerationType.AUTO)
    private long id;

    private String name;

    @Temporal(TemporalType.DATE)
    private Date startDate;

    @Temporal(TemporalType.DATE)
    private Date endDate;

    private String address;

    @OneToMany
    private List<UserProject> userProjects;

    @OneToMany
    private List<Request> request;

    @OneToMany
    private List<Capture> captures;

    @ManyToMany
    private List<Subcontractor> subcontractors;


    public Project() { super();}

    public Project(String name, Date start, Date end, String address, List<Subcontractor> subcontractors) {
        this.name = name;
        this.startDate = start;
        this.endDate = end;
        this.address = address;
        this.subcontractors = subcontractors;
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

    public Date getStartDate() {
        return startDate;
    }

    public void setStartDate(Date start) {
        this.startDate = start;
    }

    public Date getEndDate() {
        return endDate;
    }
    public void setEndDate(Date end) {
        this.endDate = end;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
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
