<?php
	/*
		Creates a link to database, returns PDO statemennt as a variable
	*/
	function dbLink()
	{
		$db = 0;
        $ip = '172.20.10.7';
        $dbname = 'pfct';
        $username = 'aymnms';
        $password = 'weshalors';
		try
		{
			$db = new PDO('mysql:host = ' . $ip . ';dbname=' . $dbname,$username,$password);
		}
		catch(Exception $e)
		{
			die('error : ' . $e->getMessage());
		}
		return $db;
	}
	/*
		Returns the list of users as a JSON string
	*/
	function userList($db)
	{
		$query = 'SELECT * FROM users';
		$queryresult = $db->query($query);
		$user['id']='ayaya';
		$user=$queryresult->fetch();
		while($user['id'] != null)
		{
			$usernumber = $user['id'];
			$json[$usernumber]['id']=$usernumber;
			$json[$usernumber]['username']=$user['username'];
			$json[$usernumber]['password']=$user['password'];
			$json[$usernumber]['victories']=$user['victories'];
			$json[$usernumber]['defeats']=$user['defeats'];
			$usernumber++;
			$user=$queryresult->fetch();
		}
		return json_encode($json);
	}
	/*
		Returns an unused ID from the given table
	*/
	function newId($db,$table)
	{
		$query = 'SELECT MAX(id) FROM ' . $table . ';';
		$queryresult = $db->query($query);
		$res = $queryresult->fetchColumn()+1;
		return $res;
	}
	/*
		Creates a new user with a new ID, username, and password
	*/
	function newUser($db,$username,$password)
	{
		$query = 'INSERT INTO users(id,username,password,victories,defeats) VALUES (' . newId($db,'users') . ',"' . $username . '","' . $password . '",0,0);';
		$db->query($query);
	}
	/*
		SAFTWYEX = Select All From Table Where Y Equals X
	*/
	function saftwyex($db,$table,$y,$x)
	{
		$query = 'SELECT * FROM ' . $table . ' WHERE ' . $y . ' = ' . $x . ';';
		$res = $db->query($query);
		$res = $res->fetch();
		return $res;
	}
	/*
		Adds double quotes to the string
	*/
	function stringify($string)
	{
		$string = '"' . $string . '"';
		return $string;
	}
	function getUserById($db,$id)
	{
		$user = saftwyex($db,'users','id',$_GET['id']);
		if($user != FALSE)
		{
			$json['response']="OK";
			$json['user']['id']=$user['id'];
			$json['user']['username']=$user['username'];
			$json['user']['password']=$user['password'];
			$json['user']['victories']=$user['victories'];
			$json['user']['defeats']=$user['defeats'];
		}
		return $json;
	}
	function getUserByUsername($db,$username)
	{
		$user = saftwyex($db,'users','username',stringify($username));
		if($user != FALSE)
		{
			$json['response']="OK";
			$json['user']['id']=$user['id'];
			$json['user']['username']=$user['username'];
			$json['user']['password']=$user['password'];
			$json['user']['victories']=$user['victories'];
			$json['user']['defeats']=$user['defeats'];
		}
		else
		{
			$json['response']="ERROR";
			$json['debug']="no user found";
		}
		return $json;
	}
	$db = dbLink();
?>