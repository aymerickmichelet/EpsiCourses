package com.cli.trainclimbing.view.itemtraining;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.cli.trainclimbing.R;
import com.cli.trainclimbing.model.Level;
import com.cli.trainclimbing.model.Training;

import java.text.SimpleDateFormat;
import java.util.List;

public class ListTrainingAdapter extends ArrayAdapter<Training> {

    public ListTrainingAdapter(@NonNull Context context, List<Training> trainings) {
        super(context, 0, trainings);
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        if(convertView == null){
            convertView = LayoutInflater.from(getContext()).inflate(R.layout.item_training,parent, false);
        }
        ItemTrainingViewHolder viewHolder = (ItemTrainingViewHolder) convertView.getTag();

        if(viewHolder == null) {
            viewHolder = new ItemTrainingViewHolder();
            viewHolder.date = (TextView) convertView.findViewById(com.cli.trainclimbing.R.id.it_textView_date);
            viewHolder.times = (TextView) convertView.findViewById(R.id.it_textView_times);
            viewHolder.easy = (TextView) convertView.findViewById(R.id.it_textView_easy);
            viewHolder.medium = (TextView) convertView.findViewById(R.id.it_textView_medium);
            viewHolder.hight = (TextView) convertView.findViewById(R.id.it_textView_hight);
            viewHolder.hardcore = (TextView) convertView.findViewById(R.id.it_textView_hardcore);
            convertView.setTag(viewHolder);
        }

        Training training = getItem(position);

        String easy = "0";
        String medium = "0";
        String hight = "0";
        String hardcore = "0";

        for(Level level: training.getListLevel()) {

            switch(level.getName()) {
                case "EASY":
                    easy = String.valueOf(level.getNumber());
                    break;
                case "MEDIUM":
                    medium = String.valueOf(level.getNumber());
                    break;
                case "HIGHT":
                    hight = String.valueOf(level.getNumber());
                    break;
                case "HARDCORE":
                    hardcore = String.valueOf(level.getNumber());
                    break;
            }
        }

        viewHolder.date.setText("Date : " + training.formatDate());
        viewHolder.times.setText(training.formatTimes());
        viewHolder.easy.setText(easy + " - 4a/5c");
        viewHolder.medium.setText(medium + " - 6a/6c");
        viewHolder.hight.setText(hight + " - 7a/7c");
        viewHolder.hardcore.setText(hardcore + " - 8a/+");

        return convertView;

    }
}
