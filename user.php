<?php
	include 'dbtools.php';
	if(isset($_GET['request']))
	{
		if($_GET['request'] == 'list')
		{
			echo userList($db);
		}
		else if ($_GET['request'] == 'add' && isset($_GET['username']) && isset($_GET['password']))
		{		
			newUser($db,$_GET['username'],$_GET['password']);
			echo userList($db);
		}
		else if($_GET['request'] == 'find' && (isset($_GET['id']) || isset($_GET['username'])))
		{
			if(isset($_GET['id']))
			{
				$user =getUserById($db,$_GET['id']);
			}
			else
			{
				$user = getUserByUsername($db,$_GET['username']);
			}
			echo json_encode($user);
		}
		else
		{
			$json['response']='ERROR';
			$json['debug']='error with get parameters';
			echo json_encode($json);
		}
	}
	else
	{
		$json['response']='ERROR';
		$json['debug']='error with get parameters';
		echo json_encode($json);
	}
?>
