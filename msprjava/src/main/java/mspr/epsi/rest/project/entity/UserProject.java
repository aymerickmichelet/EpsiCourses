package mspr.epsi.rest.project.entity;
import com.fasterxml.jackson.annotation.JsonIgnore;
import mspr.epsi.rest.user.entity.UserEntity;

import javax.persistence.*;

@Entity
public class UserProject {

    @Id
    @GeneratedValue(strategy =  GenerationType.AUTO)
    private long id;

    private boolean manager;

    @ManyToOne
    @JsonIgnore
    private Project project;

    @ManyToOne
    @JsonIgnore
    private UserEntity user;

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
        return user;
    }

    public void setUser(UserEntity userEntity) {
        this.user = userEntity;
    }
}
