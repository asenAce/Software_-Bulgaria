<?php
	require_once"include/db.php";
	session_start();
	include "includes/header.php";


?>
<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Log out</title>
</head>
<body>
	<?php
								   $_SESSION['admin_username'] = null;	
								   $_SESSION['admin_id'] = null;
								   $_SESSION['user'] = null;
		 
		 
		 
		 header("Location:index.php");
	?>
</body>
</html>