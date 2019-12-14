
 <div class="col-lg-3 col-lg-pull-9">
                	<div class="panel panel-info hidden-xs">
						<div class="panel-heading">
                        	<div class="sidebar-header">
                            	Search
                            </div>
                        </div>
                        <div class="panel-body">
                        	<form role="search" method="post" action="searchEngine.php">
                               <div class="form-group">
                            	<select id="product-select" name="movieDB" class="form-control input-lg">
    								<option  value="0" disabled selected>Select Product</option>
                                    <optin>New Movies</option>
                            	</select>
                                	<div class="input-group">
                                    	<input type="search" class="form-control input-lg" placeholder="Search Movie Title" name="searchWord">
                                        <div class="input-group-btn">
                                        	<button class="btn btn-default btn-lg" type="submit" name="searchSubmit"><i class="glyphicon glyphicon-search"></i></button>
                                        </div>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
  <?php
  		if(isset($_POST['loginUser'])){
							$user_name=$_POST['username'];		
							$user_password=	$_POST['userpassword'];	
						
							$queryUser="SELECT * FROM users";	
							$loginUser=$theConnection->executeTheQuery($queryUser);
								if(!$loginUser){
									echo "user query failed".mysqli_error($theConnection);
								}
								
								while($row=mysqli_fetch_assoc($loginUser)){
									$theUsername=$row['user_name'];
									$theUserPassword=$row['user_password'];
									
									if($theUsername == $user_name && $theUserPassword==$user_password){
										 $_SESSION['user'] = $theUsername;
										 header("Location:index.php");
									} else {
										echo "No such user";	
									}
								}
	
	   }
	   
	   if(!$_SESSION['user']){
		   if(!$_SESSION['admin_username']) {
			   echo "<div class='panel panel-info'>";
			   echo "<div class='panel-heading'>";
			   echo "<div class='sidebar-header'>User Login</div>";
			   echo "</div>";
			   echo "<div class='panel-body'>";
			   echo "<form role='form' method='post' action=''>";
			   echo "<div class='form-group'>";
			   echo "<input type='text' class='form-control input-lg' placeholder='Username' name='username'>";
			   echo "</div>";
			   echo "<div class='form-group'>";
			   echo "<input type='password' class='form-control input-lg' placeholder='Password' name='userpassword'>";
			   echo "</div>";
			   echo "<button type='submit' class='btn btn-warning pull-right' name='loginUser'>Login</button>";
			   echo "</form>";
			   echo "</div>";
		   }
	   }
	   
  
  ?>                  
                    <!--<div class="panel panel-info">
                    	<div class="panel-heading">
                        	<div class="sidebar-header">User Login</div>
                        </div>
                        <div class="panel-body">
                        	<form role="form" method="post" action="">
                            	<div class="form-group">
                                	<input type="text" class="form-control input-lg" placeholder="Username" name="username">
                                </div>
                                <div class="form-group">
                                	<input type="password" class="form-control input-lg" placeholder="Password" name="userpassword">
                                </div>
                                	<button type="submit" class="btn btn-warning pull-right" name="loginUser">Login</button>
                            </form>
                        </div>-->
    <?php
	
	
		if(isset($_POST['adminLogin'])){
									
					$username= $_POST['adminName'];
					$password = $_POST['adminPassword'];
											
											
					$query = "SELECT * FROM admin";
											
					$loginAdmin=$theConnection->executeTheQuery($query);
						if(!$loginAdmin){
							 echo "failed to log in".mysqli_error($theConnection);
							}
						   
							  while($row=mysqli_fetch_assoc($loginAdmin)){
													
									 $admin_id = $row['admin_id'];
									 $admin_username = $row['admin_username'];
									 $admin_password = $row['admin_password'];
		
										 if($admin_username == $username && $admin_password == $password){
													   
												  $_SESSION['admin_username'] = $admin_username;	
												  $_SESSION['admin_id'] = $admin_id;	
													   
													   header("Location:admin/index.php"); 
													} else {
														echo "No such User";	
													}
									
									}
			
					}		
		
		if(!$_SESSION['admin_username']){
		    if(!$_SESSION['user']){
				echo "<div class='panel-heading'>";	
				echo "<div class='sidebar-header'>Admin Login</div>";
				echo "</div>";
				echo "<div class='panel-body'>";
				echo "<form role='form' method='post' >";
				echo "<div class='form-group'>";
				echo "<input type='text' class='form-control input-lg' placeholder='Admin Name' name='adminName'>";	
				echo "</div>";
				echo "<div class='form-group'>";
				echo "<input type='password' class='form-control input-lg' placeholder='Password' name='adminPassword'>";
				echo "</div>";
				echo "<button type='submit' name='adminLogin' class='btn btn-warning pull-right'>Login</button>";
				echo "</form>";
				echo "</div>";
				echo "</div>";
			}
		}
	
	?>                    
                 
                   <div class="panel panel-info">
                   		<div class="panel-heading">
                        	<div class="sidebar-header">
                            	Three most Rated Movies
                            </div>
                        </div>
                        <div class="panel-body">
                        	<ul class="list-group">
                            	<li class="list-group-item list-group-warning">
                                	<span class="badge">8.7</span>
                                    	<a href="#">Indiana Jhones</a>
                                </li>
                            </ul>
                        	<ul class="list-group">
                            	<li class="list-group-item list-group-warning">
                                	<span class="badge">9.7</span>
                                    	<a href="#">The Matrix</a>
                                </li>
                            </ul>
                        	<ul class="list-group">
                            	<li class="list-group-item list-group-warning">
                                	<span class="badge">9.8</span>
                                    	<a href="#">Saving Private Rayan</a>
                                </li>
                            </ul>
                        </div>
                   </div>
                   <div class="panel panel-info">
                   		<div class="panel-heading">
                        	<div class="sidebar-header">Select by Categories</div>
                        </div>
                        <div class="panel-body">
                        	<div class="nav nav-stacked" style="text-decoration:none;">
                            	<ul class="list-unstyled text-center" style="text-decoration:none;">
                                	<li style="text-decoration:none;"><a style="text-decoration:none;"  href="#">Commedy</a></li>
                                    <li><a href="#">Action</a></li>
                                    <li><a href="#">Horror</a></li>
                                    <li><a href="#">Drama</a></li>
                                </ul>
                            </div>
                        </div>
                   </div> 
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