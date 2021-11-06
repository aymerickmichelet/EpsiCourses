package mspr.epsi.rest.auth.dto;

public class UserAuthDto {

    private long id;
    private String userId;
    private String role;

    public UserAuthDto(long id, String userId, String role) {
        this.id = id;
        this.userId = userId;
        this.role = role;
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getUserId() {
        return userId;
    }

    public void setUserId(String userId) {
        this.userId = userId;
    }

    public String getRole() {
        return role;
    }

    public void setRole(String role) {
        this.role = role;
    }
}
