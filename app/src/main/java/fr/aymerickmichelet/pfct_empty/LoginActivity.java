package fr.aymerickmichelet.pfct_empty;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;

import com.android.volley.RequestQueue;

import fr.aymerickmichelet.pfct_empty.myrequest.MyRequest;

public class LoginActivity extends AppCompatActivity {

    private ImageView loginpage_imageView_back;
    private EditText loginpage_editText_pseudo,
            loginpage_editText_password,
            loginpage_editText_passwordconfirm;
    private Button loginpage_button_login;
    private RequestQueue queue;
    private MyRequest request;

    private static LoginActivity instance = new LoginActivity();
    public static LoginActivity getInstance(){
        return instance;
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        loginpage_imageView_back = (ImageView) findViewById(R.id.loginpage_imageView_back);
        loginpage_editText_pseudo = findViewById(R.id.loginpage_editText_pseudo);
        loginpage_editText_password = findViewById(R.id.loginpage_editText_password);
        loginpage_button_login = findViewById(R.id.loginpage_button_login);
        queue = VolleySingleton.getInstance(this).getRequestQueue();
        request = new MyRequest(this, queue);


        loginpage_button_login.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                final String pseudo = loginpage_editText_pseudo.getText().toString().trim();
                String password = loginpage_editText_password.getText().toString().trim();
                if(pseudo.length() == 0){
                    Log.e("Bouzoula", "Pseudo vide");
                }
                if(password.length() == 0){
                    Log.e("Bouzoula", "Password vide");
                }
                if(pseudo.length() < 2 || pseudo.length() > 15){
                    Log.e("Bouzoula", "Pseudo incompatible");
                    return;
                }
                request.login(pseudo, password);
                finish();
            }
        });

        // revenir sur mainpage
        loginpage_imageView_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

    }
}
