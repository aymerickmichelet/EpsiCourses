<?php
    include 'dbtools.php';
	if(isset($_GET['id']))
	{
        $json['response'] = 'OK';
        $query = 'SELECT id,found FROM matchmaking';
        $res = $db->query($query);
	    $res = $res->fetch();
        if($res == FALSE)
        {
            $query = 'INSERT INTO matchmaking(id,found) VALUES (' . $_GET['id'] . ',0);';
            $db->query($query);
            $json['status']='wait';
            $json['debug']='got into matchmaking';
        }
        else
        {
            if($res['id'] == $_GET['id'])
            {
                if($res['found'] != 0)
                {
                    $query = 'DELETE FROM matchmaking WHERE id=' . $res['id'] . ';';
                    $db->query($query);
                    $json['status'] = 'found';
                    $json['game'] = $res['found'];
                    $json['userrole'] = 1;
                    $json['debug'] = 'game found';
                }
                else
                {
                    $json['status']='wait';
                    $json['debug']='still waiting for an opponent';
                }
            }
            else
            {
                if($res['found'] == 0)
                {
                    $gameid = newId($db,'game');
                    $query = 'UPDATE matchmaking SET found = ' . $gameid . ' WHERE id=' . $res['id'] . ';';
                    $db->query($query);

                    
		            $query = 'INSERT INTO game(id,user1,user2,user1move,user2move) VALUES (' . $gameid . ',' . $res['id'] . ',' . $_GET['id'] . ',0,0);';
		            $db->query($query);
                    $json['status'] = 'found';
                    $json['game'] = $gameid;
                    $json['userrole'] = 2;
                    $json['debug'] = 'game found';
                }  
                else
                {
                    $json['response'] = 'ERROR';
                    $json['debug'] = 'game has already been created and you should currently be playing';
                }
            }
        }
    }
	else
	{
        $json['response'] = 'ERROR';
        $json['debug'] = 'error with GET parameters. make sure to provide your user ID';
    }
    echo json_encode($json);
?>
