<?php
session_start();
$titre = "PBJAN";
include("idbdd.php");
include("debut.php");
include("menu.php");
    
<<<<<<< HEAD

=======
  	foreach($_POST['correctanswer'] as $ticked)
  		echo $ticked;
>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe
  	

	$question = filter_input(INPUT_POST, 'question', FILTER_SANITIZE_FULL_SPECIAL_CHARS);
	
	$answer1 = filter_input(INPUT_POST, 'answer1', FILTER_SANITIZE_FULL_SPECIAL_CHARS);
	$answer2 = filter_input(INPUT_POST, 'answer2', FILTER_SANITIZE_FULL_SPECIAL_CHARS);
	$answer3 = filter_input(INPUT_POST, 'answer3', FILTER_SANITIZE_FULL_SPECIAL_CHARS);
	$answer4 = filter_input(INPUT_POST, 'answer4', FILTER_SANITIZE_FULL_SPECIAL_CHARS);

<<<<<<< HEAD
=======
	echo $answer1;
  	echo $answer2;
	echo $answer3;
	echo $answer4;
	echo $question;
>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe
		
	for($count = 1; $count <=4 ; $count++)
	{
		if(in_array($count,$_POST['correctanswer']))
		{
			$truthvalues[$count-1]=1;
		}
		else
		{
			$truthvalues[$count-1]=0;
		}
	}
<<<<<<< HEAD
=======
	foreach($truthvalues as $number)
	{
		echo $number; 
	}
>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe
	


//envoie bdd + verification etc


		//insertion de la question
		$result = $db->query('SELECT MAX(quest_id) FROM question');
		$res = $result->fetchColumn()+1;
<<<<<<< HEAD
		$insertquery = 'INSERT INTO question (quest_id,quest,question_valid,fk_groupid_question) VALUES ('.$res.',"'.$question.'",0,' . $_SESSION['groupid'] . ');';
=======
		$insertquery = 'INSERT INTO question (quest_id,quest,question_valid,fk_groupid_question) VALUES ('.$res.',"'.$question.'",0,12);';
		//echo $insertquery;
>>>>>>> f72e3182b27e64c5476e6310f7c937ea02e1bffe
		$db->query($insertquery);

		//insertion des réponses
		
		$answerid=$res*4-3;
		$insertquery= 'INSERT INTO answer(ans_id,ans,answer_valid,fk_questionid_answer) VALUES (' . $answerid . ',"' . $answer1 . '",' . $truthvalues[0] . ',' . $res . ');';
		$db->query($insertquery);
		
		$answerid++;
		$insertquery= 'INSERT INTO answer(ans_id,ans,answer_valid,fk_questionid_answer) VALUES (' . $answerid . ',"' . $answer2 . '",' . $truthvalues[1] . ',' . $res . ');';
		$db->query($insertquery);
		
		$answerid++;
		$insertquery= 'INSERT INTO answer(ans_id,ans,answer_valid,fk_questionid_answer) VALUES (' . $answerid . ',"' . $answer3 . '",' . $truthvalues[2] . ',' . $res . ');';
		$db->query($insertquery);
		
		$answerid++;
		$insertquery= 'INSERT INTO answer(ans_id,ans,answer_valid,fk_questionid_answer) VALUES (' . $answerid . ',"' . $answer4 . '",' . $truthvalues[3] . ',' . $res . ');';
		$db->query($insertquery);
		

		header('Location: quiz_form.php');

	




?>
