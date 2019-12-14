
	<?php
		include("includes/header.php");
		include("includes/navigation.php");
		
	?>
    <div class="wrapper">
    	<div class="container-fluid">
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
  <?php
				   			if(isset($_GET['p_id'])){
								$theTV_movie_id = $_GET['p_id'];
								
								$sellectTheTVMovie = $theConnection->executeTheQuery("SELECT * FROM tv_series WHERE id='$theTV_movie_id'");
										while($row=mysqli_fetch_assoc($sellectTheTVMovie)){
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
                    					<iframe width="560" height="315" src="<?php echo $movie_trailer; ?>" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                                    
                   				</div>
                                	<div class="well info-block text-center">
                                		Year:<span class="badge" style="margin-right:2%;"><?php echo $movie_year; ?></span>
                                    	Rating:<span class="badge" style="margin-right:2%;"><?php echo $movie_rating; ?></span>
                                    	Director:<span class="badge" style="margin-right:2%;"><?php echo $movie_director; ?></span>
                                        Price:<span class="badge" style="margin-right:2%;">$_<?php echo $movie_price; ?></span>
                                	</div>   
                            	<div class="col-lg-3 text-center col-md-2" >
                                   <a href="#">
                                	<img   class="img-responsive" src="img/tv_series/<?php echo $movie_post_img;  ?>">
                                   </a> 
                      <!--THE MODAL-->
       <button style="margin-top:3%; margin-bottom:3%; width:35%; height:40%;" type="button" class="btn btn-warning img-responsive visible-xs" data-toggle="modal" data-target="#exampleModal">
                          <img style="margin-top:2%;"   src="img/movies-dvds/<?php echo $movie_dvd_img; ?>" class="img-responsive"> 
                          See The DVD
 	   </button>	
       <button class=" img-responsive hidden-xs" style="margin-top:2%;">
                          <img    src="img/movies-dvds/<?php echo $movie_dvd_img; ?>" class="img-responsive"> 
       </button>                   
                        

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
                                           			<img src="img/movies-dvds/<?php echo $movie_dvd_img; ?>" width="70%;" height="60%;">
                                              </div>
                                              <div class="modal-footer">
                                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                                
                                              </div>
                                            </div>
                                          </div>
                                     </div> 
                                </div>
                                <div class="col-lg-9 col-md-10">
                                	<p style="margin-top:2%;"><?php echo $movie_description; ?></p>
                                </div>
                                <div class="col-lg-12 col-md-12">
                                    <a  style="margin-top:3%;" href="#" class="btn btn-lg btn-warning pull-left">Buy Now</a>
                                </div>
                            </div>
   <?php
  					}
								
							}
  ?>                            
               </div>
                       <h2>Previous Comments about this Movie</h2>
                          <hr>
                
                          <div class="panel panel-info">
                            <div class="panel-heading"><i class="glyphicon glyphicon-user"></i> <span>The User Name</span> </div>
                            <div class="panel-body">
                              Previous comment
                            </div>
                          </div>
							  <h2>Write a Comment</h2>
                          <hr>
               <form role="form" action="registration.php">
                  <div class="form-group">
                     <?php
					 		if(!$_SESSION['user']){
								echo "<a href='includes/registration.php'>";
									echo "<button class='btn btn-lg btn-warning pull-left' style='margin-bottom:3%;' >Registration</button>";
								echo "</a>";
							}
							
							if($_SESSION['user']){
								echo " <button class='btn btn-lg btn-warning pull-right' style='margin-bottom:3%;'>Submit Comment</button>	";
							}
					 ?>                           
                              <input type="text"  value="User:<?php echo $_SESSION['user']; ?>" readonly class="form-control input-lg">
                              
                  </div>
                            <div class="form-group">
                              <label>Your Comment</label>
                              <textarea class="form-control"></textarea>
                            </div>
                            
              </form>
                        
                        <div class="margin-8 clear"></div>
                </div>
                <!--Left site min-menu-->
               <?php
			   		include("includes/leftSiteMinMenu.php");
			   ?>
            </div>
        </div>
    </div>
	<?php 
		include("includes/footer.php");
	?>
</body>
</html>