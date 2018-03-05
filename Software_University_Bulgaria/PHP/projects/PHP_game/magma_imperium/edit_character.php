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
        <?php
		
			if(isset($_GET['characterId'])){
	
				$theCharacterid=$_GET['characterId'];
				
				$query_edit = "SELECT * FROM players WHERE player_id = '$theCharacterid'";
				$send_edit_query=mysqli_query($connection,$query_edit);
				
				while($row=mysqli_fetch_assoc($send_edit_query)){
					
					$theCharacterid = $row['player_id'];
					$theCharacterName = $row['player_name'];
					$theCharacterDescription = $row['player_description'];
					$theCharacterSkills = $row['player_skills'];
					$theCharacterImage = $row['player_image'];
					$theCharacterCapital = $row['player_capital'];
					$theCharacterLink = $row['player_link'];
					
				}
				
				
				
			}
		
	
	     ?>
    </div>
    <div class=" fa-align-center ">
    	<form style=" margin-top:200px; margin:80px auto;" class="col-lg-6 " action="edit_character.php" method="post" enctype="multipart/form-data">
            <div class="form-group">
                <label style="color:white;" for="title">Character ID</label>
                <input type="text" class="form-control" name="character_ID"  value="<?php echo $theCharacterid; ?>"></input>
            </div>
            <div class="form-group">
                <label style="color:white;" for="title">Character Name</label>
                <input type="text" class="form-control" name="character_name"  value="<?php echo $theCharacterName; ?>"></input>
            </div>
            <div class="form-group">
                <label style="color:white;" for="title">Character Description</label>
                <textarea type="text" class="form-control" name="character_description" ><?php echo $theCharacterDescription; ?></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Character Skills</label>
                <textarea type="text" class="form-control" name="character_skills"><?php echo $theCharacterSkills; ?></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_image"></label>
					
                    <input type="file" class="form-control" name="character_image"> 
                         <?php echo "<img   name='character_image' src='images/characters/$theCharacterImage' width='600' height='400' "; ?>      
                    </input>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Character Capital</label>
                <input type="number" class="form-control" name="character_capital" value="<?php echo $theCharacterCapital; ?>"></input>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Character Link</label>
                <input type="text" class="form-control" name="character_link" value="<?php echo $theCharacterLink; ?>"></input>
            </div>
            <div class="form-group">
                <input class="btn btn-primary" type="submit" name="edit_character" value="Edite Character"></input>
            </div>
   		 </form>	
      </div>	   
      <?php
	  		if(isset($_POST['edit_character'])){
				
					$theedited_id = $_POST['character_ID'];
					$theedited_name = $_POST['character_name'];
					$theedited_desc = $_POST['character_description'];
					$theedited_skills = $_POST['character_skills'];
					
					$theedited_image = $_FILES['character_image']['name'];
			        $theedited_image_tmp=$_FILES['character_image']['tmp_name'];
					$theedited_capital = $_POST['character_capital'];
					$theedited_link = $_POST['character_link'];
					
					move_uploaded_file($theedited_image_tmp,"images/characters/$theedited_image");
				
				
$query_insert="UPDATE players  SET player_id='$theedited_id',player_name='$theedited_name',player_description='$theedited_desc',";
$query_insert .="player_skills='$theedited_skills',player_image= '$theedited_image',player_capital='$theedited_capital',player_link='$theedited_link' WHERE player_id='$theedited_id'";
				
				
				
				$insert_query = mysqli_query($connection,$query_insert);
				
				if($insert_query){
					echo "You updated Character";
					header("Location:view_characters.php");
				} else {
					
					echo "FAILED".mysqli_error($connection);	
				}
				
			
				//
				
			}
	  
	  ?>
</body>
</html>