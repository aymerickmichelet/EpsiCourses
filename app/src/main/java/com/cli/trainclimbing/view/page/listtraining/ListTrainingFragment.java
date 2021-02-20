package com.cli.trainclimbing.view.page.listtraining;


import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;

import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;

import com.cli.trainclimbing.R;
import com.cli.trainclimbing.controller.Controller;
import com.cli.trainclimbing.model.Level;
import com.cli.trainclimbing.model.Training;
import com.cli.trainclimbing.model.TrainingTest;
import com.cli.trainclimbing.view.itemtraining.ListTrainingAdapter;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.Date;
import java.util.List;

public class ListTrainingFragment extends Fragment {

    private ListView lvList;
    private Controller controller;
    private List<Training>  trainingList;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        //init View and Controller
       View root = inflater.inflate(R.layout.fragment_list_training, container, false);
       controller = Controller.getInstance(root.getContext());

       //init SendViewList
        Button button = root.findViewById(R.id.lt_Button_sendtraing);
        button.setOnClickListener((v) -> sendLastTraining());

        //init listTraining
        this.initListTraining(root);

        return root;
    }

    public void initListTraining(View root) {
        trainingList = this.controller.getTraining();

        if(trainingList.size() == 0) {
            TextView textNoTraining = root.findViewById(R.id.lt_TextView_noTraining);
            textNoTraining.setVisibility(View.VISIBLE);
        } else {
            Collections.reverse(trainingList);
            ListTrainingAdapter adapter = new ListTrainingAdapter(root.getContext(), trainingList);
            this.lvList = (ListView) root.findViewById(R.id.lt_ListView_training);
            this.lvList.setAdapter(adapter);
        }
    }

    public void sendLastTraining() {
        Training lastTraining;
        try {
            lastTraining = trainingList.get(trainingList.size() - 1);
        }
        catch(ArrayIndexOutOfBoundsException e) {
            Log.d("Debug","Training list was found empty, last training session could not be fetched");

            String toast_message = "Aucun entrainement à partager !";
            Toast.makeText(getContext(), toast_message, Toast.LENGTH_LONG).show();
            return;
        }

        String msgBody = "Regarde un peu ma dernière session d'entrainement!\n";
        String formatDate = lastTraining.formatDate();
        String trainingDuration = lastTraining.formatTimes();
        msgBody += "Je me suis exercé le " + formatDate + " pendant " + trainingDuration;

        Intent intentSMS = new Intent( Intent.ACTION_VIEW, Uri.parse( "sms:" + "" ) );
        intentSMS.putExtra( "sms_body", msgBody );
        startActivity( intentSMS );

    }

}