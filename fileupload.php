<!-- tuto => https://phpcodeur.net/articles/php/upload -->

<?php

session_start();

include("idbdd.php");

$nom_cours = filter_input(INPUT_POST, 'nom_cours', FILTER_SANITIZE_FULL_SPECIAL_CHARS);// enelever espace je sais pas quoi metrre comme filter

//verifier si  nom cours est pas deja pris

if( isset($_POST['upload']) ) // si formulaire soumis
{
    $content_dir = 'upload/'; // dossier où sera déplacé le fichier

    $tmp_file = $_FILES['fichier']['tmp_name'];

    if( !is_uploaded_file($tmp_file) )
    {
        exit("Le fichier est introuvable");
    }

    // on vérifie maintenant l'extension
    $type_file = $_FILES['fichier']['type'];

    if( !strstr($type_file, 'pdf'))
    {
        exit("Le fichier n'est pas au bon format");
    }

    // on copie le fichier dans le dossier de destination

    $date = date('Y-m-d H:i:s');
    $name_file = $nom_cours;
    
    /*$name_file = $_FILES['fichier']['name'];*/

    if( !move_uploaded_file($tmp_file, $content_dir . $name_file) )
    {
        exit("Impossible de copier le fichier dans $content_dir");
    }
    else
    {
    $insert_cours = 'INSERT INTO course (course_name,school_year) VALUES ("' .$nom_cours.'","'.$_SESSION['loggedin_class'].'");';
    $db->query($insert_cours);

    $groupid_file = $db->query('SELECT group_id FROM course WHERE course_name = "'.$nom_cours.'"');
    $groupid_file = $groupid_file->fetchColumn();

    $insert_file = 'INSERT INTO file (file_date,fk_userid_file,file_root,fk_groupid_file)
    VALUES ("' . $date . '","' . $_SESSION["loggedin_id"] . '","' .$content_dir. '","'.$groupid_file.'");';
    $db->query($insert_file);

    //$check_existing_user='SELECT file_id FROM file WHERE email="' . $email . '";';
    ///$result = $db->query($check_existing_user);
    //$res = $result->fetchColumn();

    //echo "Le fichier a bien été uploadé";
    //header('Refresh: 2;dashboard.php');
    header('Location: dashboard.php');

    }
}

?>