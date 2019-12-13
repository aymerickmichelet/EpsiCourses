package fr.aymerickmichelet.pfct_empty.myrequest;

import android.content.Context;
import android.content.Intent;
import android.util.Log;
import android.widget.Toast;

import com.android.volley.AuthFailureError;
import com.android.volley.NetworkError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;

import org.json.JSONException;
import org.json.JSONObject;

import java.util.HashMap;
import java.util.Map;

import fr.aymerickmichelet.pfct_empty.MainActivity;
import fr.aymerickmichelet.pfct_empty.RegisterActivity;

public class MyRequest {
    private Context context;
    private RequestQueue queue;

    public MyRequest(Context context, RequestQueue requestQueue){
        this.context = context;
        this.queue = requestQueue;
    }

    public void register(String pseudo, String password){

        String url = "https://pfct.aymerickmichelet.fr/user.php?request=add&username="+pseudo+"&password="+password;

        StringRequest request = new StringRequest(Request.Method.POST, url, new Response.Listener<String>(){

            @Override
           public void onResponse(String response){

               Map<String, String> errors = new HashMap<>();
               String msg = "";
                JSONObject json = null;
                try {
                    json = new JSONObject(response);
                    if(json.getString("response") == "ERROR"){
                        msg = "Une erreur s'est produite !";
                        Log.e("Bouzoula", msg + " - " + json.getString("response"));
                        Toast.makeText(context, "msg1", Toast.LENGTH_LONG).show();
                    }else{
                        Toast.makeText(context, "Inscription_validee", Toast.LENGTH_LONG).show();
                    }
                } catch (JSONException e) {
                    e.printStackTrace();
                    Toast.makeText(context, "Inscription_validee", Toast.LENGTH_LONG).show();
                }
           }
        }, new Response.ErrorListener(){
            @Override
            public void onErrorResponse(VolleyError error){
                String msg = "";
                if(error instanceof NetworkError){
                    msg = "Impossible de se connecter";
                }else if(error instanceof  VolleyError){
                    msg = "Un erreur s'est produite";
                }
                Log.e("Bouzoula", msg + " - "+ error.toString());
                Toast.makeText(context, msg, Toast.LENGTH_LONG).show();
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
