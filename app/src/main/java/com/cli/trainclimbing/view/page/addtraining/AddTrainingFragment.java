package com.cli.trainclimbing.view.page.addtraining;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.DatePicker;
import android.widget.EditText;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;

import com.cli.trainclimbing.R;

import java.util.Calendar;
import java.util.Date;

public class AddTrainingFragment extends Fragment {

    private AddTrainingViewModel homeViewModel;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        homeViewModel =
                new ViewModelProvider(this).get(AddTrainingViewModel.class);
        View root = inflater.inflate(R.layout.fragment_add_training, container, false);


        Date date_today = Calendar.getInstance().getTime();

//        EditText date_editText = root.findViewById(R.id.at_editTextDate_value);
//        date_editText.setText(date_today.getDate() + "/" + date_today.getMonth() + "/" + date_today.getYear());

//        DatePicker datePicker = (DatePicker) root.findViewById(R.id.simpleDatePicker);
//        datePicker.setSpinnersShown(true);

        return root;
    }
}