<?php
$server= 'localhost';
$username = 'root';
$password = 'root';
$conn = mysql_connect($server, $username, $password);
mysql_select_db('innovakids', $conn);
?>