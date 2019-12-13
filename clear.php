<?php
    include 'dbtools.php';
    $db->query('delete from matchmaking;delete from game;update users set defeats=0;update users set victories=0;');
?>