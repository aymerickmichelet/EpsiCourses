package com.cli.trainclimbing.view.page.addtraining;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class AddTrainingViewModel extends ViewModel {

    private MutableLiveData<String> mText;

    public AddTrainingViewModel() {
        mText = new MutableLiveData<>();
        mText.setValue("This is addTraining fragment");
    }

    public LiveData<String> getText() {
        return mText;
    }
}