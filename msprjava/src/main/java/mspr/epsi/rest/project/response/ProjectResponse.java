package mspr.epsi.rest.project.response;

import mspr.epsi.rest.project.entity.Project;
import mspr.epsi.rest.utils.Response;

public class ProjectResponse extends Response {

    private Project project;

    public ProjectResponse(int status, String msg, Project project) {
        super(status, msg);
        this.project = project;
    }

    public Project getProject() {
        return project;
    }

    public void setProject(Project project) {
        this.project = project;
    }
}
