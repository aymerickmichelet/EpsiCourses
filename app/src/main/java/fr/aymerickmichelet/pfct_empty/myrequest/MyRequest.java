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

import fr.aymerickmichelet.pfct_empty.HomeActivity;
import fr.aymerickmichelet.pfct_empty.LoginActivity;
import fr.aymerickmichelet.pfct_empty.MainActivity;
import fr.aymerickmichelet.pfct_empty.RegisterActivity;
import fr.aymerickmichelet.pfct_empty.game.Player;

public class MyRequest {
    private Context context;
    private RequestQueue queue;
    private Player player;

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
                        Toast.makeText(context, msg, Toast.LENGTH_LONG).show();
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


    public void login(String pseudo, String password){

        String url = "https://pfct.aymerickmichelet.fr/user.php?request=find&username="+pseudo+"&password="+password;

        StringRequest request = new StringRequest(Request.Method.POST, url, new Response.Listener<String>(){

            @Override
            public void onResponse(String response){
                String msg = "";
                JSONObject json = null;
                try {
                    json = new JSONObject(response);

                    if(json.getString("response").equalsIgnoreCase( "OK")) {
                        msg = "Connexion en cour...";
                        Log.e("Bouzoula", msg + " - " + json.getString("response"));
                        Toast.makeText(context, msg, Toast.LENGTH_LONG).show();
                        getPlayer();
                        Intent indent = new Intent(context, HomeActivity.class);
                        context.startActivity(indent);
                    }else if(json.getString("response").equalsIgnoreCase("ERROR")){
                        msg = "Le couple pseudo/mot de passe n'existe pas !";
                        Log.e("Bouzoula", msg + " - " + json.getString("response"));
                        Toast.makeText(context, msg, Toast.LENGTH_LONG).show();
                    }else{
                        Toast.makeText(context, "Une erreur s'est produite", Toast.LENGTH_LONG).show();
                    }
                } catch (JSONException e) {
                    e.printStackTrace();
                    Toast.makeText(context, "Une erreur s'est produite", Toast.LENGTH_LONG).show();
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

    public void getPlayer(){
        player = MainActivity.getInstance().player;
        String url = "https://pfct.aymerickmichelet.fr/user.php?request=find&username="+player.getName();
        StringRequest request = new StringRequest(Request.Method.POST, url, new Response.Listener<String>(){

            @Override
            public void onResponse(String message){
                String msg = "";
                JSONObject json = null;
                try {
                    json = new JSONObject(message);
                    String response = json.getString("response");
                    if(response.equalsIgnoreCase( "OK")) {
                        Log.e("Bouzoula", "connexion etablie" + " - " + json.getString("response"));
                        try{
                            JSONObject user = json.getJSONObject("user");
                            Log.e("Bouzoula", user.toString());
                            int victories = Integer.parseInt(user.getString("victories"));
                            int defeats = Integer.parseInt(user.getString("defeats"));
                            int id = Integer.parseInt(user.getString("id"));
                            Log.e("Bouzoula", MainActivity.getInstance().player.getName() + "\n"
                                    + id + "\n"
                                    + victories + "\n"
                                    + defeats + "\n");
                            player.setVictory(victories);
                            player.setDefeat(defeats);
                            player.setId(id);

                        }catch(JSONException e){
                            e.printStackTrace();
                        }
                    }else if(response.equalsIgnoreCase("ERROR")){
                        Log.e("Bouzoula", "Une erreur s'est produite" + " - " + json.getString("response"));
                    }else{
                        Log.e("Bouzoula", "Une erreur s'est produite");
                    }
                } catch (JSONException e) {
                    e.printStackTrace();
                    Log.e("Bouzoula", "Une erreur s'est produite");
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
