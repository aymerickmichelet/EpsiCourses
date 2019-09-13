<?php
session_start();
$titre = "PBJAN";
include("idbdd.php");
include("debut.php");
include("menu.php");
    $i = 0;
    $temps = time(); 
    $prenom= $_POST['prenom'];
    $nom= $_POST['nom'];
    $email = $_POST['email'];
    $password = sha1($_POST['password']);
    $confirm = sha1($_POST['confirm']);
    $class = $_POST['choix'];
  	
    //Vérification du mdp
    if ($password != $confirm || empty($confirm))
    {
        echo "error with password format";
        $i++;
    } 
	$prenom = filter_input(INPUT_POST, 'prenom', FILTER_SANITIZE_FULL_SPECIAL_CHARS);
	$nom = filter_input(INPUT_POST, 'nom', FILTER_SANITIZE_FULL_SPECIAL_CHARS);
	$email = filter_input(INPUT_POST, 'email', FILTER_SANITIZE_EMAIL);

	$check_existing_user='SELECT email FROM user WHERE email="' . $email . '";';
	$result = $db->query($check_existing_user);
	$res = $result->fetchColumn();
	if($res == $email)
	{
		echo 'email already registered';
		$lien_connexion = "'login_form.php'";
		echo '<input type ="button" value ="login" onclick="location.href='.$lien_connexion.'">';
		$i++;
	}


//envoie bdd + verification etc


	if ($i == 0)
	{
		$result = $db->query('SELECT MAX(user_id) FROM user');
		$res = $result->fetchColumn()+1;
		$insertquery = 'INSERT INTO user (user_id,name,last_name,email,password,user_class) VALUES (' . $res . ',"' . $prenom . '","' . $nom . '","' . $email . '","' . $password . '",' . $class . ');';
		//echo $insertquery;
		$db->query($insertquery);
		header('Location: login_form.php');
	}





?>
