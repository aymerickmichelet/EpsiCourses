<?php

session_start();


$titre = "PBJAN";
include("idbdd.php");
include("debut.php");
include("menu.php");
?>


<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
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
       

</body>
</html>
