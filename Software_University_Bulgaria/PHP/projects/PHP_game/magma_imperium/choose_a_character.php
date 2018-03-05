<?php
	session_start();
	ob_start();
	include"db.php";
?>
<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Choose a Character</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="css/blog-home.css" rel="stylesheet" type="text/css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="css/custom.css" rel="stylesheet" type="text/css">
    <link href="css/sb-admin.css" rel="stylesheet" type="text/css">
</head>
<body>
	<h1 style="color:blue; margin-bottom:20px;">Choose a Character</h1>
	<?php
	   $query = "SELECT * FROM players";
	   $view_characters = mysqli_query($connection,$query);    						
		
		while($row=mysqli_fetch_assoc($view_characters)){
			
			$character_id=$row['player_id'];
			$character_name=$row['player_name'];
			$character_description=$row['player_description'];
			$character_skills=$row['player_skills'];
			$character_image=$row['player_image'];
			$character_capital=$row['player_capital'];
		?>	
	

	<div class="container" >
   	  
      <div class="row" >
        <div class=" col-md-8">
              <h3 style="color:black;">Character Name  <?php echo $character_name; ?></h3>
                    <?php echo "<img src='images/characters/$character_image' width='500' height='400'>"; ?>
                    <h4 style="color:black";>Description</h4>
                    <?php echo "<p style='color:black;'>$character_description</p>"; ?>
                    <h4 style="color:black";>Skill set</h4>
                    <?php echo "<p style='color:black;'>$character_skills</p>"; ?>
                    <h4 style="color:black";>Capital $</h4>
                    <?php echo "<p style='color:black;'>$character_capital</p>"; ?>
                 <div class="form-group">	
                    <?php echo"<a href='selected_character.php?character_name={$character_name}'>"; ?>
                      <input class="btn btn-primary" type="submit" name="button_characters" value="Play as <?php echo $character_name; ?>"></input>
                    </a>
                </div>
            </div>  
         </div>
       </div>

    <?php } ?>
    
</body>
</html>