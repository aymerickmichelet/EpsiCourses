package mspr.epsi.rest.capture.dto;

import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.project.entity.Project;
import mspr.epsi.rest.subcontractor.entity.Subcontractor;
import mspr.epsi.rest.utils.DateUtils;

import java.util.Date;
import java.util.List;

public class AddCaptureDto {

    private String path;

    private String incident;

    private String step;

    private Date date;

    private float latitude;

    private float longitude;

    private long projectId;

    private List<Long> subcontractorsId;

    public AddCaptureDto(String path, String date, String incident, String step, float latitude, float longitude, long projectId, List<Long> subcontractorsId) {
        this.path = path;
        this.incident = incident;
        this.step = step;
        this.date = DateUtils.getDate(date);
        this.latitude = latitude;
        this.longitude = longitude;
        this.projectId = projectId;
        this.subcontractorsId = subcontractorsId;
    }

    public Capture getCapture(Project project, List<Subcontractor> subcontractors) {
        return new Capture(
                       this.path,
                       this.date,
                       this.incident,
                       this.latitude,
                       this.longitude,
                       this.step,
                       project,
                       subcontractors
                );
    }


    public String getPath() {
        return path;
    }

    public void setPath(String path) {
        this.path = path;
    }

    public String getIncident() {
        return incident;
    }

    public void setIncident(String incident) {
        this.incident = incident;
    }

    public String getStep() {
        return step;
    }

    public void setStep(String step) {
        this.step = step;
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

    public long getProjectId() {
        return projectId;
    }

    public void setProjectId(long projectId) {
        this.projectId = projectId;
    }

    public List<Long> getSubcontractorsId() {
        return subcontractorsId;
    }

    public void setSubcontractorsId(List<Long> subcontractorsId) {
        this.subcontractorsId = subcontractorsId;
    }
}
