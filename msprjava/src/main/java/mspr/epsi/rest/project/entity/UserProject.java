package mspr.epsi.rest.project.entity;

import mspr.epsi.rest.user.entity.UserEntity;

import javax.persistence.*;

@Entity
public class UserProject {

    @Id
    @GeneratedValue(strategy =  GenerationType.AUTO)
    private long id;

    private boolean manager;

    @ManyToOne
    private Project project;

    @ManyToOne
    private UserEntity userEntity;

    public UserProject(){super();}

    public long getId() {
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

    public UserEntity getUser() {
        return userEntity;
    }

    public void setUser(UserEntity userEntity) {
        this.userEntity = userEntity;
    }
}
