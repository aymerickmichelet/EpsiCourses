package mspr.epsi.rest.project.entity;

import mspr.epsi.rest.user.entity.User;

import javax.persistence.*;

@Entity
public class UserProject {

    @Id
    @GeneratedValue(strategy =  GenerationType.AUTO)
    private int id;

    private boolean manager;

    @ManyToOne
    private Project project;

    @ManyToOne
    private User user;

    public UserProject(){super();}

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public boolean isManager() {
        return manager;
    }

    public void setManager(boolean manager) {
        this.manager = manager;
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
