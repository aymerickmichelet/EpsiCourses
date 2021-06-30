package mspr.epsi.rest.auth;

import mspr.epsi.rest.auth.dto.UserAuthDto;
import mspr.epsi.rest.auth.response.AuthUserResponse;
import mspr.epsi.rest.user.dto.LoginDto;
import mspr.epsi.rest.user.dto.CreateUserDto;
import mspr.epsi.rest.user.UserService;
import mspr.epsi.rest.user.entity.UserEntity;
import mspr.epsi.rest.user.repository.UserRepository;
import mspr.epsi.rest.user.response.UserResponse;
import mspr.epsi.rest.utils.Response;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestHeader;
import org.springframework.web.bind.annotation.RestController;


@RestController
public class AuthController {

    private UserService userService;
    private JwtTokenService jwtTokenService;

    public AuthController(UserRepository userRepository) {
        this.userService = new UserService(userRepository);
        this.jwtTokenService = new JwtTokenService();
    }

    private String getErrorMessage(Exception e){
        if (e.getMessage().equalsIgnoreCase("Wrong User/password") ||
                e.getMessage().equalsIgnoreCase("User can't retry to connect") ||
                e.getMessage().equalsIgnoreCase("Passwords is not identical") ||
                e.getMessage().equalsIgnoreCase("User doesn't exist"))
            return e.getMessage();
        else
            return "An error occurred: " + e.getMessage();
    }

    @PostMapping("/signup")
    public ResponseEntity<Response> signUp(@RequestBody  CreateUserDto userDto) {
        try {
            UserEntity user = this.userService.saveUser(userDto);
            UserResponse response = new UserResponse(HttpStatus.CREATED.value(), "User create", user);
            return new ResponseEntity(response, HttpStatus.CREATED);
        } catch(Exception e) {
            Response response = new Response(HttpStatus.BAD_REQUEST.value(), "Error create user");
            return new ResponseEntity(response, HttpStatus.BAD_REQUEST);
        }
    }

    @PostMapping("/signin")
    public ResponseEntity<Response> signIn(@RequestBody LoginDto loginDto) {

        try {
            UserEntity user = this.userService.signIn(loginDto);
            UserAuthDto userAuth = new UserAuthDto(user.getId(), user.getUserId(), user.getRole());

            String token = this.jwtTokenService.createToken(userAuth);

            AuthUserResponse response = new AuthUserResponse(HttpStatus.ACCEPTED.value(), "Sign in OK", user, token);
            return new ResponseEntity(response, HttpStatus.ACCEPTED);
        }catch(Exception e){
            Response response = new Response(HttpStatus.UNAUTHORIZED.value(), getErrorMessage(e));
            return new ResponseEntity(response, HttpStatus.UNAUTHORIZED);
        }
    }

    @PostMapping("/current-user")
    public UserAuthDto getCurrentUser(@RequestHeader HttpHeaders headers) {

        try {
            String token = headers.getFirst(HttpHeaders.AUTHORIZATION);
            UserAuthDto userAuth = this.jwtTokenService.verifJwtToken(token);
            System.out.println(token);
            return userAuth;

        }catch (Exception e){
            System.out.println(e.getMessage());
            return null;
        }




    }

    @PostMapping("/password/change")
    public ResponseEntity<Response> changePassword(@RequestBody LoginDto loginDto){
        try {
            UserEntity user = this.userService.changePassword(loginDto);
            UserResponse response = new UserResponse(HttpStatus.ACCEPTED.value(), "Password has been changed", user);
            return new ResponseEntity(response, HttpStatus.ACCEPTED);
        }catch(Exception e){
            Response response = new Response(HttpStatus.UNAUTHORIZED.value(), getErrorMessage(e));
            return new ResponseEntity(response, HttpStatus.UNAUTHORIZED);
        }
    }


}
