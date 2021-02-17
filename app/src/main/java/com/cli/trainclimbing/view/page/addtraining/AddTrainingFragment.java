package com.cli.trainclimbing.view.page.addtraining;

import android.app.DatePickerDialog;
import android.content.res.Configuration;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;

import com.cli.trainclimbing.R;
import com.cli.trainclimbing.controller.Controller;
import com.cli.trainclimbing.model.Level;
import com.cli.trainclimbing.model.Training;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.Locale;

public class AddTrainingFragment extends Fragment {

    private AddTrainingViewModel homeViewModel;
    private Controller controller;

    DatePickerDialog datePickerDialog;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        homeViewModel =
                new ViewModelProvider(this).get(AddTrainingViewModel.class);
        View root = inflater.inflate(R.layout.fragment_add_training, container, false);
        controller = Controller.getInstance(root.getContext());
        Button dateButton = root.findViewById(R.id.at_button_date);
        Button submit = root.findViewById(R.id.at_button_submit);

        // initialize form
        initForm(root);

        // event click on calendar button
        dateButton.setOnClickListener(v -> getDateFromCalendar(dateButton));

        // event click on submit button
        submit.setOnClickListener(v -> submitForm(root));

        return root;
    }

    private void setCalendarToFrench(){
        Locale locale = new Locale("FR");
        Locale.setDefault(locale);
        Configuration config = new Configuration();
        config.locale = locale;
        getContext().getResources().updateConfiguration(config, null);
    }

    // event click on calendar button
    private void getDateFromCalendar(Button dateButton){
        LocalDateTime dateNow = LocalDateTime.now();

        datePickerDialog = new DatePickerDialog(getContext(),
                R.style.Theme_TrainClimbing_DatePicker,
                (v, y, m, d) -> {
                    m++;
                    if(dateNow.getDayOfMonth() == d &&
                            dateNow.getMonth().getValue() == m &&
                            dateNow.getYear() == y)
                        dateButton.setText("Aujourd'hui");
                    else
                        dateButton.setText(d+"/"+m+"/"+y);
                }, dateNow.getYear(),dateNow.getMonth().getValue()-1, dateNow.getDayOfMonth());
        datePickerDialog.getDatePicker().setFirstDayOfWeek(Calendar.MONDAY);
//                datePickerDialog.getDatePicker().setMinDate();
//                datePickerDialog.getDatePicker().setMaxDate();
        datePickerDialog.show();
    }

    // reset all values in form
    private void initForm(View root){
        Button dateButton = root.findViewById(R.id.at_button_date);
        EditText timeET = root.findViewById(R.id.at_editTextNumberSigned_timeValue);
        EditText easyET = root.findViewById(R.id.at_editTextNumberSigned_levelEasyValue);
        EditText middleET = root.findViewById(R.id.at_editTextNumberSigned_levelMiddleValue);
        EditText highET = root.findViewById(R.id.at_editTextNumberSigned_levelHighValue);
        EditText expertET = root.findViewById(R.id.at_editTextNumberSigned_levelExpertValue);

        setCalendarToFrench();
        dateButton.setText("Aujourd'hui");
        timeET.setText("0");
        easyET.setText("0");
        middleET.setText("0");
        highET.setText("0");
        expertET.setText("0");
    }

    // event on click submit button
    private void submitForm(View root){
        Button dateButton = root.findViewById(R.id.at_button_date);
        EditText timeET = root.findViewById(R.id.at_editTextNumberSigned_timeValue);
        EditText easyET = root.findViewById(R.id.at_editTextNumberSigned_levelEasyValue);
        EditText middleET = root.findViewById(R.id.at_editTextNumberSigned_levelMiddleValue);
        EditText highET = root.findViewById(R.id.at_editTextNumberSigned_levelHighValue);
        EditText expertET = root.findViewById(R.id.at_editTextNumberSigned_levelExpertValue);

        StringBuilder errors = new StringBuilder();
        errors.append("Erreur:\n");

        Calendar calendarNow = Calendar.getInstance();
        Calendar calendarDateButton = new GregorianCalendar();
        if (!dateButton.getText().toString().equalsIgnoreCase("Aujourd'hui")){
            int day = Integer.parseInt(dateButton.getText().toString().split("/")[0]);
            int month = Integer.parseInt(dateButton.getText().toString().split("/")[1]);
            int year = Integer.parseInt(dateButton.getText().toString().split("/")[2]);
            calendarDateButton.set(year, month-1, day);
        }

        int time = Integer.parseInt(timeET.getText().toString());

        int easyNumber = Integer.parseInt(easyET.getText().toString());
        int middleNumber = Integer.parseInt(middleET.getText().toString());
        int highNumber = Integer.parseInt(highET.getText().toString());
        int expertNumber = Integer.parseInt(expertET.getText().toString());

        // if dateNow is recent as dateDateButton -> OK
        if (calendarNow.compareTo(calendarDateButton) >= 0){
            // if time is between 0 and 1440 min
            if (time > 0){
                if(time < 24*60){
                    // if numbers are positives
                    if (easyNumber >= 0 && middleNumber >= 0 && highNumber >= 0 || expertNumber >= 0){
                        Toast.makeText(getContext(), "L'entrainement a bien été ajouté !", Toast.LENGTH_LONG).show();

                        // save data
                        int id = this.controller.getLastIdTraining() + 1;

                        ArrayList<Level> listLevel = new ArrayList<>();
                        if (easyNumber > 0) listLevel.add(new Level("EASY", easyNumber));
                        if (middleNumber > 0) listLevel.add(new Level("MEDIUM", middleNumber));
                        if (highNumber > 0) listLevel.add(new Level("HIGHT", highNumber));
                        if (expertNumber > 0) listLevel.add(new Level("HARDCORE", expertNumber));

                        Training training = new Training(id, calendarDateButton.getTime(), time, listLevel);

                        this.controller.AddTraining(training);

                        initForm(root); // init value of Form
                        return;
                    }else{
                        errors.append("Toutes les valeurs de voies ne sont pas positive !\n");
                    }
                }else{
                    errors.append("La durée ne doit pas exceder 1440 min.");
                }
            }else{
                errors.append("La durée doit être supérieur à 0 min.\n");
            }
        }else{
            errors.append("La date selectionnée est plus récente que celle d'aujourd'hui !\n");
        }

        Toast toast = Toast.makeText(getContext(), errors.toString(), Toast.LENGTH_LONG);
        toast.show();
    }

}