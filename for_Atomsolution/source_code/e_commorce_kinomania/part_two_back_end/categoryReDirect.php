<?php
	ob_start();
	
	if(isset($_POST['searchByCategory'])){
		
		$movieArt = $_POST['movieCategory'];
		$movieDB = $_POST['movieDB'];
		
		$new_movies ="New Movies";
		
			switch($movieDB){
				
				case "new_movies":
					header("Location:resultsByCategory.php?movieArt=$movieArt&theKeyWord=New Movies");
					break;
				case "popular_movies":
					header("Location:resultsByCategoryPopularMovie.php?movieArt=$movieArt&theKeyWord=Popular Movies");
					break;	
				case "tv_series":
					header("Location:resultsByCategoryTvseries.php?movieArt=$movieArt&theKeyWord=Tv Series");
					break;		
					
			}
		
	}



?>