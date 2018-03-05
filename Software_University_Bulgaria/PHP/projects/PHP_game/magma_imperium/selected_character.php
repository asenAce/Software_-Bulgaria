<?php
	session_start();
	ob_start();
	include "db.php";

	
?>

<!doctype html>
<html>
<head>
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
	<h1>Selected Character</h1>
	<?php
		if(isset($_GET['character_name'])){
			
			$the_character_name = $_GET['character_name'];
			
			$query ="SELECT * FROM players WHERE player_name = '$the_character_name'";
			$send_query = mysqli_query($connection,$query);
			
			while($row=mysqli_fetch_assoc($send_query)){
				
					$characterId = $row['player_id'];
					$characterName = $row['player_name'];
					$characterDescription = $row['player_description'];
					$characterSkils = $row['player_skills'];
					$characterImage = $row['player_image'];
					$characterCapital = $row['player_capital'];
					$characterLink = $row['player_link'];
					
					
					$_SESSION['player_name'] = $the_character_name;
					header("Location:selectCountry.php");
														
					
					//echo $the_character_name;
			}
			
				/*?>if($send_query){
					
					   echo "Query Passed ";

				} else {
					echo "QUERY FAILED".mysqli_error($send_query);	
				} 
				
				if($_SESSION['player_name']){
					
					echo "Sesion Started ";
				}*/
		
			
			
		}
	
	
	?>
</body>
</html>