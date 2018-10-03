<?php
	require_once "include/db.php";
	include "include/header.php";
    ob_start();
	
	
		$_SESSION['user'] = null;
		$_SESSION['admin'] = null;
		
		header("Location:index.php");

?>