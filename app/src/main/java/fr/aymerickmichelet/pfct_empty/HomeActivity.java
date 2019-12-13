package fr.aymerickmichelet.pfct_empty;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import com.android.volley.RequestQueue;

import fr.aymerickmichelet.pfct_empty.game.Player;
import fr.aymerickmichelet.pfct_empty.myrequest.MyRequest;

public class HomeActivity extends AppCompatActivity {

    private ImageView homepage_imageView_back;
    private TextView homepage_textView_pseudo,
                    homepage_textView_pseudo2,
                    homepage_textView_victory,
                    homepage_textView_victory2,
                    homepage_textView_defeat,
                    homepage_textView_defeat2,
                    homepage_textView_ratio,
                    homepage_textView_ratio2;
    private Button homepage_button_1v1,
                    homepage_button_tournament;
    private RequestQueue queue;
    private MyRequest request;
    private Player player;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home);

        player = MainActivity.getInstance().player;

        homepage_imageView_back = (ImageView) findViewById(R.id.homepage_imageView_back);
        homepage_textView_pseudo = (TextView) findViewById(R.id.homepage_textView_pseudo);
        homepage_textView_pseudo2 = (TextView) findViewById(R.id.homepage_textView_pseudo2);
        homepage_textView_victory = (TextView) findViewById(R.id.homepage_textView_victory);
        homepage_textView_victory2 = (TextView) findViewById(R.id.homepage_textView_victory2);
        homepage_textView_defeat = (TextView) findViewById(R.id.homepage_textView_victory2);
        homepage_textView_defeat2 = (TextView) findViewById(R.id.homepage_textView_victory2);
        homepage_textView_ratio = (TextView) findViewById(R.id.homepage_textView_ratio);
        homepage_textView_ratio2 = (TextView) findViewById(R.id.homepage_textView_ratio2);

        homepage_textView_pseudo2.setText(player.getName());
        homepage_textView_victory2.setText(Integer.toString(player.getVictory()));
        homepage_textView_defeat2.setText(Integer.toString(player.getDefeat()));
        if(player.getDefeat() != 0){
            homepage_textView_ratio2.setText(Float.toString(player.getVictory() / player.getDefeat()));
        }

        // revenir sur mainpage
        homepage_imageView_back.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });
    }
}
