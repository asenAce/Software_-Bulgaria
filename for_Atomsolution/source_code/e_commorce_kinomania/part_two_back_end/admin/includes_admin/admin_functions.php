<?php
					function confirmTheQuery($incoming){
						
						global $theConnection;
						
						if(!$incoming){
							echo "Add Query Failed".mysqli_error($theConnection);
						} 
				
				
					}
	
					function insertNewCategory(){
		
						global $theConnection;
						if(isset($_POST['submit_category'])){
							
								$cat_title=$_POST['cat_title'];
								$cat_href=$_POST['cat_href'];
								
								if($cat_title == "" || empty($cat_title)){
									echo "the field should not be empty";	
								} else {
									$insertIntoCategories=$theConnection->executeTheQuery("INSERT INTO categories(cat_title,cat_link) VALUES('$cat_title','$cat_href') ");
									if(!$insertIntoCategories){
										die('Query Insert Failed').mysqli_error($theConnection);
									}
								}
							}	  	  
 					 }


		function createNewMovies(){
				  global $theConnection;
				  
					if(isset($_POST['create_newMovies'])){
		
					 $movie_title=$_POST['movie_title'];
					 $movie_description=$_POST['movie_description'];
					 $movie_trailer_href=$_POST['movie_trailer_href'];
					 $movie_year=$_POST['movie_year'];
					 $movie_raiting=$_POST['movie_raiting'];
					 $movie_category = $_POST['movie_category'];
					 
					 $movie_image_poster = $_FILES['movie_image_poster']['name'];
					 $movie_image_poster_temp = $_FILES['movie_image_poster']['tmp_name'];
					 
					  move_uploaded_file($movie_image_poster_temp,"images/$movie_image_poster");
					  
					 $movie_image_dvd = $_FILES['movie_image_dvd']['name'];
					 $movie_image_dvd_temp = $_FILES['movie_image_dvd']['tmp_name'];
					 
					  move_uploaded_file($movie_image_dvd_temp,"images/$movie_image_dvd");
					 
					 $movie_director=$_POST['movie_director'];
					 $movie_price=$_POST['movie_price'];
					 $movie_year=$_POST['movie_year']; 
				
		$theQuery ="INSERT INTO new_movies(movie_title,movie_description,movie_trailer,movie_post_img,movie_dvd_img,movie_rating,movie_director,movie_price,movie_year,movie_category) ";
		$theQuery .="VALUES('$movie_title','$movie_description','$movie_trailer_href','$movie_image_poster','$movie_image_dvd','$movie_raiting','$movie_director','$movie_price','$movie_year','$movie_category')";	
					 $createNewMovie=$theConnection->executeTheQuery($theQuery);
							confirmTheQuery($createNewMovie);
		 				 
					} 
				 
				 
			 }
			 
			 
		function createPopularMovies(){
			
			 global $theConnection;
				  
					if(isset($_POST['create_popularMovies'])){
		
					 $movie_title=$_POST['movie_title'];
					 $movie_description=$_POST['movie_description'];
					 $movie_trailer_href=$_POST['movie_trailer_href'];
					 $movie_year=$_POST['movie_year'];
					 $movie_raiting=$_POST['movie_raiting'];
					 $movie_category=$_POST['movie_category'];
					 
					 $movie_image_poster = $_FILES['movie_image_poster']['name'];
					 $movie_image_poster_temp = $_FILES['movie_image_poster']['tmp_name'];
					 
					  move_uploaded_file($movie_image_poster_temp,"images/$movie_image_poster");
					  
					 $movie_image_dvd = $_FILES['movie_image_dvd']['name'];
					 $movie_image_dvd_temp = $_FILES['movie_image_dvd']['tmp_name'];
					 
					  move_uploaded_file($movie_image_dvd_temp,"images/$movie_image_dvd");
					 
					 $movie_director=$_POST['movie_director'];
					 $movie_price=$_POST['movie_price'];
					 $movie_year=$_POST['movie_year']; 
				
		$theQuery ="INSERT INTO popular_movies(movie_title,movie_description,movie_trailer,movie_post_img,movie_dvd_img,movie_rating,movie_category,movie_director,movie_price,movie_year) ";
		$theQuery .="VALUES('$movie_title','$movie_description','$movie_trailer_href','$movie_image_poster','$movie_image_dvd','$movie_raiting','$movie_category','$movie_director','$movie_price','$movie_year')";	
					 $createNewMovie=$theConnection->executeTheQuery($theQuery);
							confirmTheQuery($createNewMovie);
		 				 
					} 
				 
				 
			 }	
			 
			 
			 function createTVSeries(){
			
			 global $theConnection;
				  
					if(isset($_POST['create_tvSeries'])){
		
					 $movie_title=$_POST['movie_title'];
					 $movie_description=$_POST['movie_description'];
					 $movie_trailer_href=$_POST['movie_trailer_href'];
					 $movie_year=$_POST['movie_year'];
					 $movie_raiting=$_POST['movie_raiting'];
					 $movie_category=$_POST['movie_category'];
					 
					 $movie_image_poster = $_FILES['movie_image_poster']['name'];
					 $movie_image_poster_temp = $_FILES['movie_image_poster']['tmp_name'];
					 
					  move_uploaded_file($movie_image_poster_temp,"images/$movie_image_poster");
					  
					 $movie_image_dvd = $_FILES['movie_image_dvd']['name'];
					 $movie_image_dvd_temp = $_FILES['movie_image_dvd']['tmp_name'];
					 
					  move_uploaded_file($movie_image_dvd_temp,"images/$movie_image_dvd");
					 
					 $movie_director=$_POST['movie_director'];
					 $movie_price=$_POST['movie_price'];
					 $movie_year=$_POST['movie_year']; 
				
		$theQuery ="INSERT INTO tv_series(movie_title,movie_description,movie_trailer,movie_post_img,movie_dvd_img,movie_rating,movie_category,movie_director,movie_price,movie_year) ";
		$theQuery .="VALUES('$movie_title','$movie_description','$movie_trailer_href','$movie_image_poster','$movie_image_dvd','$movie_raiting','$movie_category','$movie_director','$movie_price','$movie_year')";	
					 $createNewMovie=$theConnection->executeTheQuery($theQuery);
							confirmTheQuery($createNewMovie);
		 				 
					} 
				 
				 
			 }	
			
			
			
			
		
			 
			 
			 
			 
			 
			 
			 
			 
			 
			 
			 
			 
			 
			 
			 
			 
			 
			 
			 

?>