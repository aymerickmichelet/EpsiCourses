<?php
session_start();
$titre="Sign in";
include("idbdd.php");
if ($id!=0) erreur(ERR_IS_CO);
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
    Intro Section
  ============================-->
  <section id="subscribe">
      <div class="container wow fadeInUp">
        <div class="section-header">
          <h2>Submit a question</h2>
        </div>
        <form method="POST" action="question.php">
          <div class="form-row justify-content-center">
            <h3 style="color:#fff">Submit a new question before taking the quiz</h3>
            <h4 style="color:#fff">Tick the checkboxes which correspond to a valid answer</h4>
            <div class="form-group col-md-6">
              <input name="answer1" type="text" class="form-control" placeholder="1st possible answer" />
              <center><input name="correctanswer[]" type="checkbox" value="1"></center>
            </div>
            <div class="form-group col-md-6">
              <input name="answer2" type="text" class="form-control" placeholder="2nd possible answer" />
              <center><input name="correctanswer[]" type="checkbox" value="2"></center>
            </div>
            <div class="form-group col-md-6">
              <input name="answer3" type="text" class="form-control" placeholder="3rd possible answer" />
              <center><input name="correctanswer[]" type="checkbox" value="3"></center>
            </div>
            <div class="form-group col-md-6">
              <input name="answer4" type="text" class="form-control" placeholder="4th possible answer" />
              <center><input name="correctanswer[]" type="checkbox" value="4"></center>
            </div>
            <div class="col-md-6">
              <input name="question" type="text" class="form-control" placeholder="Question" />
            </div>
          </div>
          <div class="col-auto"><button type="submit">Submit question</button></div>
        </form>
      </div>
    </section><!-- #contact -->

  <main id="main">

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
