<?php
	require_once("db.php");
	$theConnection = new Db("localhost","root","","kinomania");
	
	session_start();  
	ob_start();
	
	
?>
<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Kinomania</title>
<link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
<link href="css/navigation.css" rel="stylesheet" type="text/css">
<link href="css/footer.css" rel="stylesheet" type="text/css">
<link href="css/media_queries.css" rel="stylesheet" type="text/css">
<link href="css/carousel.css" rel="stylesheet" type="text/css">
<link href="css/main.css" rel="stylesheet" type="text/css">
<link href="css/adsBanner.css" rel="stylesheet" type="text/css">
<style>
	
</style>
<link href="css/starRating.css" rel="stylesheet" type="text/css">
<script src="js/jquery.min.js"></script>
<script src="js/bootstrap.min.js"></script>
<script src="js/jquery.js"></script>
</head>
<body>
