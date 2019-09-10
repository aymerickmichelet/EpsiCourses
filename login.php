<?php

session_start();


$titre = "PBJAN";
include("idbdd.php");
include("debut.php");
include("menu.php");
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
            <h1>Se connecter à PBJAN</h1>
            <h4>Bienvenue</h4>
            <form method="POST" action="test_login.php">
            	
 					<p class="medium">
                    <label for="email" class="required">Email</label>
                    <input id="email" type="email" name="email" placeholder="exemple@exemple.com" required="required" <?php if ($_GET['error'] == 'login') echo 'value="'.$_SESSION["email_error"].'"'; ?>>
                </p>





                <p class="label">
                    <label for="password" class="required">password</label>
                </p>
                <p class="medium">
                    <input id="password" type="text"  name="password" placeholder="password" required="required">
                </p>
                <?php 
                if ($_GET['error'] == 'login') {
                            echo '<p style = "color:red">Your name or password is invalid</p>';
                        }


                 ?>
             
    
                  
               
               
                
                    
                <p id="submit">
                    <input type="submit" value="S'inscrire">
                </p>
            </form>
        </div>
    </body>
</html>
