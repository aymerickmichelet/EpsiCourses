package mspr.epsi.rest.auth;

import mspr.epsi.rest.auth.dto.UserAuthDto;
import mspr.epsi.rest.user.UserService;
import mspr.epsi.rest.user.entity.UserEntity;
import mspr.epsi.rest.user.repository.UserRepository;
import mspr.epsi.rest.utils.Response;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;

import java.lang.reflect.Executable;
import java.util.List;

public class AuthService {

    private UserService userService;
    private JwtTokenService jwtTokenService;

    public AuthService(UserRepository userRepository) {
        this.userService = new UserService(userRepository);
        this.jwtTokenService = new JwtTokenService();
    }

    public UserEntity authUser(String token) throws Exception {
        try {
            UserAuthDto userAuth = this.jwtTokenService.verifJwtToken(token);
            UserEntity user = this.userService.findById(userAuth.getId());
            if(user != null) {
                return user;
            }
            throw new Exception("Not connected");
        }
       catch(Exception e) {
            throw new Exception("Not connected");
        }
    }

    public UserEntity authUserRole(String token, String role) throws Exception {
        try {
            UserAuthDto userAuth = this.jwtTokenService.verifJwtToken(token);
            UserEntity user = this.userService.findById(userAuth.getId());
            if(user != null) {
                if(role.equals(user.getRole())) {
                    return user;
                }
            }
            throw new Exception("Not connected");
        }
        catch(Exception e) {
            throw new Exception("Not connected");
        }
    }



    public UserEntity authUserRole(String token, List<String> roles) throws Exception {
        try {
            UserAuthDto userAuth = this.jwtTokenService.verifJwtToken(token);
            UserEntity user = this.userService.findById(userAuth.getId());
            if(user != null) {
                for(String role: roles) {
                    if(role.equals(user.getRole())) {
                        return user;
                    }
                }
            }
            throw new Exception("Not connected");
        }
        catch(Exception e) {
            throw new Exception("Not connected");
        }
    }

    public ResponseEntity<Response> errorAuth() {
        Response response = new Response(HttpStatus.UNAUTHORIZED.value(), "Unauthenticated request");
        return new ResponseEntity(response, HttpStatus.UNAUTHORIZED);
    }


}
