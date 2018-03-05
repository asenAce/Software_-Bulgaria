<?php
	session_start();
	ob_start();
	include "db.php";
	include "functions/functions_game.php";
?>


<!doctype html>
<html>
<head>
<meta charset="utf-8">
    <title>Add Charactes</title>
        <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
        <link href="css/blog-home.css" rel="stylesheet" type="text/css">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
        <link href="css/sb-admin.css" rel="stylesheet" type="text/css">
        <link href="css/admin.css" rel="stylesheet" type="text/css">
</head>
<body>
    <?php include "navigation.php";  ?>
    <div class="container">
    	<h3 style="color:white;">Wellcome <?php echo $_SESSION['admin_username']; ?></h3>
    </div>
    <div class=" fa-align-center ">
    	<form style=" margin-top:200px; margin:80px auto;" class="col-lg-6 " action="add_navigation_admin_titles.php" method="post" enctype="multipart/form-data">
            <div class="form-group">
                <label style="color:white;" for="title">Navigation Admin Tite</label>
                <input type="text" class="form-control" name="nav_title" required></input>
            </div>
            <div class="form-group">
                <label style="color:white;" for="title">Navigation Admin Link</label>
                <input type="text" class="form-control" name="nav_link"></input>
            </div>
            <div class="form-group">
                <input class="btn btn-primary" type="submit" name="add_nav_elements" value="Add the navigation element"></input>
            </div>
   		 </form>	
      </div>	
      <?php
	  	   if(isset($_POST['add_nav_elements'])){
			   
			  	$nav_title= $_POST['nav_title'];
				$nav_link = $_POST['nav_link'];
				
				$query = "INSERT INTO navigation_admin(navigation_admin_title,navigation_admin_link) VALUES('$nav_title','$nav_link') ";
				$send_guery = mysqli_query($connection,$query);
				
				//testQuery($query);
				
		   }
		
	  ?>
      
      
</body>
</html>