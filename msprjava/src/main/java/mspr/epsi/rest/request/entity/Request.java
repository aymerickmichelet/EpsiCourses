package mspr.epsi.rest.request.entity;

import mspr.epsi.rest.project.entity.Project;
import mspr.epsi.rest.user.entity.User;

import javax.persistence.*;
import java.util.Date;

@Entity
public class Request {

    @Id
    @GeneratedValue(strategy =  GenerationType.AUTO)
    private int id;
    private Date date;

    @ManyToOne
    private Project project;

    @ManyToOne
    private User user;

    public Request() { super(); }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public Project getProject() {
        return project;
    }

    public void setProject(Project project) {
        this.project = project;
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }
}
