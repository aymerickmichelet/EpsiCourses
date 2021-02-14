package com.cli.trainclimbing.view.page.addtraining;

import android.app.DatePickerDialog;
import android.content.res.Configuration;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;

import com.cli.trainclimbing.R;

import java.time.LocalDateTime;
import java.util.Calendar;
import java.util.Locale;

public class AddTrainingFragment extends Fragment {

    private AddTrainingViewModel homeViewModel;

    DatePickerDialog datePickerDialog;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        homeViewModel =
                new ViewModelProvider(this).get(AddTrainingViewModel.class);
        View root = inflater.inflate(R.layout.fragment_add_training, container, false);
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

    private void initForm(View root){
//        Button dateButton = root.findViewById(R.id.at_button_date);
        EditText timeET = root.findViewById(R.id.at_editTextNumberSigned_timeValue);
        EditText easyET = root.findViewById(R.id.at_editTextNumberSigned_levelEasyValue);
        EditText middleET = root.findViewById(R.id.at_editTextNumberSigned_levelMiddleValue);
        EditText highET = root.findViewById(R.id.at_editTextNumberSigned_levelHighValue);
        EditText expertET = root.findViewById(R.id.at_editTextNumberSigned_levelExpertValue);

        setCalendarToFrench();
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

        Calendar calendarNow = Calendar.getInstance();
        Calendar calendarDateButton = calendarNow;
        if (!dateButton.getText().toString().equalsIgnoreCase("Aujourd'hui")){
            int day = Integer.parseInt(dateButton.getText().toString().split("/")[0]);
            int month = Integer.parseInt(dateButton.getText().toString().split("/")[1]);
            int year = Integer.parseInt(dateButton.getText().toString().split("/")[2]);
            calendarDateButton.set(year, month, day);
        }

        int time = Integer.parseInt(timeET.getText().toString());

        int easyNumber = Integer.parseInt(easyET.getText().toString());
        int middleNumber = Integer.parseInt(middleET.getText().toString());
        int highNumber = Integer.parseInt(highET.getText().toString());
        int expertNumber = Integer.parseInt(expertET.getText().toString());

        if (calendarDateButton.compareTo(calendarNow) >= 0)
            System.out.println("> La date est correcte");
        else
            System.out.println("> La date n'est pas correcte !");


        if (time > 0 && time < 24*60)
            System.out.println("> La durée est correcte");
        else
            System.out.println("> La durée n'est pas correcte !");


        if (easyNumber > 0 || middleNumber > 0 || highNumber > 0 || expertNumber > 0)
            System.out.println("> Le nombre de voie est correcte");
        else
            System.out.println("> Le nombre de voie n'est pas correcte !");
    }
}