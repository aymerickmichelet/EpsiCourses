package com.cli.trainclimbing.view.page.listtraining;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class ListTrainingViewModel extends ViewModel {

    private MutableLiveData<String> mText;

    public ListTrainingViewModel() {
        mText = new MutableLiveData<>();
        mText.setValue("This is ListTraining fragment");
    }

    public LiveData<String> getText() {
        return mText;
    }
}