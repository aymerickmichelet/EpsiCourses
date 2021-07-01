package mspr.epsi.rest.auth;

import mspr.epsi.rest.auth.dto.JwtTokens;
import mspr.epsi.rest.auth.dto.UserAuthDto;
import mspr.epsi.rest.user.UserService;
import mspr.epsi.rest.user.repository.UserRepository;

import io.jsonwebtoken.*;
import io.jsonwebtoken.impl.DefaultClaims;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.authority.AuthorityUtils;
import org.springframework.security.core.userdetails.UserDetailsService;

import java.util.Calendar;
import java.util.Date;

public class JwtTokenService {

    private static final String USER_SECRET = "userSecret";
    private String secret = "secretqeighosursefijrzEFGHRSQUDOIRJEFfpighrsqoygougiJFRZUIEIOTYMHRGUIFJROIUETGHOROuiromg";

    public JwtTokenService() {
    }

    public String createTokens(UserAuthDto userAuth) {
        return this.createToken(userAuth);
    }

    public String createToken(UserAuthDto userAuth) {
        return Jwts.builder().setClaims(this.buildUserClaims(userAuth))
                .setExpiration(this.getTokenExpirationDate())
                .setIssuedAt(new Date())
                .signWith(SignatureAlgorithm.HS512, secret)
                .compact();
    }

    public UserAuthDto verifJwtToken(String token) throws Exception {
        try {
            Claims body =  Jwts.parserBuilder().setSigningKey(secret).build().parseClaimsJws(token).getBody();

            Long id = Long.valueOf((Integer) body.get("id"));
            String userId = (String) body.get("userId");
            String role = (String) body.get("role");

            return new UserAuthDto(id, userId, role);
        } catch(Exception e) {
            throw new Exception("JWT NOT GOOD: " + e.getMessage());
        }


    }

    public Jws<Claims> validateJwtToken(String token) {
        return Jwts.parser().setSigningKey(secret).parseClaimsJws(token);
    }


    private Date getTokenExpirationDate() {
        Calendar calendar = Calendar.getInstance();
        calendar.add(Calendar.DATE, 1);

        return calendar.getTime();
    }

    private Claims buildUserClaims(UserAuthDto user) {
        Claims claims = new DefaultClaims();

        claims.setSubject(String.valueOf(user.getId()));
        claims.put("id", user.getId());
        claims.put("userId", user.getUserId());
        claims.put("role", user.getRole());

        return claims;
    }
}
