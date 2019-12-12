package fr.aymerickmichelet.pfct_empty.myrequest;

import android.content.Context;
import android.util.Log;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;

import java.util.Map;

public class MyRequest {
    private Context context;
    private RequestQueue queue;

    public MyRequest(Context context, RequestQueue requestQueue){
        this.context = context;
        this.queue = requestQueue;
    }

    public void register(String pseudo, String password){

        String url = "https://pfct.aymerickmichelet.fr/user.php?request=add&"+pseudo+"="+password;

        StringRequest request = new StringRequest(Request.Method.POST, url, new Response.Listener<String>(){
           @Override
           public void onResponse(String response){
               Log.e("Bouzoula", response);
           }
        }, new Response.ErrorListener(){
            @Override
            public void onErrorResponse(VolleyError error){
                Log.e("Bouzoula", error.toString());
            }
        }){
            @Override
            protected Map<String, String> getParams() throws AuthFailureError {
                return super.getParams();
            }
        };

        queue.add(request);

    }
}
