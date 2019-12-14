
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
                    <h2>Register</h2>
                    <hr>
      <?php
	  				if(isset($_POST['register'])){
	                	
                    	$userNameReg = $_POST['register_name'];
						$userPasswordReg = $_POST['register_password'];
						$userEmailReg=$_POST['register_email'];
						
							$registerUser = "INSERT INTO users(user_name,user_password,email) VALUES('$userNameReg','$userPasswordReg','$userEmailReg')";
							$registrateUser=$theConnection->executeTheQuery($registerUser);
								if($registrateUser){
									$theUser=$_SESSION['user'];
									header("Location:index.php");
								}
					}
					
					
      ?>              
                    <form method="post" action="">
                    	<button class="btn btn-lg btn-warning pull-right" style="margin-bottom:2%;" type="submit" name="register">Register</button>
                        <div class="form-group" >
                          <input type="text" placeholder="your name" class="form-control input-lg" name="register_name">
                        </div>
                        <div class="form-group" >
                          <input type="password" placeholder="your password" class="form-control input-lg" name="register_password">
                        </div>
                        <div class="form-group">
                          <input type="email" placeholder="your e-mail" class="form-control input-lg" name="register_email">
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