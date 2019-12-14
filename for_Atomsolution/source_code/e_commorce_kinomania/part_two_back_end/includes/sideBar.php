<div class="col-lg-3 col-lg-pull-9">
                	<!--Here is the search Engine-->
                	<div class="panel panel-info hidden-xs">
                    	<div class="panel-heading">
                        	<div class="sidebar-header">
                            	Search
                            </div>
                        </div>
                        <div class="panel-body">
                        	<form role="search" action="searchEngine.php" method="post">
                            	<div class="form-group">
                                	<select id="product-select" name="movieDB" class="form-control input-lg">
                                    	<option value="0" disabled selected>Select The Category</option>
                                        <option value="new_movies">New Movies</option>
                                        <option value="popular_movies">Popular Movies</option>
                                        <option value="tv_series">TV Series</option>
                                    </select>
                                	<div class="input-group">
                                        	<div class="input-group-btn">
                                            	<input type="search" name="theSearchWord" class="form-control input-lg" placeholder="Search Movie Title">
                                            	<button class="btn btn-default btn-lg form-control input-lg" name="submitSearch" type="submit"><i class="glyphicon glyphicon-search"></i></button>
                                            </div>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                    <!--search eng.end-->
                     <!--This is the user log in modul-->
  <?php
 			if(isset($_POST['loginUser'])){
					$userName = $_POST['userName'];
					$userPassword = $_POST['userPassword'];
					
						$queryUser = "SELECT * FROM users";
						  $loginUser = $theConnection->executeTheQuery($queryUser);
						  	if(!$loginUser){
								echo "user login Failed".mysqli_error($theConnection);
							}
							
							while($row=mysqli_fetch_assoc($loginUser)){
								$theUserName = $row['user_name'];
								$theUserPassword= $row['user_password'];
								$userId = $row['user_id'];
								
									if($theUserName == $userName && $theUserPassword == $userPassword){
										$_SESSION['user'] = $theUserName;
											header("Location:index.php?theKeyWord=New Movies");
									} else {
										echo "No such user found!";	
									}
							}
			}
			
			if(!$_SESSION['user']){
				// write also for the admin
				if(!$_SESSION['admin']){
					echo "<div class='panel panel-info'>";
					echo "<div class='panel-heading'>";
					echo "<div class='sidebar-header'>User Login</div>";
					echo "</div>";
					echo "<div class='panel-body'>";
					echo "<form role='form' action='' method='post'>";
					echo "<div class='form-group'>";
					echo "<input type='text' name='userName' class='form-control input-lg' placeholder='User Name'>";
					echo "</div>";
					echo "<div class='form-group'>";
					echo "<input type='password' name='userPassword' class='form-control input-lg' placeholder='Password'>";
					echo "</div>";
					echo "<button type='submit' class='btn btn-warning pull-right' name='loginUser'>Login</button>";
					echo "</form>";
					echo "</div>";
					echo "</div>";
				}
			}
			
			// Admin Login
			
		if(isset($_POST['adminLogin'])){
					
					$adminName = $_POST['adminName'];
					$adminPassword = $_POST['adminPassword'];
					
						$queryAdmin = "SELECT * FROM admin";
						  $loginAdmin = $theConnection->executeTheQuery($queryAdmin);
						  	if(!$loginAdmin){
								echo "Admin login Failed".mysqli_error($theConnection);
							}
							
							while($row=mysqli_fetch_assoc($loginAdmin)){
								
								$theAdminName = $row['admin_username'];
								$theAdminPassword= $row['admin_password'];
								$AdminId = $row['admin_id'];
								
									if($theAdminName == $adminName && $theAdminPassword == $adminPassword){
										$_SESSION['admin'] = $theAdminName;
											header("Location:index.php?theKeyWord=New Movies"); //leater we gonna send him to CMS index.php
									} else {
										echo "No such user found!";	
									}
							}
			}	
			
		
		if(!$_SESSION['admin']){
			if(!$_SESSION['user']){
				echo "<div class='panel panel-info'>";
				echo "<div class='panel-heading'>";
				echo "<div class='sidebar-header'>Admin Login</div>";
				echo "</div>";
				echo "<div class='panel-body'>";
				echo "<form role='form' action='' method='post'>";
				echo "<div class='form-group'>";
				echo "<input type='text' class='form-control input-lg' placeholder='Admin Name' name='adminName'>";
				echo "</div>";
				echo "<div class='form-group'>";
				echo "<input type='password' class='form-control input-lg' placeholder='Password' name='adminPassword'>";
				echo "</div>";
				echo "<button type='submit' class='btn btn-warning pull-right' name='adminLogin'>Login</button>";	
				echo "</form>";
				echo "</div>";
				echo "</div>";
			}
		}
 
 ?>                         
                  
 <!--Display the Three most rated Movies-->
