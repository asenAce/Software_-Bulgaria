
	<?php

	?>
    
    <div class="wrapper">
    	<div class="container-fluid">
        	<div class="row">
            	<div class="col-lg-9 col-lg-push-3" >
                	<form role="search" method="post" class="visible-xs" action="searchEngine.php">
                    	<div class="form-group">
                        	<select id="product-select" name="movieDB" class="form-control input-lg">
    								<option  value="0" disabled selected>Select The Category</option>
                                    <option  value="new_movies">New Movies</option>
                                    <option  value="popular_movies">Popular Movies</option>
                                    <option  value="tv_series">Tv series</option>
                             </select>
                        	<div class="input-group">
                            	<input type="search" name="searchWord" class="form-control input-lg" placeholder="Search a movie">
                                <div class="input-group-btn">
                                	<button class="btn btn-default btn-lg" type="submit" name="searchSubmit"><i class="glyphicon glyphicon-search"></i></button>
                                </div>
                            </div>
                        </div>
                    </form>
                  <?php
				   			if(isset($_GET['p_id'])){
								$new_movie_id = $_GET['p_id'];
								
								$sellectTheNewMovie = $theConnection->executeTheQuery("SELECT * FROM new_movies WHERE id='$new_movie_id'");
										while($row=mysqli_fetch_assoc($sellectTheNewMovie)){
											$movie_title = $row['movie_title'];
				   ?>   
                    <h1><?php echo $movie_title; ?></h1>
                    <hr>
               <div class="row">
                  <?php
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
                            	<div class="embed-responsive embed-responsive-16by9" style="margin-bottom:1%;">
                    					<iframe class="embed-responsive-item" width="80%" height="45%" src="<?php echo $movie_trailer; ?>" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                   				</div>
              <!--DISPLAY STARS ACCORDING TO THE RATING-->              
                 <tr class="stars">
				   <td></td>
				       <td>
                            <div class='stars-outer'>
                           		 <div class='stars-inner'></div>
                            </div>
                            <span class='number-rating'></span>
					  </td>
					</tr>
                    <img src="img/star-ratings-blog3.png" width="1080" height="130" style="margin-left:200px; margin-bottom:15px;">
              <!--END OF THE STARS-->
                                	<div class="well info-block text-center">
                                		Year:<span class="badge" style="margin-right:2%;"><?php echo $movie_title; ?></span>
                                    	Rating:<span class="badge" style="margin-right:2%;"><?php echo $movie_rating;  ?></span>
                                    	Director:<span class="badge" style="margin-right:2%;"><?php echo $movie_director;  ?></span>
                                        Price:<span class="badge" style="margin-right:2%;">$_<?php echo $movie_price; ?></span>
                                	</div>  
                                <!-- Added Modal -->   
                               
                            	<div class="col-lg-3 text-center col-md-2" >
                                		
        <button style="margin-top:3%; margin-bottom:3%; width:35%; height:40%;" type="button" class="btn btn-primary img-responsive visible-xs" data-toggle="modal" data-target="#exampleModal">
                                     		<img    class="img-responsive"  src="img/movie_posters/<?php echo $movie_post_img; ?>">
                                            	See The Image 
                                        </button>    
                               
                                   <!-- Button trigger modal -->
                                        <button style="margin-top:3%; margin-bottom:3%;" type="button" class="btn btn-warning hidden-xs" data-toggle="modal" data-target="#exampleModal">
                                          	<img    class="img-responsive" src="img/movie_posters/<?php echo $movie_post_img; ?>">
                                          See The Image
                                        </button>
                                        
                                        <!-- Modal -->
                                        <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                                          <div class="modal-dialog" role="document">
                                            <div class="modal-content">
                                              <div class="modal-header">
                                                <h5 class="modal-title" id="exampleModalLabel"><?php echo $movie_title; ?></h5>
                                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                  <span aria-hidden="true">&times;</span>
                                                </button>
                                              </div>
                                              <div class="modal-body">
                                           			<img src="img/movie_posters/<?php echo $movie_post_img; ?>" width="70%;" height="60%;">
                                              </div>
                                              <div class="modal-footer">
                                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                                
                                              </div>
                                            </div>
                                          </div>
                                        </div>
                                    
                                   	<!--add media query for small screen!-->
                                   <img id="imageDVDtheMovie" style="margin-top:2%;"   src="img/movies-dvds/<?php echo $movie_dvd_img; ?>" class="img-responsive">    
                                </div>
                                <div class="col-lg-9 col-md-10">
                                		<h3>About this movie</h3>
                                	<p style="margin-top:2%;"><?php echo $movie_description; ?></p>
                                </div>
                                <div class="col-lg-12 col-md-12">
                                    <a  style="margin-top:3%;" href="#" class="btn btn-lg btn-warning pull-left">Buy Now</a>
              <?php
			  		if($_SESSION['user']) {
					    echo "<a  style='margin-top:3%;' href='rateTheNewMovie.php?p_id=$movie_id' class='btn btn-lg btn-warning pull-right'>Rate This Movie</a>";	
					}
			  ?>                      
                                </div>
          </div>
  <?php
  					}
								
							}
  ?>                          
            </div>
                         
							  <h2>Write a Comment</h2>
                          <hr>
                <form role="form" action="registration.php">
                  <div class="form-group">
                     <?php
					 		if(!$_SESSION['user']){
								echo "<a href='registration.php'>";
									echo "<button class='btn btn-lg btn-warning pull-left' style='margin-bottom:3%;' >Registration</button>";
								echo "</a>";
							}
					 ?>                           
                              
                              
                  </div>
              </form>
              	
              <form role="form" action="insertComments.php" method="post">
                  <div class="form-group">
                  	<input type="text" name="theUser" style="margin-bottom:10px;"  value="User:<?php echo $_SESSION['user']; ?>" readonly class="form-control input-lg">
              		<input type="text" name="theMovieTitle" style="margin-bottom:10px;"  value="Movie Title:<?php echo $movie_title; ?>" readonly class="form-control input-lg">
					<?php
							if($_SESSION['user']){
								echo " <button name='sendComment' class='btn btn-lg btn-warning pull-right' style='margin-bottom:3%;'>Submit Comment</button>";
							}
					?>	
                       <label>Your Comment</label>
                       <textarea class="form-control" name="theComment"></textarea>
                  </div>
              </form>          
                        <div class="margin-8 clear"></div>
                   
                </div>
                <!--Left site min-menu-->
               <?php
			   		include("includes/sideBar.php");
			   ?>
            </div>
        </div>
    </div>
    
	
</body>
</html>