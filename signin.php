<?php
session_start();
$titre="Sign in";
include("idbdd.php");
include("debut.php");
include("menu.php");


if ($id!=0) erreur(ERR_IS_CO);
?>








<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>PBJAN</title>
        <link href="formstyle.css" rel="stylesheet" type="text/css"/>
    </head>
    <body>
        <div id="registrationform">
            <h1>S'inscrire à PBJAN</h1>
            <h4>Bienvenue</h4>
            <form method="POST" action="registration.php">
                <p class="label">
                    <label for="prenom" class="required">prenom</label>
                </p>
                <p class="medium">
                    <input id="prenom" type="text"  name="prenom" placeholder="prenom" required="required">
                </p>
                <p class="label">
                    <label for="nom" class="required">nom</label>
                </p>
                <p class="medium">
                    <input id="nom" type="text"  name="nom" placeholder="nom" required="required">
                </p>
                <p class="label">
                    <label for="password" class="required">password</label>
                </p>
                <p class="medium">
                    <input id="password" type="text"  name="password" placeholder="password" required="required">
                </p>
                <p class="label">
                    <label for="confirmpassword" class="required">confirmpassword</label>
                </p>
                <p class="medium">
                    <input id="confirm" type="text"  name="confirm" placeholder="confirm password" required="required">
                </p>

                  
                  </p>
                <p class="medium">
                    <label for="email" class="required">Email</label>
                    <input id="email" type="email" name="email" placeholder="exemple@exemple.com" required="required">
                </p>
 
                <p class="label">
                    <label class="required">Classe</label>
                </p>
                <p>
                	<select name="choix">
    				<option value="choix1">B1</option>
    				<option value="choix2">B2</option>
   	 				<option value="choix3">B3</option>
    				<option value="choix4">I4</option>
    				<option value="choix4">I5</option>
					</select>
                	
                </p>

                <p class="label">
                	<label class="required">Classe</label>
                </p>
                
                    
                <p id="submit">
                    <input type="submit" value="S'inscrire">
                </p>
            </form>
        </div>
    </body>
</html>
