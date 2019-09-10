<?php
//Cette fonction doit être appelée avant tout code html
session_start();

//On donne ensuite un titre à la page, puis on appelle notre fichier debut.php
$titre = "Index du forum";
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
				echo '<input type="submit" value="sign in">';
			else
				echo $_SESSION["user"];
		?>
	</form>
       

</body>
</html>
