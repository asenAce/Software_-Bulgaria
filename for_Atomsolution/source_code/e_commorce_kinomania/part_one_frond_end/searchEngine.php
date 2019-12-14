
	<?php
		include("includes/header.php");
		include("includes/navigation.php");
		
	?>
    <div class="wrapper">
    	<div class="container">
        	<div class="row">
            	<div class="col-lg-9 col-lg-push-3" >
                	<form role="search" method="post" class="visible-xs">
                    	<div class="form-group">
                        	<div class="input-group">
                            	<input type="search" class="form-control input-lg" placeholder="Search a movie">
                                <div class="input-group-btn">
                                	<button class="btn btn-default btn-lg" type="submit"><i class="glyphicon glyphicon-search"></i></button>
                                </div>
                            </div>
                        </div>
                    </form>
                    <h2>New Movies</h2>
                    <hr>
             <div class="row">
               <?php
			   
			   			 /*if(isset($_GET['page'])){
							 $page=$_GET['page'];
						 } else {
							$page = ""; 
						 }
						 
						 if($page == "" || $page==1){
							 $page_1 = 0;
						 }else {
							$page_1 = ($page * 3) - 3; 
						 }*/
						 
						 
						 if(isset($_POST['searchSubmit'])){
							 
							 	$searchWord = $_POST['searchWord'];
								$TheResult = 0;
								
								$searchQueryInNewMovies = "SELECT * FROM new_movies WHERE movie_title LIKE '%$searchWord%'";
								$theSearch=$theConnection->executeTheQuery($searchQueryInNewMovies);
									if(!$theSearch){
										echo "Search Failed".mysqli_error($theConnection);
										die();
									}
									
									$TheResult = mysqli_num_rows($theSearch);
							 
							 		if($TheResult == 0){
										
										echo "No Result";
										
									} else {
										
										while($row=mysqli_fetch_assoc($theSearch)){
											
											$movie_title = $row['movie_title'];
											$movie_description	 = $row['movie_description'];
											$movie_movie_post_img = $row['movie_post_img'];
											$movie_id = $row['id'];
					?>
                                                <div class="well clearfix">
                                                    <div class="col-lg-3 text-center col-md-2">
                                                      <a href="theMovie.php?p_id=<?php echo $movie_id; ?>">	
                                                        <img class="img-thumbnail" src="img/movie_posters/<?php echo $movie_movie_post_img; ?>">
                                                            <p><?php echo $movie_title; ?></p>
                                                       </a>      
                                                    </div>
                                                    <div class="col-lg-9 col-md-10">
                                                        <p><?php echo $movie_description; ?></p>
                                                    </div>
                                                    <div class="col-lg-12">
                                                        <a  href="theMovie.php"class="btn btn-lg btn-warning pull-right">See More Info</a>
                                                        <a href="#" class="btn btn-lg btn-warning pull-left">Buy Now</a>
                                                    </div>
                                               </div>
                    <?php						
										}
										
									}
							 
						 }
			      ?>
                  <?php
			   			/* $newMoviesQueryCount="SELECT * FROM new_movies";
						 $findCoutNewMovies = $theConnection->executeTheQuery($newMoviesQueryCount);	
						 $count= mysqli_num_rows($findCoutNewMovies);
						 $count = ceil($count / 6);*/
			   
			   			/*$sellectAllNewMovies = $theConnection->executeTheQuery("SELECT * FROM new_movies LIMIT $page_1,3");
			   					while($row=mysqli_fetch_assoc($sellectAllNewMovies)){
									$movie_title = $row['movie_title'];
									$movie_description	 = $row['movie_description'];
									$movie_movie_post_img = $row['movie_post_img'];
									$movie_id = $row['id'];*/
								
			     ?>
                        	<!--<div class="well clearfix">
                            	<div class="col-lg-3 text-center col-md-2">
                                  <a href="theMovie.php?p_id=<?php /*echo $movie_id;*/ ?>">	
                                	<img class="img-thumbnail" src="img/movie_posters/<?php /*echo $movie_movie_post_img;*/ ?>">
                                    	<p><?php /*echo $movie_title;*/ ?></p>
                                   </a>      
                                </div>
                                <div class="col-lg-9 col-md-10">
                                	<p><?php /*echo $movie_description;*/ ?></p>
                                </div>
                                <div class="col-lg-12">
                                	<a  href="theMovie.php"class="btn btn-lg btn-warning pull-right">See More Info</a>
                                    <a href="#" class="btn btn-lg btn-warning pull-left">Buy Now</a>
                                </div>
                            </div>-->
              <?php
			  		/*}*/
			  ?>        
             </div>  
                        <div class="row">
                        	<div class="well clearfix">
                            	
                                <div class="container-fluid">
                                	<p>Your Advert Here</p>
                                	<div class="banner " style="background-image:url(img/cinema/c363cd7aac439443f0b4304fb868ae33.jpg);">
                                  <div class="animated">
                                       <a href="#">
                                     <div class="text1">
                                         <p>Whatch Movies On-Line</p>
                                     </div>
                                  <div class="text2">
                                      <p>from $1 to $30 per month</p>
                                      
                                            </div>
                                          </div> 
                                        </div>
                                       </a> 
                                </div>
                               
                            </div>
                        </div>
                        <div class="margin-8 clear"></div>
                </div>
               <!--Left site min-menu-->  
               <?php
			   		include("includes/leftSiteMinMenu.php");
			   ?>
            </div>
        </div>
    </div>
    <hr>
    <!--<ul class="pager">-->
    	<?php
			/*for($i=1;$i<= $count;$i++){
				echo "<li><a href='index.php?page=$i'>$i</a></li>";
			}*/
			//for the selected page
			/*if($i == $page){
				echo "<li><a class='active_link' href='index.php?page=$i'>$i</a></li>";
			}else {
				echo "<li><a href='index.php?page=$i'>$i</a></li>";
			}*/
			
		?>
    <!--</ul>-->
	<?php 
		include("includes/footer.php");
	?>
</body>
</html>