package fr.aymerickmichelet.pfct_empty;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private Button mainpage_button_register;
    private Button mainpage_button_login;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        mainpage_button_register = (Button) findViewById(R.id.mainpage_button_register);
        mainpage_button_login = (Button) findViewById(R.id.mainpage_button_login);

        // clic register
        mainpage_button_register.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent indent = new Intent(getApplicationContext(), RegisterActivity.class);
                startActivity(indent);
            }
        });
        // clic register
        mainpage_button_login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent indent = new Intent(getApplicationContext(), LoginActivity.class);
                startActivity(indent);
            }
        });
    }
}
