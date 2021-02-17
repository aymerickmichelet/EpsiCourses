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
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;
import androidx.navigation.Navigation;

import com.cli.trainclimbing.R;
import com.cli.trainclimbing.controller.Controller;
import com.cli.trainclimbing.model.Level;
import com.cli.trainclimbing.model.Training;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.Locale;

public class AddTrainingFragment extends Fragment {

    private AddTrainingViewModel homeViewModel;
    private Controller controller; // database
    private Calendar inputCalendar = formatCalendar(new GregorianCalendar()); // set calendar with today day

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        homeViewModel = new ViewModelProvider(this).get(AddTrainingViewModel.class);
        View root = inflater.inflate(R.layout.fragment_add_training, container, false);
        controller = Controller.getInstance(root.getContext()); // database
        Button dateButton = root.findViewById(R.id.at_button_date);
        Button submit = root.findViewById(R.id.at_button_submit);

        // initialize form
        setCalendarToFrench();
        initForm(root);

        // event click on calendar button
        dateButton.setOnClickListener(v -> chooseDateFromCalendar(dateButton));

        // event click on submit button
        submit.setOnClickListener(v -> submitForm());

        return root;
    }

    // return Calendar object with hour, min & sec at 0
    private Calendar formatCalendar(Calendar calendar){
        calendar.set(
                calendar.get(Calendar.YEAR),
                calendar.get(Calendar.MONTH),
                calendar.get(Calendar.DAY_OF_MONTH),
                0,
                0,
                0
        );
        return calendar;
    }

    // return the value of text for Button and EditText
    private int getValueOfField(int reference){
        Object obj = getView().findViewById(reference);
        if (obj instanceof EditText)
            if (!((EditText) obj).getText().toString().equalsIgnoreCase(""))
                return Integer.parseInt(((EditText) obj).getText().toString());
            else
                return 0;
        else if (obj instanceof Button)
            if (!((Button) obj).getText().toString().equalsIgnoreCase(""))
                return Integer.parseInt(((Button) obj).getText().toString());
            else
                return 0;
        else
            return -1;
    }

    // set the value of text for Button and EditText
    private void setValueOfField(View root, int reference, String value){
        Object obj = root.findViewById(reference);
        System.out.println(obj.toString());
        if (obj instanceof EditText)
            ((EditText) obj).setText(value);
        else if (obj instanceof Button)
            ((Button) obj).setText(value);
    }

    private void setCalendarToFrench(){
        Locale locale = new Locale("FR");
        Locale.setDefault(locale);
        Configuration config = new Configuration();
        config.locale = locale;
        getContext().getResources().updateConfiguration(config, null);
    }

    // event click on calendar button
    private void chooseDateFromCalendar(Button dateButton){
        DateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
        Calendar nowCalendar = formatCalendar(Calendar.getInstance());

        DatePickerDialog datePickerDialog = new DatePickerDialog(getContext(),
                R.style.Theme_TrainClimbing_DatePicker,
                (v, y, m, d) -> {
                    inputCalendar.set(y, m, d);
                    if (inputCalendar.after(nowCalendar))
                        dateButton.setText(R.string.ad_button_date);
                    else
                        dateButton.setText(sdf.format(inputCalendar.getTime()));
                }, inputCalendar.get(Calendar.YEAR),
                inputCalendar.get(Calendar.MONTH),
                inputCalendar.get(Calendar.DAY_OF_MONTH));

        datePickerDialog.getDatePicker().setFirstDayOfWeek(Calendar.MONDAY);
        datePickerDialog.getDatePicker().setMinDate(formatCalendar(
                new GregorianCalendar(2000, 7, 19)).getTimeInMillis());
        datePickerDialog.getDatePicker().setMaxDate(nowCalendar.getTimeInMillis());
        datePickerDialog.show();
    }

    // reset all values in form
    private void initForm(@Nullable View view){
        inputCalendar = formatCalendar(new GregorianCalendar());

        if (view == null) view = getView();

        setValueOfField(view, R.id.at_button_date, getContext().getString(R.string.ad_button_date));
        setValueOfField(view, R.id.at_editTextNumberSigned_timeValue, "0");
        setValueOfField(view, R.id.at_editTextNumberSigned_levelEasyValue, "0");
        setValueOfField(view, R.id.at_editTextNumberSigned_levelMiddleValue, "0");
        setValueOfField(view, R.id.at_editTextNumberSigned_levelHighValue, "0");
        setValueOfField(view, R.id.at_editTextNumberSigned_levelExpertValue, "0");
    }

    // event on click submit button
    private void submitForm(){
        String toast_message;

        int time = getValueOfField(R.id.at_editTextNumberSigned_timeValue);
        int easyNumber = getValueOfField(R.id.at_editTextNumberSigned_levelEasyValue);
        int mediumNumber = getValueOfField(R.id.at_editTextNumberSigned_levelMiddleValue);
        int highNumber = getValueOfField(R.id.at_editTextNumberSigned_levelHighValue);
        int hardcoreNumber = getValueOfField(R.id.at_editTextNumberSigned_levelExpertValue);

        // if time is between 0 and 1440 min
        if (time > 0){
            if(time < 24*60){
                // if numbers are positives
                if (easyNumber >= 0 && mediumNumber >= 0 && highNumber >= 0 && hardcoreNumber >= 0){

                    // save data
                    int id = this.controller.getLastIdTraining() + 1;

                    ArrayList<Level> listLevel = new ArrayList<>();
                    listLevel.add(new Level("EASY", easyNumber));
                    listLevel.add(new Level("MEDIUM", mediumNumber));
                    listLevel.add(new Level("HIGHT", highNumber));
                    listLevel.add(new Level("HARDCORE", hardcoreNumber));

                    Training training = new Training(id, inputCalendar.getTime(), time, listLevel);

                    this.controller.AddTraining(training);

                    // init values of Form
                    initForm(null);

                    // redirection to stats page
                    Navigation.findNavController(getActivity(),
                            R.id.nav_host_fragment).navigate(R.id.navigation_list_training);

                    toast_message = "L'entrainement a bien été ajouté !";
                }else toast_message = "Erreur:\nToutes les valeurs de voies ne sont pas positive !";
            }else toast_message = "La durée ne doit pas exceder 1440 min.";
        }else toast_message = "La durée doit être supérieur à 0 min.\n";

        // Send alert
        Toast.makeText(getContext(), toast_message, Toast.LENGTH_LONG).show();
    }

}