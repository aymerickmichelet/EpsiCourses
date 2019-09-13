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
  
    //Vérification du mdp
    if ($password != $confirm || empty($confirm))
    {
        $mdp_erreur = "Votre mot de passe et votre confirmation diffèrent, ou sont vides";
        $i++;
    } 
$prenom = filter_input(INPUT_POST, 'prenom', FILTER_SANITIZE_FULL_SPECIAL_CHARS);
$nom = filter_input(INPUT_POST, 'nom', FILTER_SANITIZE_FULL_SPECIAL_CHARS);
$email = filter_input(INPUT_POST, 'email', FILTER_SANITIZE_EMAIL);

$result = $db->query('SELECT MAX(user_id) FROM user');
$res = $result->fetchColumn()+1;





$insertquery = 'INSERT INTO user (user_id,name,last_name,email,password) VALUES (' . $res . ',"' . $nom . '","' . $prenom . '","' . $email . '","' . $password . '");';
echo $insertquery;
$db->query($insertquery);

//envoie bdd + verification etc


if ($i == 0){
	$_SESSION["loggedin"]=1;
	$_SESSION["user"]=$nom;
	//header('Location: index.php');
}





?>
