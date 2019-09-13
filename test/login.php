<?php
session_start();
$titre = "PBJAN";
include("idbdd.php");
include("debut.php");
include("menu.php");




$email = $_POST['email'];
$password = $_POST['password'];


$email = filter_input(INPUT_POST, 'email', FILTER_SANITIZE_EMAIL);
$password = filter_input (INPUT_POST,'password',FILTER_SANITIZE_ENCODED);

$password = sha1($password);

// test du mail

$requete = $db->query('SELECT * FROM user WHERE email= "'.$email.'" AND password= "' . $password . '";');

$user_data = $requete->fetch();


if ($user_data['email']==$email && $user_data['password']==$password)
	{
		$_SESSION['loggedin_id']=$user_data['user_id'];
		$_SESSION['loggedin']=1;
		header('location:index.php');
	}


else
	 {
	 	$_SESSION["email_error"]=$email;
	 	header('location:login_form.php?error=login');	
	 }





?> 
