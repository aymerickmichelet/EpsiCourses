<?php

session_start();


$titre = "PBJAN";
include("idbdd.php");


$dir    = 'upload/'; // le dossier ou il ya les fichiers uploads

$files1 = scandir($dir); // scandir perment de montrer le contenu du fichier et le retourne sous forme d'un tableau

//print_r($files1);

$nbr = count($files1); // pour compter le nombre d'element dans le tableau



for ($i=2; $i <$nbr ; $i++) {
					// boucle for qui commence par 2 car les deux premiers elements du tableau scandir sont vide 


	$course_name = $db->query('SELECT course_name FROM course WHERE course_name = "'.$files1[$i].'"');
    $course_name = $course_name->fetchColumn();


    $groupid_file = $db->query('SELECT group_id FROM course WHERE course_name = "'.$files1[$i].'"');
    $groupid_file = $groupid_file->fetchColumn();
    $course_date = $db->query('SELECT file_date FROM file WHERE fk_groupid_file = "'.$groupid_file.'"'); //possible de faire en une fois
    $course_date = $course_date->fetchColumn();


    $course_class = $db->query('SELECT school_year FROM course WHERE course_name = "'.$files1[$i].'"');
    $course_class = $course_class->fetchColumn();


    $userid = $db->query('SELECT fk_userid_file FROM file WHERE fk_groupid_file = "'.$groupid_file.'"');
    $userid = $userid->fetchColumn();
    $user_name = $db->query('SELECT name FROM user WHERE user_id = "'.$userid.'"');
    $user_name = $user_name->fetchColumn();
    $user_lastname = $db->query('SELECT last_name FROM user WHERE user_id = "'.$userid.'"');
    $user_lastname = $user_lastname->fetchColumn();






	echo $course_name; //nom du fichier
	echo $course_date;
	echo $course_class;
	echo $user_name;
	echo $user_lastname;
	echo '<a href="upload/'.$files1[$i].'" target="_blank">PDF</a>'; // lien du pdf
	echo "<br>";

	
}





?>

<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
	<form action="upload.php">

	<button type="submit">upload</button>
</form>
</body>
</html>