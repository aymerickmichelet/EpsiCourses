package mspr.epsi.rest.capture.entity;

import mspr.epsi.rest.project.entity.Project;
import mspr.epsi.rest.subcontractor.entity.Subcontractor;

import javax.persistence.*;
import java.util.Date;
import java.util.List;

@Entity
public class Capture {

    @Id
    @GeneratedValue(strategy =  GenerationType.AUTO)
    private long id;

    private String path;

    private String incident;

    private Date date;

    private float latitude;

    private float longitude;

    @ManyToOne
    @JsonIgnore
    private Project project;

    @ManyToMany
    @JsonIgnore
    private List<Subcontractor> subcontractors;

    public Capture() { super(); }


    public Capture(String path, Date date, String incident, float latitude, float longitude, List<Subcontractor> subcontractors) {
        this.path = path;
        this.incident = incident;
        this.date = date;
        this.latitude = latitude;
        this.longitude = longitude;
        this.subcontractors = subcontractors;
    }



    public Capture(String path, Date date,  String incident, float latitude, float longitude, Project project, List<Subcontractor> subcontractors) {
        this.path = path;
        this.date = date;
        this.incident = incident;
        this.latitude = latitude;
        this.longitude = longitude;
        this.project = project;
        this.subcontractors = subcontractors;
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getPath() {
        return path;
    }

    public void setPath(String path) {
        this.path = path;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public float getLatitude() {
        return latitude;
    }

    public void setLatitude(float latitude) {
        this.latitude = latitude;
    }

    public float getLongitude() {
        return longitude;
    }

    public void setLongitude(float longitude) {
        this.longitude = longitude;
    }

    public Project getProject() {
        return project;
    }

    public void setProject(Project project) {
        this.project = project;
    }

    public List<Subcontractor> getSubcontractors() {
        return subcontractors;
    }

    public void setSubcontractors(List<Subcontractor> subcontractors) {
        this.subcontractors = subcontractors;
    }
}
