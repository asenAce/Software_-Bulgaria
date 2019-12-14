
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
                    <h2>Popular Movies</h2>
                    	<hr>
                     <!--Here Displaying the new Movies-->   
    <div class="row">
<?php

	if(isset($_GET['page'])){
		$page = $_GET['page'];
	} else {
		$page = "";	
	}
	
		if($page == "" || $page == 1){
			$page_1 = 0;
		} else {
			$page_1 = ($page * 3) - 3;	
		}
	
	$popularMoviesQueryCount = "SELECT * FROM popular_movies";
	$findCountpopularMovies =$theConnection->executeTheQuery($popularMoviesQueryCount);
		$count = mysqli_num_rows($findCountpopularMovies);
		$count = ceil($count / 4);  // 4 instad 6 
		
	$sellectAllPopularMovies = $theConnection->executeTheQuery("SELECT * FROM popular_movies LIMIT $page_1,3");
				while($row=mysqli_fetch_assoc($sellectAllPopularMovies)){
					
					$movie_title = $row['movie_title'];
					$movie_description = $row['movie_description'];
					$movie_post_img = $row['movie_post_img'];
					$movie_id = $row['id'];
				

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
 ?>                           
              </div>            
           </div>
                <!--This is the left side Bar-->
                <?php
					include("includes/sideBar.php");
				?>
            </div>
        </div>
    </div>
    <hr>
     <ul class="pager">
      
     	<?php
			for($i=1;$i <= $count;$i++){
				
				echo "<li><a href='popularMovies.php?page=$i&theKeyWord=Popular Movies'>$i</a></li>";
			}
			
			//for the selected page
			if($i == $page){
				echo "<li><a class='active_link' href='popularMovies.php?page=$i&theKeyWord=Popular Movies'>$i</a></li>";	
			} else {
				echo "<li><a href='popularMovies.php?page=$i&theKeyWord=Popular Movies'>$i</a></li>";
			}
			
				
		?>
     </ul>
     			<?php
					include("includes/footer.php");
				?>
</body>
</html>