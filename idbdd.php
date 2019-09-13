<?php
try
{
$db = new PDO('mysql:host=localhost;dbname=workshop', 'aymnms', 'weshalors');
}
catch (Exception $e)
{
        die('Erreur : ' . $e->getMessage());
}
?>


