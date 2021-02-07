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
import com.cli.trainclimbing.model.Training;

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
            viewHolder.hours = (TextView) convertView.findViewById(R.id.it_textView_hours);
            convertView.setTag(viewHolder);
        }

        Training training = getItem(position);
        viewHolder.date.setText(training.getDate());
        viewHolder.hours.setText(training.getHours());

        return convertView;

    }
}