<div class="panel panel-info">
                    	<div class="panel-heading">
                        	<div class="sidebar-header">
                            	
                    <?php
							if(isset($_GET['theKeyWord'])){
								
								$theKeyWord = $_GET['theKeyWord']; 
							
					?>
                    			Three most Rated Movies In &nbsp; <?php echo $theKeyWord; ?>
                            <?php
								}
							//for POST[]
							?>
                   <?php
							if(isset($_POST['movieDB'])){
								
								$theKeyWord = $_POST['movieDB']; 
							
					?>
                    			Three most Rated Movies In &nbsp; <?php 
									if($theKeyWord == "new_movies"){
										
										echo "New Movies";
										
									} else if($theKeyWord == "popular_movies"){
									
										echo "Popular Movies";
										
									} else if($theKeyWord == "tv_series"){
										
										echo "TV Series";
									}
								
								 ?>
                            <?php
								}
							?>         
                            <?php
								if(!isset($_POST['movieDB'])){
							
									if(!isset($_GET['theKeyWord'])){
								
									 
					?>
                    	
                    			Three most Rated Movies In &nbsp;
                                <?php
											$_POST['movieDB'] = "New Movies";
											$_GET['theKeyWord'] = "New Movies";
											
											echo "New Movies";	
								?>
                    
                    <?php			
								
							}
							
						}
					
					?>
                            
                            </div>
                        </div>
<div class="panel-body">
<?php	
 
	// if POST[];
			if(isset($_POST['movieDB'])){
				$theKeyWord = $_POST['movieDB'];
				
					switch($theKeyWord){
							
							case "new_movies":
								$sellectThreeHighrstRatedMovies =$theConnection->executeTheQuery("SELECT * FROM new_movies ORDER BY movie_rating DESC LIMIT 3");
									while($row=mysqli_fetch_assoc($sellectThreeHighrstRatedMovies)){
										
											$movie_title = $row['movie_title'];
											$movie_id = $row['id'];
											$movie_rating=$row['movie_rating'];										
				
	
	?>                    
                        	<ul class="list-group">
                            	<li class="list-group-item list-group-item-warning">
                                	<span class="badge"><?php echo $movie_rating; ?></span>
                                    	<a href="theMovie.php?p_id=<?php echo $movie_id ;?>?theKeyWord=New Movies"><?php echo $movie_title; ?></a>
                                </li>
                            </ul>
  <?php
  				// case new movies end
  						}
						 break;
						 case "popular_movies":
								$sellectThreeHighrstRatedMovies =$theConnection->executeTheQuery("SELECT * FROM popular_movies ORDER BY movie_rating DESC LIMIT 3");
									while($row=mysqli_fetch_assoc($sellectThreeHighrstRatedMovies)){
										
											$movie_title = $row['movie_title'];
											$movie_id = $row['id'];
											$movie_rating=$row['movie_rating'];										
				
	
	?>                    
                        	<ul class="list-group">
                            	<li class="list-group-item list-group-item-warning">
                                	<span class="badge"><?php echo $movie_rating; ?></span>
                                    	<a href="theMovie.php?p_id=<?php echo $movie_id ;?>?theKeyWord=Popular Movies"><?php echo $movie_title; ?></a>
                                </li>
                            </ul>
  <?php
  				// case new movies end
  						}
						 break;
						 case "tv_series":
								$sellectThreeHighrstRatedMovies =$theConnection->executeTheQuery("SELECT * FROM tv_series ORDER BY movie_rating DESC LIMIT 3");
									while($row=mysqli_fetch_assoc($sellectThreeHighrstRatedMovies)){
										
											$movie_title = $row['movie_title'];
											$movie_id = $row['id'];
											$movie_rating=$row['movie_rating'];										
				
	
	?>                    
                        	<ul class="list-group">
                            	<li class="list-group-item list-group-item-warning">
                                	<span class="badge"><?php echo $movie_rating; ?></span>
                                    	<a href="theMovie.php?p_id=<?php echo $movie_id ;?>&theKeyWord=Tv Series"><?php echo $movie_title; ?></a>
                                </li>
                            </ul>
  <?php
  				// case new movies end
  						}
						 break;
?>
	
<?php						 
						 	
					}
				
			//end of if POST[]
			}
	
?>

