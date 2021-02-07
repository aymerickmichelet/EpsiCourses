package com.cli.trainclimbing.view.page.listtraining;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ListView;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;

import com.cli.trainclimbing.R;
import com.cli.trainclimbing.model.Training;
import com.cli.trainclimbing.view.itemtraining.ListTrainingAdapter;

import java.util.ArrayList;
import java.util.List;

public class ListTrainingFragment extends Fragment {

    private ListView lvList;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

       View root = inflater.inflate(R.layout.fragment_list_training, container, false);

       List<Training> trainingList = generateTraining();

       ListTrainingAdapter adapter = new ListTrainingAdapter(root.getContext(), trainingList);

       this.lvList = (ListView) root.findViewById(R.id.lt_ListView_training);
       this.lvList.setAdapter(adapter);
        return root;
    }

    private List<Training> generateTraining() {
        List<Training> trainingList = new ArrayList<Training>();
        trainingList.add(new Training("Date : 21/09/2000", "2h00"));
        trainingList.add(new Training("Date : 21/09/2000", "2h00"));
        trainingList.add(new Training("Date : 21/09/2000", "2h00"));
        trainingList.add(new Training("Date : 21/09/2000", "2h00"));
        trainingList.add(new Training("Date : 21/09/2000", "2h00"));
        trainingList.add(new Training("Date : 21/09/2000", "2h00"));

        return trainingList;

    }
}