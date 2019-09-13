<?php
<<<<<<< HEAD
session_start();
=======
<<<<<<< HEAD
session_start();
=======

session_start();


>>>>>>> 1c6376cef9d67ae7dfa836e19e21fbb2b3ba6497
>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe
$titre = "PBJAN";
include("idbdd.php");
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
<<<<<<< HEAD

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

  <!--==========================
    Intro Section
  ============================-->
  <section id="intro">
    <div class="intro-container wow fadeIn">
      <h1 class="mb-4 pb-0">Epsi<span>Learn</span></h1>
      <p class="mb-4 pb-0">09-13 September, EPSI Paris</p>
      <!-- <a href="https://www.youtube.com/watch?v=wZZ7oFKsKzY&t=3303s" class="venobox play-btn mb-4" data-vbtype="video"
        data-autoplay="true"></a> -->
      <a href="#about" class="about-btn scrollto">About The Website</a>
    </div>
  </section>

  <main id="main">

    <!--==========================
      About Section
    ============================-->
    <section id="about">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <h2>About The Website</h2>
            <p>Revision platform powered by, and for students. Each student can put a course online, classify it in a category, and add a number of questions based on a multiple choice system. Everyone has access to the course, and can try to answer the MCQ provided that it contributes to the enrichment. We must therefore create a new question answer each time we want to take the quiz.</p>
          </div>
        </div>
      </div>
    </section>

    <!--==========================
      LOG Section
    ============================-->
    <section id="schedule" class="section-with-bg">
      <div class="container wow fadeInUp">
        <div class="section-header">
          <h2>Research project</h2>
          <p>Log of the week</p>
        </div>

        <ul class="nav nav-tabs" role="tablist">
          <li class="nav-item">
            <a class="nav-link active" href="#day-1" role="tab" data-toggle="tab">Day 1</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#day-2" role="tab" data-toggle="tab">Day 2</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#day-3" role="tab" data-toggle="tab">Day 3</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#day-4" role="tab" data-toggle="tab">Day 4</a>
          </li>
        </ul>

        <div class="tab-content row justify-content-center">

=======
<<<<<<< HEAD
=======
	<form name="button_signin" action="signin.php" method="post">

		<?php
			if($_SESSION["loggedin"]!=1)
			{
				echo '<input type="submit" value="sign in">';
				$lien_connexion = "'login.php'";
				echo '<input type ="button" value ="login" onclick="location.href='.$lien_connexion.'">';
			}


			else
			{
				echo $_SESSION["user"];
				$lien_deconnexion = "'logout.php'";
			    echo '<input type ="button" value ="deconnexion" onclick="location.href='.$lien_deconnexion.'">';
			}
		?>
	</form>
       
>>>>>>> 1c6376cef9d67ae7dfa836e19e21fbb2b3ba6497

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

  <!--==========================
    Intro Section
  ============================-->
  <section id="intro">
    <div class="intro-container wow fadeIn">
      <h1 class="mb-4 pb-0">Epsi<span>Learn</span></h1>
      <p class="mb-4 pb-0">09-13 September, EPSI Paris</p>
      <!-- <a href="https://www.youtube.com/watch?v=wZZ7oFKsKzY&t=3303s" class="venobox play-btn mb-4" data-vbtype="video"
        data-autoplay="true"></a> -->
      <a href="#about" class="about-btn scrollto">About The Website</a>
    </div>
  </section>

  <main id="main">

    <!--==========================
      About Section
    ============================-->
    <section id="about">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <h2>About The Website</h2>
            <p>Revision platform powered by, and for students. Each student can put a course online, classify it in a category, and add a number of questions based on a multiple choice system. Everyone has access to the course, and can try to answer the MCQ provided that it contributes to the enrichment. We must therefore create a new question answer each time we want to take the quiz.</p>
          </div>
        </div>
      </div>
    </section>

    <!--==========================
      LOG Section
    ============================-->
    <section id="schedule" class="section-with-bg">
      <div class="container wow fadeInUp">
        <div class="section-header">
          <h2>Research project</h2>
          <p>Log of the week</p>
        </div>

        <ul class="nav nav-tabs" role="tablist">
          <li class="nav-item">
            <a class="nav-link active" href="#day-1" role="tab" data-toggle="tab">Day 1</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#day-2" role="tab" data-toggle="tab">Day 2</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#day-3" role="tab" data-toggle="tab">Day 3</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#day-4" role="tab" data-toggle="tab">Day 4</a>
          </li>
        </ul>

        <div class="tab-content row justify-content-center">

