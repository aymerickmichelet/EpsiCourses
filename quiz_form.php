<?php
session_start();
$titre="Sign in";
include("idbdd.php");


<<<<<<< HEAD
$result = $db->query('SELECT quest_id FROM question WHERE fk_groupid_question =' . $_SESSION['groupid'] . ';');
$res = $result->fetchAll(PDO::FETCH_COLUMN,0);
$questionid= array_rand($res,1);

$questioncontent=$db->query('SELECT quest FROM question WHERE quest_id =' . $res[$questionid] . ';');
$questioncontent=$questioncontent->fetchColumn();
=======
$groupid = $_GET['quiz_form'];
var_dump($groupid);
die();
$result = $db->query('SELECT COUNT(quest_id) FROM question WHERE fk_groupid_question =' . . ';');
$res = $result->fetchColumn();


$questionid=$db->query('SELECT quest_id FROM question WHERE fk_groupid_question =' . . ';');

$rand=random_int(1,$res);
for($x=0;$x<$rand;$x++)
{
	$questionid = $questionid->fetch();
}
$questionid=$questionid->fetchColumn();
$questioncontent=$db->query('SELECT quest FROM question WHERE quest_id =' . $questionid . ';');
>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe


$_SESSION['previous_question_id']=$questionid;

$answerid=$rand *4 -3;
<<<<<<< HEAD
$answers=$db->query('SELECT ans_id,ans FROM answer WHERE fk_questionid_answer =' . $res[$questionid] . ';');
$answers = $answers->fetchAll(PDO::FETCH_ASSOC);

/*$answerid++;
=======
$answer1=$db->query('SELECT ans FROM answer WHERE ans_id =' . $answerid . ';');
$answer1 = $answer1->fetchColumn();

$answerid++;
>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe
$answer2=$db->query('SELECT ans FROM answer WHERE ans_id =' . $answerid . ';');
$answer2 = $answer2->fetchColumn();

$answerid++;
$answer3=$db->query('SELECT ans FROM answer WHERE ans_id =' . $answerid . ';');
$answer3 = $answer3->fetchColumn();

$answerid++;
$answer4=$db->query('SELECT ans FROM answer WHERE ans_id =' . $answerid . ';');
<<<<<<< HEAD
$answer4 = $answer4->fetchColumn();*/
=======
$answer4 = $answer4->fetchColumn();
>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe




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
          <h2>Quizz</h2>
        </div>
        <form method="POST" action="quiz.php">
        <center><h3 style="color:#fff">Select the correct answers</h3></center>
          <div class="form-row justify-content-center">
            <h4 style="color:#fff">Note that the number of valid answers varies between 0 and 4</h4>
<<<<<<< HEAD
            <?php foreach($answers as $answer)
            {
			?>
            <div class="form-group col-md-6">
              <input name="answer1" type="text" class="form-control" value="<?=$answer['ans']; ?>" readonly>
              <center><input name="useranswer[]" type="checkbox" value="<?=$answer['ans_id']; ?>"></center>
            </div>
            <?php } ?>
            <!-- <div class="form-group col-md-6">
=======
            <div class="form-group col-md-6">
              <input name="answer1" type="text" class="form-control" value="<?php echo $answer1; ?>" readonly>
              <center><input name="useranswer[]" type="checkbox" value="1"></center>
            </div>
            <div class="form-group col-md-6">
>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe
              <input name="answer2" type="text" class="form-control" value="<?php echo $answer2; ?>" readonly>
              <center><input name="useranswer[]" type="checkbox" value="2"></center>
            </div>
            <div class="form-group col-md-6">
              <input name="answer3" type="text" class="form-control" value="<?php echo $answer3; ?>" readonly>
              <center><input name="useranswer[]" type="checkbox" value="3"></center>
            </div>
            <div class="form-group col-md-6">
              <input name="answer4" type="text" class="form-control" value="<?php echo $answer4; ?>" readonly>
              <center><input name="useranswer[]" type="checkbox" value="4"></center>
<<<<<<< HEAD
            </div> -->
=======
            </div>
>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe
            <div class="col-md-6">
              <input name="question" type="text" class="form-control" value="<?php echo $questioncontent; ?>" readonly>
            </div>
          </div>
          <div class="col-auto"><button type="submit">Submit answers</button></div>
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
