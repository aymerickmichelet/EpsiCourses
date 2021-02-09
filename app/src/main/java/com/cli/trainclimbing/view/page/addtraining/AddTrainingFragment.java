package com.cli.trainclimbing.view.page.addtraining;

import android.app.DatePickerDialog;
import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;

import com.cli.trainclimbing.R;
import com.cli.trainclimbing.view.MainActivity;

import java.time.LocalDateTime;
import java.util.Calendar;
import java.util.Date;

import static android.widget.Toast.LENGTH_SHORT;

public class AddTrainingFragment extends Fragment {

    private AddTrainingViewModel homeViewModel;

    DatePickerDialog datePickerDialog;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        homeViewModel =
                new ViewModelProvider(this).get(AddTrainingViewModel.class);
        View root = inflater.inflate(R.layout.fragment_add_training, container, false);

        EditText et = root.findViewById(R.id.at_editTextDate_dateValue);

        Calendar c = Calendar.getInstance();
        int day = c.get(Calendar.DAY_OF_MONTH);
        int month = c.get(Calendar.MONTH);
        int year = c.get(Calendar.YEAR);
        LocalDateTime dateTime = java.time.LocalDateTime.now();


        et.setOnTouchListener(new View.OnTouchListener(){
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                datePickerDialog = new DatePickerDialog(getContext(), new DatePickerDialog.OnDateSetListener() {
                    @Override
                    public void onDateSet(DatePicker view, int year, int month, int dayOfMonth) {
                        et.setText(dayOfMonth + "/" + month + "/" + year);
                    }
                }, day, month, year);
                datePickerDialog.show();
                return false;
            }
        });

//        <DatePicker
//        android:id="@+id/simpleDatePicker"
//        android:layout_width="wrap_content"
//        android:layout_height="wrap_content"
//        android:datePickerMode="calendar"
//        android:firstDayOfWeek="0"
//        android:headerBackground="@color/blue"
//        android:calendarViewShown="false"
//                />

        return root;
    }
}