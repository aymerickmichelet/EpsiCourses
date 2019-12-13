<?php
    include 'dbtools.php';
    if(isset($_GET['id'] , $_GET['userrole'], $_GET['gameid'], $_GET['request'] ))
    {
        $usercolumn = 'user' . $_GET['userrole'];
        $opponentmovecolumn = 'user' . ($_GET['userrole']%2+1) . 'move';
        $usermovecolumn = $usercolumn . 'move';

        $query='SELECT * FROM game WHERE id = ' . $_GET['gameid'] . ' AND ' . $usercolumn . ' = ' . $_GET['id'] . ';';
        $res = $db->query($query);
        $res = $res->fetch();
        if($res != FALSE)
        {
            if($_GET['request'] == 'play')
            {
                if($res[$usermovecolumn] == 0)
                {
                    if(isset($_GET['move'] ) && $_GET['move'] <=3 && $_GET['move'] >=1)
                    {
                        $json['response'] = 'OK';
                        if($res[$opponentmovecolumn] !=0)
                        {
                            $json['status']='gameover';
                            $json['opponentmove'] =  $res[$opponentmovecolumn];
                            $json['resultcode'] = ($_GET['move'] - $res[$opponentmovecolumn]) %3;
                            if($json['resultcode'] < 0)
                            {
                                $json['resultcode'] += 3;
                            }
                            if($json['resultcode'] == 0)
                            {
                                $json['result'] = 'draw';
                            }
                            else if($json['resultcode'] == 1)
                            {
                                $json['result'] = 'victory';
                                $query='SELECT victories FROM users WHERE id=' . $_GET['id'] . ';';
                                $res = $db->query($query);
                                $res = $res->fetch();
                                $victories = $res['victories']+1;
                                $query='UPDATE users SET victories = ' . $victories . ' WHERE id=' . $_GET['id'] . ';';
                                $db->query($query);
                            }
                            else if($json['resultcode'] == 2)
                            {
                                $json['result'] = 'defeat';
                                $query='SELECT defeats FROM users WHERE id=' . $_GET['id'] . ';';
                                $res = $db->query($query);
                                $res = $res->fetch();
                                $defeats = $res['defeats']+1;
                                $query='UPDATE users SET defeats = ' . $defeats . ' WHERE id=' . $_GET['id'] . ';';
                                $db->query($query);
                            }
                        }
                        else
                        {
                            $json['status']='wait';
                        }
                        $query = 'UPDATE game SET ' . $usermovecolumn . ' = ' . $_GET['move'] . ' WHERE id = ' . $_GET['gameid'] . ' AND ' . $usercolumn . ' = ' . $_GET['id'] . ';';
                        $db->query($query);

                    }
                    else
                    {
                        $json['response'] = 'ERROR';
                        $json['debug'] = 'you are trying to play without submitting a move / an invalid one';   
                    }
                }
                else
                {
                    $json['response'] = 'ERROR';
                    $json['debug'] = 'you have already submitted your move';
                }
            }
            if($_GET['request'] == 'check')
            {
                if($res[$usermovecolumn] == 0)
                {
                    $json['response']='ERROR';
                    $json['debug']='you have to submit a move before checking the results';
                }
                else
                {
                    $json['response'] = 'OK';
                    if($res[$opponentmovecolumn] !=0)
                    {
                        $json['status']='gameover';
                        $json['opponentmove'] =  $res[$opponentmovecolumn];
                        $json['resultcode'] = ($res[$usermovecolumn] - $res[$opponentmovecolumn]) %3;
                        if($json['resultcode'] < 0)
                        {
                            $json['resultcode'] += 3;
                        }
                        if($json['resultcode'] == 0)
                        {
                            $json['result'] = 'draw';
                        }
                        else if($json['resultcode'] == 1)
                        {
                            $json['result'] = 'victory';
                            $query='SELECT victories FROM users WHERE id=' . $_GET['id'] . ';';
                            $res = $db->query($query);
                            $res = $res->fetch();
                            $victories = $res['victories']+1;
                            $query='UPDATE users SET victories = ' . $victories . ' WHERE id=' . $_GET['id'] . ';';
                            $db->query($query);
                        }
                        else
                        {
                            $json['result'] = 'defeat';
                            $query='SELECT defeats FROM users WHERE id=' . $_GET['id'] . ';';
                            $res = $db->query($query);
                            $res = $res->fetch();
                            $defeats = $res['defeats']+1;
                            $query='UPDATE users SET defeats = ' . $defeats . ' WHERE id=' . $_GET['id'] . ';';
                            $db->query($query);
                        }
                        $query = 'DELETE FROM game WHERE id= ' . $_GET['gameid'] . ';';
                        $db->query($query);
                    }
                    else
                    {
                        $json['status']='wait';
                    }
                }
            }
        }
        else
        {
            $json['response'] = 'ERROR';
            $json['debug'] = 'you are either looking for a game that does not exist, or have provided erroneous GET parameters';
        }
    }
    else
    {
        $json['response']='ERROR';
        $json['debug']='not enough GET parameters provided. could not identify game';
    }
    echo json_encode($json);
?>