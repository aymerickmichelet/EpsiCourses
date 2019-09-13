<?php
	session_start();
	include("idbdd.php");
	
	$answerid=$_SESSION['previous_question_id']*4-3;
	for($count=0;$count<4;$count++)
	{
		$dataq = $db->query('SELECT answer_valid FROM answer WHERE ans_id=' . $answerid. ';');
		$correctanswers[$count]=$dataq->fetchColumn();
		$answerid++;
	}
	for($count=1;$count<=4;$count++)
	{
		if(in_array($count,$_POST['useranswer']))
			$newuseranswer[$count-1]=1;
		else
			$newuseranswer[$count-1]=0;
	}
	$userscore=0;
	for($count=0;$count<4;$count++)
	{
		if($newuseranswer[$count]==$correctanswers[$count])
			$userscore++;
	}
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
      Subscribe Section
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
    <section id="subscribe">
      <div class="container wow fadeInUp">
        <div class="section-header">
          <h2>Quiz</h2>
          <p>Your score is <?php echo $userscore?>/4</p>s
        </div>
      </div>
    </section>
  </main>


  <!--==========================
    Footer
  ============================-->
  <footer id="footer">
    <div class="container">
      <div class="copyright">
        &copy; Copyright <strong>TheEvent</strong>. All Rights Reserved
      </div>
      <div class="credits">
        <!--
          All the links in the footer should remain intact.
          You can delete the links only if you purchased the pro version.
          Licensing information: https://bootstrapmade.com/license/
          Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/buy/?theme=TheEvent
        -->
        Designed by <a href="https://bootstrapmade.com/">BootstrapMade</a>
      </div>
    </div>
  </footer><!-- #footer -->

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