>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe
          <!-- Schdule Day 1 -->
          <div role="tabpanel" class="col-lg-9 tab-pane fade show active" id="day-1">

            <div class="row schedule-item">
              <div class="col-md-2"><time>09:30 AM -<br>10:00 AM</time></div>
              <div class="col-md-10">
                <h4>Kick-off of the workshop by the national educational team EPSI/WIS,</h4>
                <p>Award ceremony of the best workshop campus 2019,</p>
                <p>Presentation of the  workshop 1 –EPSI B2 and WIS2 2019-2020,</p>
                <p>General explanation of the week EPSI/WIS.</p>
              </div>
            </div>

            <div class="row schedule-item">
              <div class="col-md-2"><time>10:00 AM -<br>10:30 AM</time></div>
              <div class="col-md-10">
                <h4>Local team repartition by the coaches</h4>
              </div>
            </div>

            <div class="row schedule-item">
              <div class="col-md-2"><time>10:30 AM -<br>18:00 PM</time></div>
              <div class="col-md-10">
                <h4>Searching ideas & role distribution</h4>
              </div>
            </div>
          </div>
          <!-- End Schdule Day 1 -->

          <!-- Schedule Day 2 -->
          <div role="tabpanel" class="col-lg-9  tab-pane fade" id="day-2">

            <div class="row schedule-item">
              <div class="col-md-3"><time>10:00 AM - <br> 01:00PM</time></div>
              <div class="col-md-9">
                <h4>Discussing about the website's features and start working on the database and the website <!-- <span>Brenden Legros</span> --></h4>
                <!-- <p>Facere provident incidunt quos voluptas.</p> -->
              </div>
            </div>
        

            <div class="row schedule-item">
              <div class="col-md-2"><time>02:00 PM -<br>06:00 PM</time></div>
              <div class="col-md-10">
                <div class="speaker">
                  <!-- <img src="img/speakers/2.jpg" alt="Hubert Hirthe"> -->
                </div>
                <h4>Searching for the appropriate templates for our website <!-- <span>Hubert Hirthe</span> --></h4>
                <!-- <p>Maiores dignissimos neque qui cum accusantium ut sit sint inventore.</p> -->
              </div>
            </div>

            
          </div>
          <!-- End Schdule Day 2 -->

          <!-- Schdule Day 3 -->
          <div role="tabpanel" class="col-lg-9  tab-pane fade" id="day-3">

            <div class="row schedule-item">
              <div class="col-md-2"><time>10:00 AM - <br> 01:00PM</time></div>
              <div class="col-md-10">
                <div class="speaker">
                  <!-- <img src="img/speakers/2.jpg" alt="Hubert Hirthe"> -->
                </div>
                <h4>Testing the website <!-- <span>Hubert Hirthe</span> --></h4>
                <p>We tested the website's different features as by logging-in and by signing-in, meanwhile testing the database</p>
              </div>
            </div>
          

            <div class="row schedule-item">
              <div class="col-md-2"><time>02:00 PM -<br>06:00 PM</time></div>
              <div class="col-md-10">
                <div class="speaker">
                  <!-- <img src="img/speakers/3.jpg" alt="Cole Emmerich"> -->
                </div>
                <h4>Fixing some problems<!-- <span>Cole Emmerich</span> --></h4>
                <p>We faced different problems on the database and displaying informations in the website   </p>
              </div>
            </div>

            
          </div> 
          <!-- End Schdule Day 3 -->


          <!--Schedule Day 4-->
          <div role="tabpanel" class="col-lg-9  tab-pane fade" id="day-4">

            <div class="row schedule-item">
              <div class="col-md-2"><time>09:00 AM - <br> 05:00PM</time></div>
              <div class="col-md-10">
                <div class="speaker">
                  <!-- <img src="img/speakers/2.jpg" alt="Hubert Hirthe"> -->
                </div>
                <h4>Finalising the website <!-- <span>Hubert Hirthe</span> --></h4>
                <!-- <p>Voluptatem et alias dolorum est aut sit enim neque veritatis.</p> -->
              </div>
            </div>
          

            <div class="row schedule-item">
              <div class="col-md-2"><time>05:00 PM -<br>07:00 PM</time></div>
              <div class="col-md-10">
                <div class="speaker">
                  <!-- <img src="img/speakers/3.jpg" alt="Cole Emmerich"> -->
                </div>
                <h4>Final presentation<!-- <span>Cole Emmerich</span> --></h4>
                <!-- <p>We faced different problems on the database and displaying informations in the website   </p> -->
              </div>
            </div>

            
          </div> 
          <!--End Schedule Day 4-->
        </div>
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