<?php
	
			if(isset($_GET['theKeyWord']) ){
					$theKeyWord = $_GET['theKeyWord']; 
					
					
					
						switch($theKeyWord){
							
							case "New Movies":
								$sellectThreeHighrstRatedMovies =$theConnection->executeTheQuery("SELECT * FROM new_movies ORDER BY movie_rating DESC LIMIT 3");
									while($row=mysqli_fetch_assoc($sellectThreeHighrstRatedMovies)){
										
											$movie_title = $row['movie_title'];
											$movie_id = $row['id'];
											$movie_rating=$row['movie_rating'];										
				
	
	?>                    
                        	<ul class="list-group">
                            	<li class="list-group-item list-group-item-warning">
                                	<span class="badge"><?php echo $movie_rating; ?></span>
                                    	<a href="theMovie.php?p_id=<?php echo $movie_id ;?>&theKeyWord=New Movies"><?php echo $movie_title; ?></a>
                                </li>
                            </ul>
  <?php
  				// case new movies end
  						}
						 break;
					     case "Popular Movies":
								$sellectThreeHighrstRatedMovies =$theConnection->executeTheQuery("SELECT * FROM popular_movies ORDER BY movie_rating DESC LIMIT 3");
									while($row=mysqli_fetch_assoc($sellectThreeHighrstRatedMovies)){
										
											$movie_title = $row['movie_title'];
											$movie_id = $row['id'];
											$movie_rating=$row['movie_rating'];										
				
	
	?>                    
                        	<ul class="list-group">
                            	<li class="list-group-item list-group-item-warning">
                                	<span class="badge"><?php echo $movie_rating; ?></span>
                                    	<a href="thePopularMovies.php?p_id=<?php echo $movie_id ;?>&theKeyWord=Popular Movies"><?php echo $movie_title; ?></a>
                                </li>
                            </ul>	 
						 
  <?php				
  				// the end of case popular Movies	
							}
					      break;		
						  case "Tv Series":
								$sellectThreeHighrstRatedMovies =$theConnection->executeTheQuery("SELECT * FROM tv_series ORDER BY movie_rating DESC LIMIT 3");
									while($row=mysqli_fetch_assoc($sellectThreeHighrstRatedMovies)){
										
											$movie_title = $row['movie_title'];
											$movie_id = $row['id'];
											$movie_rating=$row['movie_rating'];	
?>
						     <ul class="list-group">
                            	<li class="list-group-item list-group-item-warning">
                                	<span class="badge"><?php echo $movie_rating; ?></span>
                                    	<a href="selectedTVseries.php?p_id=<?php echo $movie_id ;?>&theKeyWord=Tv Series"><?php echo $movie_title; ?></a>
                                </li>
                            </ul>							
<?php			
									}
											
				//the switch statement end						
					}

  
  ?>    
  						                        
 </div>
   <?php
   	//IF GET ends here
	}
   ?>                     
  </div>
                    <!--Selected by Categories Modul-->
                    <div class="panel panel-info">
                    	<div class="panel-heading">
                        	<div class="sidebar-header">Select by Categories</div>
                        </div>
                        <div class="panel-body">
                        	<form method="post" action="categoryReDirect.php">
                            	<div class="form-group">
                                	<select id="product-select" name="movieCategory" class="form-control input-lg">
                                    	<option value="0" disabled selected>Select The Genre</option>
                                        <option value="Action">Action</option>
                                        <option value="Horror">Horror</option>
                                        <option value="Commedy">Commedy</option>
                                    </select>
                                    <select id="product-select" name="movieDB" class="form-control input-lg">
                                    	<option value="0" disabled selected>Select The Category</option>
                                        <option value="new_movies">New Movies</option>
                                        <option value="popular_movies">Popular Movies</option>
                                        <option value="tv_series">TV Series</option>
                                    </select>
                                    	<div class="input-group">
                                        	<div class="input-group-btn">
                                            	<button class="btn btn-default btn-lg form-control input-lg" type="submit" name="searchByCategory">
                                                	<i class="glyphicon glyphicon-search"></i>
                                                </button>
                                            </div>
                                        </div>
                                </div>
                            </form>
                        </div>
                    </div>
                    <!--Modul for the shopping cart-->
                    <div class="panel panel-info">
                    	<div class="panel-heading">
                        	<div class="sidebar-header">
                            	Items in your shopping Cart
                            </div>
                        </div>
                        <div class="panel-body">
                        	<div class="list-group-item">
                            	<i class="glyphicon glyphicon-shopping-cart"></i><span class="badge">4</span>
                            </div>
                            	<button style="margin-top:10px;" class="btn btn-primary" type="submit">Submit Order</button>
                        </div>
                    </div>
                </div>