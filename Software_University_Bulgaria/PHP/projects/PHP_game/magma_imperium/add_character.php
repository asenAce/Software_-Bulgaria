<?php
	session_start();
	ob_start();
	include "db.php";
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
    	<form style=" margin-top:200px; margin:80px auto;" class="col-lg-6 " action="add_character.php" method="post" enctype="multipart/form-data">
            <div class="form-group">
                <label style="color:white;" for="title">Character Name</label>
                <input type="text" class="form-control" name="character_name" required></input>
            </div>
            <div class="form-group">
                <label style="color:white;" for="title">Character Description</label>
                <textarea type="text" class="form-control" name="character_description"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Character Skills</label>
                <textarea type="text" class="form-control" name="character_skills"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_image">Character Image</label>
                <input type="file" class="form-control" name="character_image"></input>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Character Capital</label>
                <input type="number" class="form-control" name="character_capital"></input>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Character Link</label>
                <input type="text" class="form-control" name="character_link"></input>
            </div>
            <div class="form-group">
                <input class="btn btn-primary" type="submit" name="create_character" value="Chreate Character"></input>
            </div>
   		 </form>	
      </div>	
    <?php
		
		if(isset($_POST['create_character'])){
			
			$character_name = $_POST['character_name'];
			$character_description = $_POST['character_description'];
			$character_skills = $_POST['character_skills'];
			$character_image = $_FILES['character_image']['name'];
			$character_image_tmp=$_FILES['character_image']['tmp_name'];
			$character_capital = $_POST['character_capital'];
			$character_link = $_POST['character_link'];
			
			move_uploaded_file($character_image_tmp,"images/characters/$character_image");
			
	$query = "INSERT INTO players(player_name,player_description,player_skills,player_image,player_capital,player_link) 		   VALUES('$character_name','$character_description','$character_skills','$character_image','$character_capital','$character_link') ";
	
	$chreate_character =mysqli_query($connection,$query);
	
			if($chreate_character){
				echo "<h1 style='color:white;'>Character was chreated</h1>";	
			} else {
				echo "<h1 style='color:white;'>QUERY FAILED</h1>" . mysqli_error($connection,$chreate_character);	
			}
	
		}
		
	
	?>
</body>
</html>