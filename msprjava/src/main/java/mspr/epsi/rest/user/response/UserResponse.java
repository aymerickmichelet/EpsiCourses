package mspr.epsi.rest.user.response;

import mspr.epsi.rest.user.entity.UserEntity;
import mspr.epsi.rest.utils.Response;

public class UserResponse extends Response {

    public UserEntity user;

    public UserResponse(int status, String msg, UserEntity user) {
        super(status, msg);
        this.user = user;
    }

    public UserEntity getUser() {
        return user;
    }

    public void setUser(UserEntity user) {
        this.user = user;
    }
}
