<?php
session_start();
$titre = "PBJAN";
include("idbdd.php");
include("debut.php");
include("menu.php");




$email = $_POST['email'];
$password = $_POST['password'];

$email = filter_input(INPUT_POST, 'email', FILTER_SANITIZE_EMAIL);


// test du mail

$requete = $db->query('SELECT email FROM user WHERE email= "'.$email.'"');

if ($requete->fetch())
	{
		echo "ok";


	}


else
	 {
	 	$_SESSION["email_error"]=$email;
	 	header('location:login.php?error=login');	
	 }





?> 