<?php
	session_start();
	ob_start();
	include"db.php";
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
    
  <div class="container">  
   
                <table class="table table-bordered table-hover" style=" margin-top:140px; width:1300px; ">	
                	<thead>
                    	<tr>
                        	<th style="color:white;"><h2>ID</h2></th>
                            <th style="color:white;"><h2>Character Name</h2></th> 
                            <th style="color:white;"><h2>Character Description</h2></th>
                            <th style="color:white;"><h2>Character Skills</h2></th>
                            <th style="color:white;"><h2>Character Image</h2></th>
                            <th style="color:white;"><h2>Character Capital </h2></th>
                            <th style="color:white;"><h2>Edit</h2></th>
                            <th style="color:white;"><h2>Delete</h2></th>
                        </tr>
                    </thead>
                    <tbody>
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
			
			echo "<tr>";
				echo "<td style='color:white;'>$character_id</td>";
				echo "<td style='color:white;'>$character_name</td>";
				echo "<td style='color:white;'>$character_description</td>";
				echo "<td style='color:white;'>$character_skills</td>";
				echo "<td><img src='images/characters/$character_image' width='200'></td>";
				echo "<td style='color:white;'>$character_capital</td>";
				echo "<td style='color:white;'><a href='edit_character.php?characterId=$character_id'>Edit</a></td>";
				echo "<td style='color:white;'><a href='delete_character.php?delcharacterId=$character_id'>Delete</a></td>";
			echo "</tr>";
		}
	?>
                  </tbody>
                </table>
         <h1 class="page-header" style="color:white;">View all Characters</h1>        
   </div>             
</body>
</html>