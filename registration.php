<?php
session_start();
    $i = 0;
    $temps = time(); 
    $pseudo= $_POST['pseudo'];
    $email = $_POST['email'];
    $password = sha1($_POST['password']);
    $confirm = sha1($_POST['confirm']);
  
    //Vérification du mdp
    if ($password != $confirm || empty($confirm))
    {
        $mdp_erreur = "Votre mot de passe et votre confirmation diffèrent, ou sont vides";
        $i++;

    } 
$pseudo = filter_input(INPUT_POST, 'pseudo', FILTER_SANITIZE_FULL_SPECIAL_CHARS);
$email = filter_input(INPUT_POST, 'email', FILTER_SANITIZE_EMAIL);

//envoie bdd + verification etc




if ($i == 0){
	$_SESSION["loggedin"]=1;
	$_SESSION["user"]=$pseudo;
	header('Location: index.php');
}





?>
