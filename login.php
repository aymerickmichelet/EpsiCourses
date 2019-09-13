<?php
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe
session_start();
$titre = "PBJAN";
include("idbdd.php");


$email = filter_input(INPUT_POST, 'email', FILTER_SANITIZE_EMAIL);
$password = filter_input (INPUT_POST,'password',FILTER_SANITIZE_ENCODED);
$password = sha1($password);

// test du mail

$requete = $db->query('SELECT * FROM user WHERE email= "'.$email.'" AND password= "' . $password . '";');
$user_data = $requete->fetch();

if ($user_data['email']==$email && $user_data['password']==$password)
	{
		$_SESSION['loggedin_id']=$user_data['user_id'];
		$_SESSION['loggedin_name']=$user_data['name'];
		$_SESSION['loggedin_lastname']=$user_data['last_name'];
		$_SESSION['loggedin_password'] = $password;
		$_SESSION['loggedin_email'] = $email;
		$_SESSION['loggedin_class'] = $user_data['user_class'];
		
		
		$_SESSION['loggedin']=1;
		$_SESSION['question_number']=0;
		header('location:index.php');
	}
else
	{
		$_SESSION["email_error"]=$email;
	 	header('location:login_form.php?error=login');	
	}
?> 
<<<<<<< HEAD
=======
=======

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
>>>>>>> 1c6376cef9d67ae7dfa836e19e21fbb2b3ba6497
>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe
