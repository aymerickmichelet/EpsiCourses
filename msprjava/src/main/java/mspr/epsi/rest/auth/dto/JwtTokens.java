package mspr.epsi.rest.auth.dto;

public class JwtTokens {

    public String token;
    public String refreshToken;

    public JwtTokens(String token, String refreshToken) {
        this.token = token;
        this.refreshToken = refreshToken;
    }

}
