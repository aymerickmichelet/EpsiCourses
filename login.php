<?php
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
