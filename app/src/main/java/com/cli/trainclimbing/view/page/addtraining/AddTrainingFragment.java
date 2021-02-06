package com.cli.trainclimbing.view.page.addtraining;

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

public class AddTrainingFragment extends Fragment {

    private AddTrainingViewModel homeViewModel;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        homeViewModel =
                new ViewModelProvider(this).get(AddTrainingViewModel.class);
        View root = inflater.inflate(R.layout.fragment_add_training, container, false);





        return root;
    }
}