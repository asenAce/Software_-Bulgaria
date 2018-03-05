<?php
	include ("db.php");
	include ("functions/functions.php");
	session_start();
	ob_start();
	
	//testConnection();
?>
<!doctype html>
<html>
<head>
	<meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    
    
<title>Index</title>	
	<link href="css/custom.css" rel="stylesheet" type="text/css">
	<link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
	<link href="css/blog-home.css" rel="stylesheet" type="text/css">
	<link href="css/font-awesome.css" rel="stylesheet" type="text/css">
	<link href="css/sb-admin.css" rel="stylesheet" type="text/css">
</head>
<body>
 	<?php include ("navigation.php");  ?>
    <?php
		
		$_SESSION['admin_username'] = null;
		header("Location:index.php");
	?>
</body>
</html>