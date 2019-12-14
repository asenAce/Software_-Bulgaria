<?php
	
			function displayCategories2($procesedData){
					
				while($row=mysqli_fetch_assoc($procesedData)){
					
					$category_title = $row['cat_title'];
					$category_link = $row['cat_link'];
					$keyWord = $row['keyWord'];
						$popular_movies = "popular_movies";
					
					/*
						if($keyWord == "popular_movies" ){
							$display="<li><a href='$category_link'?keyWord=$popular_movies>$category_title</a></li>";
						}
						
						*/
						
					
					//	$display="<li><a href='$category_link'>$category_title</a></li>";
						
					//	echo $display;
				}
			}


?>