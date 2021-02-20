package com.cli.trainclimbing.view.page.statistics;
import java.time.LocalDateTime;

import android.annotation.SuppressLint;
import android.content.Context;
import android.graphics.Color;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.core.content.ContextCompat;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.Observer;
import androidx.lifecycle.ViewModelProvider;

import com.cli.trainclimbing.R;
import com.cli.trainclimbing.controller.Controller;
import com.cli.trainclimbing.model.Stat;

import org.w3c.dom.Text;

import java.time.LocalDateTime;

public class StatisticsFragment extends Fragment {

    private StatisticsViewModel dashboardViewModel;
    private Controller controller;
    private Context context;

    @SuppressLint("ResourceAsColor")
    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        dashboardViewModel =
                new ViewModelProvider(this).get(StatisticsViewModel.class);
        View root = inflater.inflate(R.layout.fragment_statistics, container, false);

        controller = Controller.getInstance(root.getContext());
        Stat stat;

        // CardView nombre de trainings
        TextView textViewNbTrainingValue = root.findViewById(R.id.st_textView_nbTrainingValue);
        int nbTraining;

        // CardView récap des difficultés des parcours
        TextView textViewEasyValue = root.findViewById(R.id.st_textView_easyValue);
        TextView textViewMediumValue = root.findViewById(R.id.st_textView_mediumValue);
        TextView textViewHardValue = root.findViewById(R.id.st_textView_hightValue);
        TextView textViewHardcoreValue = root.findViewById(R.id.st_textView_hardcoreValue);
        int nbEasy;
        int nbMedium;
        int nbHight;
        int nbHardcore;

        // CardView durée des entraînements
        TextView textViewDurationTrainingValue = root.findViewById(R.id.st_textView_durationTrainingValue);
        float averageTime;
        String durationTraining;

        //CardView Niveau utilisateur
        String levelUser;
        TextView textViewLvlUserValue = root.findViewById(R.id.st_textView_lvlUserValue);

        try {
           stat = this.controller.getStat();

           // Nombre d'entraînements dans le mois
           nbTraining = stat.getNumberTrainingMonth();

           // Nombre de parcours effectués par difficultées
            nbEasy = stat.getAverageLevelTraining().get("EASY");
            nbMedium = stat.getAverageLevelTraining().get("MEDIUM");
            nbHight = stat.getAverageLevelTraining().get("HIGHT");
            nbHardcore = stat.getAverageLevelTraining().get("HARDCORE");

            // Temps moyen des entraînements
            averageTime = stat.getAverageTimeTraining();
            System.out.println("Temps moyen :" + averageTime);
            durationTraining = stat.formatTime(averageTime);

            // Niveau de l'utilisateur
             levelUser = stat.getLevelUser();
             switch (levelUser)
             {
                 case "EASY" :
                     levelUser = getString(R.string.easy_level);
                     textViewLvlUserValue.setTextColor(ContextCompat.getColor(textViewLvlUserValue.getContext(), R.color.lv_green));
                     break;
                 case "MEDIUM" :
                     levelUser = getString(R.string.medium_level);
                     textViewLvlUserValue.setTextColor(ContextCompat.getColor(textViewLvlUserValue.getContext(), R.color.lv_yellow));
                     break;
                 case "HIGHT" :
                     levelUser = getString(R.string.hight_level);
                     textViewLvlUserValue.setTextColor(ContextCompat.getColor(textViewLvlUserValue.getContext(), R.color.lv_orange));
                     break;
                 case "HARDCORE" :
                     levelUser = getString(R.string.harcore_level);
                     textViewLvlUserValue.setTextColor(ContextCompat.getColor(textViewLvlUserValue.getContext(), R.color.lv_red));
                     break;
                 default:
                     break;
             }
        }

        catch (Exception exception)
        {
            // Nombre d'entraînements dans le mois
            nbTraining = 0;

            // Nombre de parcours effectués par difficultées
            nbEasy = 0;
            nbMedium = 0;
            nbHight = 0;
            nbHardcore = 0;

            // Temps moyen des entraînements
            averageTime = 0;
            durationTraining = "00:00";

            // Niveau de l'utilisateur
            levelUser = "Inconnu";
            levelUser = getString(R.string.unknown_level);
            textViewLvlUserValue.setTextColor(ContextCompat.getColor(textViewLvlUserValue.getContext(), R.color.lv_unkown));
        }

        // Affiche le nombre d'entraînements
        textViewNbTrainingValue.setText(String.valueOf(nbTraining));

        // Affiche le nombre de parcours effectués par difficultées
        textViewEasyValue.setText(nbEasy + " 4a/5c");
        textViewMediumValue.setText(nbMedium + " 6a/6c");
        textViewHardValue.setText(nbHight + " 7a/7c");
        textViewHardcoreValue.setText(nbHardcore + " 8a/+");

        // Affiche le temps moyen d'entraînements
        textViewDurationTrainingValue.setText(durationTraining);

        // Affiche le niveau de l'utilisateur
        textViewLvlUserValue.setText(levelUser);

        return root;
    }
}