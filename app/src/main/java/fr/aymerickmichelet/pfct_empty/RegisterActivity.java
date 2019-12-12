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

public class RegisterActivity extends AppCompatActivity {

    private ImageView registerpage_imageView_back;
    private EditText registerpage_editText_pseudo,
                     registerpage_editText_password,
                     getRegisterpage_editText_passwordconfirm;
    private Button registerpage_button_register;
    private RequestQueue queue;
    private MyRequest request;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        registerpage_imageView_back = findViewById(R.id.registerpage_imageView_back);
        registerpage_editText_pseudo = findViewById(R.id.registerpage_editText_pseudo);
        registerpage_editText_password = findViewById(R.id.registerpage_editText_password);
        getRegisterpage_editText_passwordconfirm =
                findViewById(R.id.registerpage_editText_passwordconfirm);

        registerpage_button_register = findViewById(R.id.homepage_button_register);
        queue = VolleySingleton.getInstance(this).getRequestQueue();
        request = new MyRequest(this, queue);

        registerpage_button_register.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                String pseudo = registerpage_editText_pseudo.getText().toString().trim();
                String password = registerpage_editText_password.getText().toString().trim();
                String passwordconfirm =
                        getRegisterpage_editText_passwordconfirm.getText().toString().trim();
                Log.e("Bouzoula", "Pseudo: "+pseudo);
                Log.e("Bouzoula", "Password: "+password);
                Log.e("Bouzoula", "PasswordConfirm: "+passwordconfirm);

                if(pseudo.length() < 2 || pseudo.length() > 15){
                    Log.e("Bouzoula", "Pseudo incompatible");
                    return;
                }
                if(password == passwordconfirm){
                    Log.e("Bouzoula", "Les mdp sont différents");
                    return;
                }
                request.register(pseudo, password);
            }
        });

        // revenir sur mainpage
        registerpage_imageView_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent indent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(indent);
            }
        });
    }
}
