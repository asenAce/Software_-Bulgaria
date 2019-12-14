
	<?php
		include("includes/header.php");
		include("includes/navigation.php");
		
	?>
   <!--Here the major content-->
    <div class="wrapper">
    	<div class="container">
        	<div class="row">
            	<div class="col-lg-9 col-lg-push-3">
                	<form role="search"  class="visible-xs">
                    	<div class="form-group">
                        	<div class="input-group">
                            	<input type="search" class="form-control input-lg" placeholder="Search a Movie by Title">
                                	<div class="input-group-btn">
                                    	<button class="btn btn-default btn-lg" type="submit"><i class="glyphicon glyphicon-search"></i></button>
                                    </div>
                            </div>
                        </div>
                    </form>
                    <h1>Best Movies and TV Series Ratings</h1>
                    	<hr>
                     <!-- The Table displaying the Ratings-->   
                     <table class="table table-striped">
                     	<thead>
                        	<tr>
                            	<th></th>
                                <th>Movies & TV Series</th>
                                <th class="text-center">Year</th>
                                <th class="text-center">Rating</th>
                                <th class="text-center">Price</th>
                                <th class="text-center">Story Department</th>
                            </tr>
                        </thead>  
                        <tbody>
                        	<tr>
        <?php
					$sellectAllNewMovies = $theConnection->executeTheQuery("SELECT * FROM new_movies ORDER BY movie_rating DESC LIMIT 1");
						while($row=mysqli_fetch_assoc($sellectAllNewMovies)){
							
							$movie_title = $row['movie_title'];
							$movie_post_img = $row['movie_post_img']; 
							$movie_id = $row['id'];
							$movie_year = $row['movie_year'];
							$movie_rating = $row['movie_rating'];
							$movie_price = $row['movie_price'];	
				
		?>                    
                            
                            	<td class="col-lg-1 col-md-1 col-xs-2">
                                	<img class="img-responsive img-thumbnail" src="img/movie_posters/<?php echo $movie_post_img; ?>" alt="the move">
                                </td>
                                <td class="vert-align">
                                	<a href="theMovie.php?p_id=<?php echo $movie_id; ?>&theKeyWord=New Movies"><?php echo $movie_title; ?></a>
                                </td>
                                <td class="vert-align text-center">
                                	<?php echo $movie_year; ?>
                                </td>
                                <td class="vert-align text-center">
                                	<?php echo $movie_rating; ?>
                                </td>
                                <td class="vert-align text-center">
                                	<?php echo $movie_price; ?>
                                </td>
                                 <td class="vert-align text-center">
                                	<h5>New Movies</h5>
                                </td>
     <?php
						}
	 ?>                           
                            </tr>
                            <tr>
     <?php
					$sellectAllPopularMovies = $theConnection->executeTheQuery("SELECT * FROM popular_movies ORDER BY movie_rating DESC LIMIT 1");
						while($row=mysqli_fetch_assoc($sellectAllPopularMovies)){
							
							$movie_title = $row['movie_title'];
							$movie_post_img = $row['movie_post_img']; 
							$movie_id = $row['id'];
							$movie_year = $row['movie_year'];
							$movie_rating = $row['movie_rating'];
							$movie_price = $row['movie_price'];	
				
		?>                    
                            
                            	<td class="col-lg-1 col-md-1 col-xs-2">
                                	<img class="img-responsive img-thumbnail" src="img/movies_popular/<?php echo $movie_post_img; ?>" alt="the move">
                                </td>
                                <td class="vert-align">
                                	<a href="thePopularMovies.php?p_id=<?php echo $movie_id; ?>&theKeyWord=Popular Movies"><?php echo $movie_title; ?></a>
                                </td>
                                <td class="vert-align text-center">
                                	<?php echo $movie_year; ?>
                                </td>
                                <td class="vert-align text-center">
                                	<?php echo $movie_rating; ?>
                                </td>
                                <td class="vert-align text-center">
                                	<?php echo $movie_price; ?>
                                </td>
                                <td class="vert-align text-center">
                                	<h5>Popular Movies</h5>
                                </td>
     <?php
						}
	 ?>          
     					</tr>
                        <tr>	   
    <?php
					$sellectAllTVseries = $theConnection->executeTheQuery("SELECT * FROM tv_series ORDER BY movie_rating DESC LIMIT 1");
						while($row=mysqli_fetch_assoc($sellectAllTVseries)){
							
							$movie_title = $row['movie_title'];
							$movie_post_img = $row['movie_post_img']; 
							$movie_id = $row['id'];
							$movie_year = $row['movie_year'];
							$movie_rating = $row['movie_rating'];
							$movie_price = $row['movie_price'];	
				
	?>                    
                            
                            	<td class="col-lg-1 col-md-1 col-xs-2">
                                	<img class="img-responsive img-thumbnail" src="img/tv_series/<?php echo $movie_post_img; ?>" alt="the move">
                                </td>
                                <td class="vert-align">
                                	<a href="selectedTVseries.php?p_id=<?php echo $movie_id; ?>&theKeyWord=Tv Series"><?php echo $movie_title; ?></a>
                                </td>
                                <td class="vert-align text-center">
                                	<?php echo $movie_year; ?>
                                </td>
                                <td class="vert-align text-center">
                                	<?php echo $movie_rating; ?>
                                </td>
                                <td class="vert-align text-center">
                                	<?php echo $movie_price; ?>
                                </td>
                                <td class="vert-align text-center">
                                	<h5>TV Series</h5>
                                </td>
     <?php
						}
	 ?>             
     					</tr>
                        </tbody> 
                     </table> 		 
                          	<div class="margin-8 clear"></div>   
                </div>
                
                
                <!--This is the left side Bar-->
                <?php
					include("includes/sideBar.php");
				?>
            </div>
        </div>
    </div>
     			<?php
					include("includes/footer.php");
				?>
</body>
</html>