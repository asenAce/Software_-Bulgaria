
	<?php
		include("includes/header.php");
		include("includes/navigation.php");
		
	?>
    <!--Here the major content-->
    <div class="wrapper">
    	<div class="container-fluid">
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
    <?php
				if(isset($_GET['p_id'])){
					$new_movie_id = $_GET['p_id'];
					
					$sellectThePopularMovie = $theConnection->executeTheQuery("SELECT * FROM popular_movies WHERE id='$new_movie_id'");
						while($row=mysqli_fetch_assoc($sellectThePopularMovie)){
							
							$movie_title = $row['movie_title'];
						
				
	?>                
                    <h1><?php echo $movie_title; ?></h1>
                    	<hr>
                     <!--Here Displaying the new Movies-->   
                         <div class="row">
                        <?php
								//continue of the while loop
							$movie_id = $row['id'];
							$movie_description = $row['movie_description'];
							$movie_post_img = $row['movie_post_img'];
							$movie_dvd_img = $row['movie_dvd_img'];
							$movie_trailer = $row['movie_trailer'];
							$movie_year = $row['movie_year'];
							$movie_rating = $row['movie_rating'];
							$movie_director = $row['movie_director'];
							$movie_price = $row['movie_price'];	
						?> 
                         	<div class="well clearfix">
                            	<div class=" embed-responsive embed-responsive-16by9" style="margin-bottom:1%;">
                                	<!--Our Trailer-->
  <iframe width="560" height="315" src="<?php echo $movie_trailer; ?>" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; 	picture-in-picture" allowfullscreen></iframe>
                                </div>
                                	<div class="well info-block text-center">
                                    	Year:<span class="badge" style="margin-right:2%;"><?php echo $movie_year; ?></span>
                                        Rating:<span class="badge" style="margin-right:2%;"><?php echo $movie_rating; ?></span>
                                        Director:<span class="badge" style="margin-right:2%;"><?php echo $movie_director; ?></span>
                                        Price:$&nbsp;<span class="badge" style="margin-right:2%;"><?php echo $movie_price; ?></span>
                                    </div>
                                <!--here the info for each movie-->
                                <div class=" col-lg-3 text-center col-md-2">
                                	<a href="#">
                                    	<img class="img-responsive" src="img/movies_popular/<?php echo $movie_post_img; ?>" style="margin-bottom:5%;">
                                    </a>
                                 <!-- Added Modal -->
                                    	
                                 <!-- Button trigger modal add class pull-left -->
                                    <button style="margin-top:10%; margin-bottom:3%;" type="button" class="btn btn-warning hidden-xs pull-left" data-toggle="modal" data-target="#exampleModal">
                                    	<img  class="img-responsive" src="img/movies-dvds/<?php echo $movie_dvd_img; ?>" >
                                      		View the DVD
                                    </button>
                                    <!-- Modal visible-xl -->
                                    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                                      <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                          <div class="modal-header">
                                            <h3 class="modal-title" id="exampleModalLabel"><?php echo $movie_title; ?></h3>
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                              <span aria-hidden="true">&times;</span>
                                            </button>
                                          </div>
                                          <div class="modal-body">
                                            <img class="img-responsive" src="img/movies-dvds/<?php echo $movie_dvd_img; ?>" width="70%;" height="60%;">
                                          </div>
                                          <div class="modal-footer">
                                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                        
                                          </div>
                                        </div>
                                      </div>
                                    </div>       
                                    
                                    <!-- Added Modal for xs screen-->
                                    <button style="margin-top:10%; margin-bottom:3%;" type="button" class="btn btn-warning visible-xs" data-toggle="modal" data-target="#exampleModal">
                                    	<img  class="img-responsive " src="img/movies-dvds/<?php echo $movie_dvd_img; ?>"  width="150px;" height="200px;" >
                                      		View the DVD
                                    </button>
                                    <!-- Modal visible-xl -->
                                    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                                      <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                          <div class="modal-header">
                                            <h3 class="modal-title" id="exampleModalLabel"><?php echo $movie_title; ?></h3>
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                              <span aria-hidden="true">&times;</span>
                                            </button>
                                          </div>
                                          <div class="modal-body">
                                            <img class="img-responsive" src="img/movies-dvds/<?php echo $movie_dvd_img; ?>" width="70%;" height="60%;">
                                          </div>
                                          <div class="modal-footer">
                                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                        
                                          </div>
                                        </div>
                                      </div>
                                    </div>       	
                                 <!-- Button trigger modal -->
                                      
                                    
                                </div>
                                <div class="col-lg-9 col-md-10">
                                	<h3>About this Movie</h3>
                                    	<p style="margin-top:2%;">
                                        	<?php
												echo $movie_description;
											?>
                                        </p>
                                </div>
                                <div class="col-lg-12 col-md-12">
                                	<a href="#" class="btn btn-lg btn-warning pull-left" style="margin-top:3%;">Buy Now</a>
                                </div>
                            </div>
   <?php                         
    			// while loop ends here   
				   } 
				// if ends here GET[];
				}
	?>                    
                            
                       </div>
                       		<h2>Previous Comments about this Movie</h2>
                          <hr>
 
                    <div class="panel panel-info">
   <?php
   					$querySellectAllComments ="SELECT * FROM comments WHERE comment_movie_title LIKE '%$movie_title%'";
   						$showTheComments=$theConnection->executeTheQuery($querySellectAllComments);
							while($row=mysqli_fetch_assoc($showTheComments)){
								
								$commentAuthor = $row['comment_author'];
								$commentID = $row['comment_id'];
								$theComment = $row['comment_content'];
							
   ?>                          
                            	<div class="panel-heading"><i class="glyphicon glyphicon-user"></i>&nbsp;<span><?php echo $commentAuthor; ?></span></div>
   								 <div class="panel-body"> 
                                	<h4><?php echo $theComment; ?></h4>
                                </div>
                         <?php
						 	}
						 ?>       
                     </div>  
                            <!--Write Comment Here-->
                            	<h2>Write a Comment</h2>
                                <hr>
                    <?php
						if(!$_SESSION['user']){
							echo "<a href='registration.php'>";
							echo "<button class='btn btn-lg btn-warning pull-left' style='margin-bottom:3%;'>Registration:</button>";
							echo "</a>";
						}
					?>                            
              <form role="form" action="sendTheComment.php" method="post">
                          	<div class="form-group">
                    <?php
							if($_SESSION['user']){
								echo"<button class='btn btn-lg btn-warning pull-right' style='margin-bottom:3%;' name='submitTheCommentPopular'>Submit Comment:</button>";
							}
					?>         
                                
                                <input type="text" value="<?php echo $_SESSION['user']; ?>" name="theUserName" readonly class="form-control input-lg">
                                <input type="text" value="<?php echo $movie_title; ?>" name="theMovieTitle" readonly class="form-control input-lg">
                            </div>
                            <div class="form-group">
                            	<label>Your Comment</label>
                                	<textarea name="theComment" class="form-control"></textarea>
                            </div>
               </form>   
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