package fr.aymerickmichelet.pfct_empty;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;

public class RegisterActivity extends AppCompatActivity {

    private ImageView registerpage_imageView_back;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        registerpage_imageView_back = findViewById(R.id.registerpage_imageView_back);

        registerpage_imageView_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent indent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(indent);
            }
        });
    }
}
