<?php
	ob_start();
?>
<?php	

	session_start();
	include_once "db.php";
	$theConnection = new Db("localhost","root","","cms_carlovers"); 
	
	include_once "db2.php";
	$theConnection2 = new Db2("localhost","root","","dam_engineering");
?>


<!doctype html>
<html lang="en">
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta name="description" content="cms">
<meta name="author" content="asenl">
<title>CMS Admin Panel</title>

<link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
<link href="css/sb-admin.css" rel="stylesheet" type="text/css">
<link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
</head>

<body>

