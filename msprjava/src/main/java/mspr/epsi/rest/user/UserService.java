package mspr.epsi.rest.user;

import mspr.epsi.rest.auth.dto.UserAuthDto;
import mspr.epsi.rest.user.dto.CreateUserDto;
import mspr.epsi.rest.user.dto.LoginDto;
import mspr.epsi.rest.user.entity.UserEntity;
import mspr.epsi.rest.user.repository.UserRepository;
import mspr.epsi.rest.utils.DateUtils;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Service;

import java.text.SimpleDateFormat;
import java.util.Date;

public class UserService {

    private UserRepository userRepository;
    private int tryPasswordMax = 3;


    public UserService(UserRepository userRepository){
        this.userRepository = userRepository;
    }

    public BCryptPasswordEncoder bCryptPasswordEncoder() {
        return new BCryptPasswordEncoder();
    }

    public UserEntity saveUser(CreateUserDto userDto) throws Exception {

        if(!userDto.getRole().equals("internal") && !userDto.getRole().equals("construction")
                && !userDto.getRole().equals("admin")) {

            throw new Exception("Error role");
        }

       String userId = this.createUserId(userDto);

        userDto.setPassword(bCryptPasswordEncoder().encode(userId));

        UserEntity user = new UserEntity(userId, userDto.getLastName(), userDto.getFirstName(), userDto.getRole(),
                userDto.getPassword());

        return this.createUser(user);
    }

    public String createUserId(CreateUserDto userDto) {
        Date dateNows = DateUtils.getDate("");
        SimpleDateFormat df = new SimpleDateFormat("yyyy");
        String year = df.format(dateNows);

        String userId = userDto.getRole().toUpperCase().charAt(0) + year + "_" +
                userDto.getFirstName().toUpperCase().charAt(0) +  userDto.getFirstName().toUpperCase().charAt(1) +
                userDto.getLastName().toUpperCase().charAt(0) +  userDto.getLastName().toUpperCase().charAt(1);

       UserEntity userExit = this.findByUserId(userId);

       if(userExit == null) {
           return userId;
       }

       return this.incrementUserId(userId, 1);
    }

    public String incrementUserId(String userId, int number) {
        String newUserId = userId + number;
        UserEntity userExit = this.findByUserId(newUserId);
        if(userExit == null) {
            return newUserId;
        }
        return this.incrementUserId(userId, number + 1);
    }

    public UserEntity signIn(LoginDto loginDto) throws Exception {
        UserEntity user = this.findByUserId(loginDto.getUserId());

        if (user != null){

            // si les 2 password ==
            if (verifPassword(user.getPassword(), loginDto.getPassword())){
                if(user.getTryPassword() <= 0){
                    throw new Exception("User can't retry to connect");
                }
                user.resetTryPassword();
                return this.userRepository.save(user);
            }
            user.decrementTryPassword();
            this.userRepository.save(user);
            if (user.getTryPassword() <= 0){
                throw new Exception("User can't retry to connect");
            }
        }

        throw new Exception("UserId or Password incorrect");

    }

    public Boolean verifPassword(String passwordHash, String password) {
        return this.bCryptPasswordEncoder().matches(password, passwordHash);
    }

    public UserEntity changePassword(LoginDto userDto) throws Exception {
        UserEntity user = this.findByUserId(userDto.getUserId());

        // si user existe
        if (user != null){
            // changer password
            user.setPassword(bCryptPasswordEncoder().encode(userDto.getPassword()));
            this.userRepository.save(user);
            return user;
        }
        throw new Exception("User doesn't exist");
    }


    public UserEntity createUser(UserEntity user) {
        return userRepository.save(user);
    }

    public UserEntity findById(Long id) {
        return this.userRepository.findById(id).get();
    }

    public UserEntity findByUserId(String userId) {
        return this.userRepository.findByUserId(userId);
    }



}
