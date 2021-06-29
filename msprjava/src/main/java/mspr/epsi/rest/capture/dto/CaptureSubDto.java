package mspr.epsi.rest.capture.dto;

import com.fasterxml.jackson.annotation.JsonIgnore;
import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.project.entity.Project;
import mspr.epsi.rest.subcontractor.entity.Subcontractor;

import javax.persistence.*;
import java.util.Date;
import java.util.List;

public class CaptureSubDto {

    @GeneratedValue(strategy =  GenerationType.AUTO)
    private long id;

    private String path;

    private String incident;

    private Date date;

    private float latitude;

    private float longitude;

    private String step;

    @JsonIgnore
    private Project project;

    private List<Subcontractor> subcontractors;

    public CaptureSubDto() { super(); }

    public CaptureSubDto(Capture capture) {
        this.id = capture.getId();
        this.path = capture.getPath();
        this.incident = capture.getIncident();
        this.date = capture.getDate();
        this.latitude = capture.getLatitude();
        this.longitude = capture.getLongitude();
        this.step = capture.getStep();

        for(Subcontractor sub: capture.getSubcontractors()) {
            System.out.println(sub.getName());
        }

        this.subcontractors = capture.getSubcontractors();
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

    public String getIncident() {
        return incident;
    }

    public void setIncident(String incident) {
        this.incident = incident;
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

    public String getStep() {
        return step;
    }

    public void setStep(String step) {
        this.step = step;
    }

}
