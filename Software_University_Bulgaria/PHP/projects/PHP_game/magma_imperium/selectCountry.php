<?php
	session_start();
	ob_start();
	include "db.php";
?>


<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Indext</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="css/blog-home.css" rel="stylesheet" type="text/css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="css/custom.css" rel="stylesheet" type="text/css">
    <link href="css/sb-admin.css" rel="stylesheet" type="text/css">
</head>
<body>
	<div class="container">
    	<h1 style="color:black;">Please select a Country <?php echo $_SESSION['player_name']; ?></h1>
   
		<img src="images/countries/africa.jpg" width="1200" height="1391" alt="" usemap="#africa"/>
        <map name="africa">
        	<area shape="rect" coords="1040,1088,1156,1098" alt="Africa" href="countries/madagascar.php"/>
        </map>
      </div>   
</body>
</html>