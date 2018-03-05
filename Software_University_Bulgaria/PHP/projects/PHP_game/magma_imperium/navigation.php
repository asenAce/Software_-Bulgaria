<?php
	ob_start();
	include "db.php";
	include "functions/functions_game.php";
?>

<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Navigation</title>
</head>
<body>
	
	<nav class="navbar navbar-toggler-left" id="navPrime" >
    	<ul>
        	<?php
				if($_SESSION['admin_username']){
					
				} else {
					echo "<li style='text-align:end;' ><a href='choose_a_character.php'><strong><h1>New Game</h1></strong> </a></li>";
				}
			?>
        	
            <li><a href="#">Setting</a></li>
            <?php
					if($_SESSION['admin_username']){
					   echo "<li><a href='admin_page.php'>Admin page</a></li>";		
					} else {
					
					} 
		     ?>
            <?php
					if($_SESSION['admin_username']){
					   echo "<li><a href='logout.php'>Logout</a></li>";		
					} else {
						echo "<li><a href='login.php'>Login</a></li>";	
					}
			?>
            <?php
				if($_SESSION['admin_username']){
					   echo "<li><a href='add_character.php'>Add Character</a></li>";		
					} else {
					
					}
			?>
            <?php
				if($_SESSION['admin_username']){
					   echo "<li><a href='view_characters.php'>View Characters</a></li>";		
					} else {
					
					}
			?>
            <?php
				if($_SESSION['admin_username']){
					   echo "<li><a href='add_navigation_admin_titles.php'>Add Navigation Title</a></li>";		
					} else {
					
					}
			?>
            <?php
				$query ="SELECT * FROM navigation_admin";
				$send_query = mysqli_query($connection,$query);
				
				//testQuery($query);
				
				while($row=mysqli_fetch_array($send_query)){
					
					$nav_title=$row['navigation_admin_title'];
					$nav_link=$row['navigation_admin_link'];
					
					if($_SESSION['admin_username']){
						echo "<li><a href='$nav_link'>$nav_title</a></li>";	
					} else {
						
					}
				}
        	?>
        </ul>
    </nav>
  
</body>
</html>