<?php
	session_start();
	include "admin/db_countries.php";
?>
<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Indext</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="css/blog-home.css" rel="stylesheet" type="text/css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="css/sb-admin.css" rel="stylesheet" type="text/css">
    <link href="css/admin.css" rel="stylesheet" type="text/css">
</head>
	
<body>
	<?php include("navigation.php");  ?>
	<div class="container">
    	<h3 style="color:white;">Wellcome <?php echo $_SESSION['admin_username']; ?></h3>
    </div>
</body>
</html>