<?php
session_start();
$titre = "PBJAN";
include("idbdd.php");
$dir    = 'upload/'; // le dossier ou il ya les fichiers uploads
$files1 = scandir($dir); // scandir perment de montrer le contenu du fichier et le retourne sous forme d'un tableau
$nbr = count($files1); // pour compter le nombre d'element dans le tableau
?>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="utf-8">
  <title>EpsiLearn</title>
  <meta content="width=device-width, initial-scale=1.0" name="viewport">
  <meta content="" name="keywords">
  <meta content="" name="description">

  <!-- Favicons -->
  <link href="img/favicon.png" rel="icon">
  <link href="img/apple-touch-icon.png" rel="apple-touch-icon">

  <!-- Google Fonts -->
  <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,700,700i|Raleway:300,400,500,700,800" rel="stylesheet">

  <!-- Bootstrap CSS File -->
  <link href="lib/bootstrap/css/bootstrap.min.css" rel="stylesheet">

  <!-- Libraries CSS Files -->
  <link href="lib/font-awesome/css/font-awesome.min.css" rel="stylesheet">
  <link href="lib/animate/animate.min.css" rel="stylesheet">
  <link href="lib/venobox/venobox.css" rel="stylesheet">
  <link href="lib/owlcarousel/assets/owl.carousel.min.css" rel="stylesheet">

  <!-- Main Stylesheet File -->
  <link href="css/style.css" rel="stylesheet">

  <!-- =======================================================
    Theme Name: TheEvent
    Theme URL: https://bootstrapmade.com/theevent-conference-event-bootstrap-template/
    Author: BootstrapMade.com
    License: https://bootstrapmade.com/license/
  ======================================================= -->
</head>

<body>

  <!--==========================
    Header
  ============================-->
  <header id="header">
    <div class="container">
      <nav id="nav-menu-container">
        <ul class="nav-menu">
        <?php
            if($_SESSION["loggedin"]!=1)
            {
                echo '<li class="buy-tickets"><a href="register_form.php" method="post">Register</a></li>';
                echo '<li class="buy-tickets"><a href="login_form.php" method="post">Log in</a></li>';
            }
            else
            {
                echo '<li class="buy-tickets"><a href="logout.php" method="post">Log out</a></li>';
                echo '<li class="buy-tickets"><a href="dashboard.php" method="post">Dashboard</a></li>';
                echo '<li class="buy-tickets"><a href="profil.php" method="post">'.$_SESSION['loggedin_name'].'.'.$_SESSION['loggedin_lastname'].'</a></li>'; /*profil.php*/
            }
        ?>
        </ul>
      </nav><!-- #nav-menu-container -->
    </div>
  </header><!-- #header -->

  <main id="main">
    <!--==========================
      Subscribe Section
    ============================-->
    <section id="subscribe">
      <div class="container wow fadeInUp">
        <div class="section-header">
          <h2>Upload a course</h2>
          <p>Be carful, just pdf's file are accepted to upload</p>
        </div>
        <form method="POST" action="upload.php">
          <div class="form-row justify-content-center">
            <div class="col-auto">
              <button type="submit">upload</button>                 <!-- upload -->
            </div>
          </div>
        </form>
      </div>
    </section>

    <!--==========================
      LOG Section
    ============================-->
    <section id="schedule" class="section-with-bg">
      <div class="container wow fadeInUp">
        <div class="section-header">
          <h2>Check courses</h2>
          <p>You can read, download and answer quiz questions</p>
        </div>
        <div class="tab-content row justify-content-center">
          <div role="tabpanel" class="col-lg-9 tab-pane fade show active" id="day-1">



<?php  


for ($i=2; $i < $nbr; $i++) {

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



	//echo '<a href="upload/'.$files1[$i].'" target="_blank">PDF</a>'; // lien du pdf


echo '<div class="row schedule-item">
              <div class="col-md-2">'.$course_date.'</div>
              <div class="col-md-10">
                <h4><a href="upload/'.$files1[$i].'"   <time>'.$course_name.'</time></a></h4>
                <p>';

switch($course_class){
  case 1:
    echo "Bachelor 1";
    break;
  case 2:
    echo "Bachelor 2";
    break;
  case 3:
    echo "Bachelor 3";
    break;
  case 4:
    echo "Engineer 1";
    break;
  case 5:
    echo "Engineer 2";
    break;
}

    echo ' | '.$user_name.''.$user_lastname.'</p>
    <p><li class="buy-tickets"><a href="question_form.php?groupid='.$groupid_file.'" method="post">Quizz</a></li></p>
  </div>
</div>';


        }

?>
     
        </div>
      </div>
    </section>
      </div>
    </section>

  </main>


  <!--==========================
    Footer
  ============================-->
  <footer id="footer">
    <div class="footer-top">
      <div class="container">
        <div class="row">
        </div>
      </div>
    </div>

    <div class="container">
      <div class="copyright">
        &copy; Copyright <strong>TheEvent</strong>. All Rights Reserved
      </div>
      <div class="credits">
  <a href="#" class="back-to-top"><i class="fa fa-angle-up"></i></a>

  <!-- JavaScript Libraries -->
  <script src="lib/jquery/jquery.min.js"></script>
  <script src="lib/jquery/jquery-migrate.min.js"></script>
  <script src="lib/bootstrap/js/bootstrap.bundle.min.js"></script>
  <script src="lib/easing/easing.min.js"></script>
  <script src="lib/superfish/hoverIntent.js"></script>
  <script src="lib/superfish/superfish.min.js"></script>
  <script src="lib/wow/wow.min.js"></script>
  <script src="lib/venobox/venobox.min.js"></script>
  <script src="lib/owlcarousel/owl.carousel.min.js"></script>

  <!-- Contact Form JavaScript File -->
  <script src="contactform/contactform.js"></script>

  <!-- Template Main Javascript File -->
  <script src="js/main.js"></script>
</body>

</html>
