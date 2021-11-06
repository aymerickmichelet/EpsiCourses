package mspr.epsi.rest.auth.response;

import mspr.epsi.rest.user.entity.UserEntity;
import mspr.epsi.rest.user.response.UserResponse;

public class AuthUserResponse extends UserResponse {

    String token;

    public AuthUserResponse(int status, String msg, UserEntity user, String token) {
        super(status, msg, user);
        this.token = token;
    }

    public String getToken() {
        return token;
    }

    public void setToken(String token) {
        this.token = token;
    }
}
