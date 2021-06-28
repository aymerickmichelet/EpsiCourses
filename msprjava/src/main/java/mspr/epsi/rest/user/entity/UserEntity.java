package mspr.epsi.rest.user.entity;

import mspr.epsi.rest.project.entity.UserProject;
import mspr.epsi.rest.request.entity.Request;

import javax.persistence.*;
import java.util.Date;
import java.util.List;

@Entity
public class UserEntity {

    @Id
    @GeneratedValue(strategy =  GenerationType.AUTO)
    private int id;
    private String userId;
    private String lastName;
    private String firstName;
    private String role;
    private String password;
    private int tryPassword;
    private Date updatePassword;

    @OneToMany
    private List<UserProject> userProjects;

    @OneToMany
    private List<Request> requests;

    public UserEntity(){super();}

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getUserId() {
        return userId;
    }

    public void setUserId(String userId) {
        this.userId = userId;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getRole() {
        return role;
    }

    public void setRole(String role) {
        this.role = role;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public int getTryPassword() {
        return tryPassword;
    }

    public void setTryPassword(int tryPassword) {
        this.tryPassword = tryPassword;
    }

    public Date getUpdatePassword() {
        return updatePassword;
    }

    public void setUpdatePassword(Date updatePassword) {
        this.updatePassword = updatePassword;
    }

    public List<UserProject> getUserProjects() {
        return userProjects;
    }

    public void setUserProjects(List<UserProject> userProjects) {
        this.userProjects = userProjects;
    }

    public List<Request> getRequests() {
        return requests;
    }

    public void setRequests(List<Request> requests) {
        this.requests = requests;
    }
}
