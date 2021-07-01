package mspr.epsi.rest.auth;

import mspr.epsi.rest.auth.dto.UserAuthDto;
import mspr.epsi.rest.auth.response.AuthUserResponse;
import mspr.epsi.rest.user.dto.LoginDto;
import mspr.epsi.rest.user.dto.CreateUserDto;
import mspr.epsi.rest.user.UserService;
import mspr.epsi.rest.user.entity.UserEntity;
import mspr.epsi.rest.user.repository.UserRepository;
import mspr.epsi.rest.user.response.UserResponse;
import mspr.epsi.rest.utils.DateUtils;
import mspr.epsi.rest.utils.Response;
import org.apache.catalina.User;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;


@RestController
public class AuthController {

    private UserService userService;
    private  AuthService authService;
    private JwtTokenService jwtTokenService;

    public AuthController(UserRepository userRepository) {
        this.userService = new UserService(userRepository);
        this.authService = new AuthService(userRepository);
        this.jwtTokenService = new JwtTokenService();
    }

    private String getErrorMessage(Exception e){
        if (e.getMessage().equalsIgnoreCase("Wrong User/password") ||
                e.getMessage().equalsIgnoreCase("User can't retry to connect") ||
                e.getMessage().equalsIgnoreCase("Passwords is not identical") ||
                e.getMessage().equalsIgnoreCase("User doesn't exist") ||
                e.getMessage().equalsIgnoreCase("Not connected"))
            return e.getMessage();
        else
            return "An error occurred: " + e.getMessage();
    }

    @PostMapping("/signup")
    public ResponseEntity<Response> signUp(@RequestBody  CreateUserDto userDto, @RequestHeader HttpHeaders headers) {
        try {
            String token = headers.getFirst(HttpHeaders.AUTHORIZATION);
            this.authService.authUserRole(token, "admin");
            UserEntity user = this.userService.saveUser(userDto);
            UserResponse response = new UserResponse(HttpStatus.CREATED.value(), "User create", user);
            return new ResponseEntity(response, HttpStatus.CREATED);
        } catch(Exception e) {
            if(e.getMessage() == "Not connected") {
                return this.authService.errorAuth();
            }
            Response response = new Response(HttpStatus.BAD_REQUEST.value(), "Error create user");
            return new ResponseEntity(response, HttpStatus.BAD_REQUEST);
        }
    }

    @PostMapping("/signin")
    public ResponseEntity<Response> signIn(@RequestBody LoginDto loginDto) {

        try {
            UserEntity user = this.userService.signIn(loginDto);
            UserAuthDto userAuth = new UserAuthDto(user.getId(), user.getUserId(), user.getRole());

            String msg = "Sign in OK";
            if(DateUtils.blockPassword(user.getUpdatePassword())) {
                throw new Exception("The time to change the password was too long. ");
            }
            if(user.getUserId().equals(loginDto.getPassword())) {
                msg = "Change password because it has never been changed";
            }
            else if(DateUtils.compareDatePassword(user.getUpdatePassword())) {
                msg = "The password has not been changed since 2 months";
            }




            String token = this.jwtTokenService.createToken(userAuth);

            AuthUserResponse response = new AuthUserResponse(HttpStatus.ACCEPTED.value(), msg, user, token);
            return new ResponseEntity(response, HttpStatus.ACCEPTED);
        }catch(Exception e){
            Response response = new Response(HttpStatus.UNAUTHORIZED.value(), getErrorMessage(e));
            return new ResponseEntity(response, HttpStatus.UNAUTHORIZED);
        }
    }

    @GetMapping("/current-user")
    public ResponseEntity<Response> getCurrentUser(@RequestHeader HttpHeaders headers) {
        try {
            String token = headers.getFirst(HttpHeaders.AUTHORIZATION);
            UserEntity user = this.authService.authUser(token);

            UserResponse response = new UserResponse(HttpStatus.OK.value(), "User is connected", user);
            return new ResponseEntity(response, HttpStatus.OK);
        }
        catch(Exception e) {
            System.out.println(e.getMessage());
            return this.authService.errorAuth();
        }

    }

    @PutMapping("/password-change")
    public ResponseEntity<Response> changePassword(@RequestBody LoginDto loginDto, @RequestHeader HttpHeaders headers){
        try {
            String token = headers.getFirst(HttpHeaders.AUTHORIZATION);
            UserEntity authUser = this.authService.authUser(token);
            if(loginDto.getUserId() == authUser.getUserId()) {
                throw new Exception("Not connected");
            }
            authUser = this.userService.changePassword(loginDto);
            UserResponse response = new UserResponse(HttpStatus.ACCEPTED.value(), "Password has been changed", authUser);
            return new ResponseEntity(response, HttpStatus.ACCEPTED);
        }catch(Exception e){
            if(e.getMessage() == "Not connected") {
                return this.authService.errorAuth();
            }
            Response response = new Response(HttpStatus.UNAUTHORIZED.value(), getErrorMessage(e));
            return new ResponseEntity(response, HttpStatus.UNAUTHORIZED);
        }
    }


}
