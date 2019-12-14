	<!--This is the Header-->
	<?php
		include("includes/header.php");
	?>
	<!--This is the Navigation-->
	<?php
		include("includes/navigation.php");
	?>
    <!--Here the major content-->
    <div class="wrapper">
    	<div class="container">
        	<div class="row">
            	<div class="col-lg-9 col-lg-push-3">
                	<form role="search" class="visible-xs" action="" method="post">
                            	<div class="form-group">
                                	<select id="product-select" name="movieDB" class="form-control input-lg">
                                    	<option value="0" disabled selected>Select The Category</option>
                                        <option value="new_movies" >New Movies</option>
                                        <option value="popular_movies">Popular Movies</option>
                                        <option value="tv_series">TV Series</option>
                                    </select>
                                	<div class="input-group">
                                    	<input type="search" name="theSearchWord" class="form-control input-lg" placeholder="Search Movie Title">
                                        	<div class="input-group-btn">
                                            	<button class="btn btn-default btn-lg" name="submitSearch" type="submit"><i class="glyphicon glyphicon-search"></i></button>
                                            </div>
                                    </div>
                                </div>
                     </form>
                    	<h2>Your Search</h2>
                    	<hr>
                     <!--Here Displaying the new Movies-->   
<div class="row">
<?php
		if(isset($_POST['submitSearch'])){
				
				$serachWord = $_POST['theSearchWord'];
				$theMovieDB = $_POST['movieDB'];
				
				
					if($theMovieDB ==  "new_movies"){
						 
							
						$theResult = 0;
						
							$searchQueryInNewMovies = "SELECT * FROM new_movies WHERE movie_title LIKE '%$serachWord%'";
							$theSearch = $theConnection->executeTheQuery($searchQueryInNewMovies);
								if(!$theSearch){
									echo "Search Failed".mysqli_error($theConnection);
										die();
								}
								
									$theResult = mysqli_num_rows($theSearch);
									
								if($theResult == 0 ){
									echo "No Result";
								} else {
								
									while($row=mysqli_fetch_assoc($theSearch)){
										
										$movie_title = $row['movie_title'];
										$movie_description = $row['movie_description'];
										$movie_post_img= $row['movie_post_img'];
										$movie_id=$row['id'];
										
?>                               
                                            <div class="well clearfix">
                                                <div class="col-lg-3 text-center col-md-2">
                                                    <a href="theMovie.php?p_id=<?php echo $movie_id;  ?>&theKeyWord=New Movies">
                                                        <img class="img-thumbnail" src="img/movie_posters/<?php echo $movie_post_img; ?>">
                                                            <!--The Title of each movie will be displayed dinamicaly-->
                                                            <p><?php echo $movie_title; ?></p>
                                                    </a>
                                                </div>
                                                <!--here the info for each movie-->
                                                <div class="col-lg-9 col-md-10">
                                                    <p>
                                                        <?php echo $movie_description; ?>
                                                    </p>
                                                </div>
                                                <div class="col-lg-12">
                                                    <a href="theMovie.php?p_id=<?php echo $movie_id;  ?>&theKeyWord=New Movies" class="btn btn-lg btn-warning pull-right">See More Info</a>
                                                    <a href="#" class="btn btn-lg btn-warning pull-left">Buy Now</a>
                                                </div>
                                            </div>
 <?php
						   					}
								}
								
								
								
					}
?>
						    
          
    <!--Next search for DB-->         
 <?php
 		if($theMovieDB ==  "popular_movies"){
						
						$theResult = 0;
						
							$searchQueryInNewMovies = "SELECT * FROM popular_movies WHERE movie_title LIKE '%$serachWord%'";
							$theSearch = $theConnection->executeTheQuery($searchQueryInNewMovies);
								if(!$theSearch){
									echo "Search Failed".mysqli_error($theConnection);
										die();
								}
								
									$theResult = mysqli_num_rows($theSearch);
									
								if($theResult == 0 ){
									echo "No Result";
								} else {
								
									while($row=mysqli_fetch_assoc($theSearch)){
										
										$movie_title = $row['movie_title'];
										$movie_description = $row['movie_description'];
										$movie_post_img= $row['movie_post_img'];
										$movie_id=$row['id'];
										
?>                               
                                            <div class="well clearfix">
                                                <div class="col-lg-3 text-center col-md-2">
                                                    <a href="thePopularMovies.php?p_id=<?php echo $movie_id;  ?>&theKeyWord=Popular Movies">
                                                        <img class="img-thumbnail" src="img/movies_popular/<?php echo $movie_post_img; ?>">
                                                            <!--The Title of each movie will be displayed dinamicaly-->
                                                            <p><?php echo $movie_title; ?></p>
                                                    </a>
                                                </div>
                                                <!--here the info for each movie-->
                                                <div class="col-lg-9 col-md-10">
                                                    <p>
                                                        <?php echo $movie_description; ?>
                                                    </p>
                                                </div>
                                                <div class="col-lg-12">
                                                    <a href="thePopularMovies.php?p_id=<?php echo $movie_id;  ?>&theKeyWord=Popular Movies" class="btn btn-lg btn-warning pull-right">See More Info</a>
                                                    <a href="#" class="btn btn-lg btn-warning pull-left">Buy Now</a>
                                                </div>
                                            </div>
 <?php
						   					}
								}
								
								
								
					}
?>
<!--Search for TV Series-->
 <?php
 		if($theMovieDB ==  "tv_series"){
						
						$theResult = 0;
						
							$searchQueryInNewMovies = "SELECT * FROM tv_series WHERE movie_title LIKE '%$serachWord%'";
							$theSearch = $theConnection->executeTheQuery($searchQueryInNewMovies);
								if(!$theSearch){
									echo "Search Failed".mysqli_error($theConnection);
										die();
								}
								
									$theResult = mysqli_num_rows($theSearch);
									
								if($theResult == 0 ){
									echo "No Result";
								} else {
								
									while($row=mysqli_fetch_assoc($theSearch)){
										
										$movie_title = $row['movie_title'];
										$movie_description = $row['movie_description'];
										$movie_post_img= $row['movie_post_img'];
										$movie_id=$row['id'];
										
?>                               
                                            <div class="well clearfix">
                                                <div class="col-lg-3 text-center col-md-2">
                                                    <a href="selectedTVseries.php?p_id=<?php echo $movie_id;  ?>&theKeyWord=Tv Series">
                                                        <img class="img-thumbnail" src="img/tv_series/<?php echo $movie_post_img; ?>">
                                                            <!--The Title of each movie will be displayed dinamicaly-->
                                                            <p><?php echo $movie_title; ?></p>
                                                    </a>
                                                </div>
                                                <!--here the info for each movie-->
                                                <div class="col-lg-9 col-md-10">
                                                    <p>
                                                        <?php echo $movie_description; ?>
                                                    </p>
                                                </div>
                                                <div class="col-lg-12">
                                                    <a href="selectedTVseries.php?p_id=<?php echo $movie_id;  ?>&theKeyWord=Tv Series" class="btn btn-lg btn-warning pull-right">See More Info</a>
                                                    <a href="#" class="btn btn-lg btn-warning pull-left">Buy Now</a>
                                                </div>
                                            </div>
 <?php
						   					}
								}
								
								
								
					}
?>
      </div>                 
 <?php
 	// this is the major IF
 
 			}
 	
 ?>                           
  
  			<div class="margin-8 clear"></div>      
           </div>
                <!--This is the left side Bar-->
                <?php
					include("includes/sideBar.php");
				?>
            </div>
        </div>
    </div>
    <hr>
     
     			<?php
					include("includes/footer.php");
				?>
</body>
</html>