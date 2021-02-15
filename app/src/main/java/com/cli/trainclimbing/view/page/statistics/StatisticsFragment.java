package com.cli.trainclimbing.view.page.statistics;
import java.time.LocalDateTime;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.Observer;
import androidx.lifecycle.ViewModelProvider;

import com.cli.trainclimbing.R;

import org.w3c.dom.Text;

import java.time.LocalDateTime;

public class StatisticsFragment extends Fragment {

    private StatisticsViewModel dashboardViewModel;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        dashboardViewModel =
                new ViewModelProvider(this).get(StatisticsViewModel.class);
        View root = inflater.inflate(R.layout.fragment_statistics, container, false);

        // CardView nombre de trainings
        TextView textViewNbTrainingValue = root.findViewById(R.id.st_textView_nbTrainingValue);
        int nbTraining = 5;
        textViewNbTrainingValue.setText(String.valueOf(nbTraining));

        // CardView récap des difficultés des parcours
        int nbEasy = 3;
        int nbMedium = 8;
        int nbHard = 5;
        int nbHardcore = 0;

        TextView textViewEasyValue = root.findViewById(R.id.st_textView_easyValue);
        TextView textViewMediumValue = root.findViewById(R.id.st_textView_mediumValue);
        TextView textViewHardValue = root.findViewById(R.id.st_textView_hardValue);
        TextView textViewHardcoreValue = root.findViewById(R.id.st_textView_hardcoreValue);

        textViewEasyValue.setText(nbEasy + " Facile(s)");
        textViewMediumValue.setText(nbMedium + " Moyen(s)");
        textViewHardValue.setText(nbHard + " Difficile(s)");
        textViewHardcoreValue.setText(nbHardcore + " Très difficile(s)");

        // CardView durée des entraînements
        LocalDateTime dateTime = LocalDateTime.now();
        int hour = dateTime.getHour();
        int minutes = dateTime.getMinute();

        TextView textViewDurationTrainingValue = root.findViewById(R.id.st_textView_durationTrainingValue);
        textViewDurationTrainingValue.setText(hour + "h" + minutes);

        //CardView Niveau utilisateur
        String levelUser = "Expert";
        TextView textViewLvlUserValue = root.findViewById(R.id.st_textView_lvlUserValue);
        textViewLvlUserValue.setText(levelUser);

        return root;
    }
}