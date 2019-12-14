
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
                    <h2>Contact Us</h2>
                    <hr>
                    <?php
						if(!$_SESSION['user']){
								echo "<a href='registration.php'>";
									echo "<button class='btn btn-lg btn-warning pull-left' style='margin-bottom:3%;' >Registration</button>";
								echo "</a>";
							}
					
					?>
                    <form method="post" action="sendEmail.php">
                    	<?php
							if($_SESSION['user']){
								echo "<button class='btn btn-lg btn-warning pull-right' style='margin-bottom:2%;' type='submit' name='sendTheEmail'>SEND</button>";
							}
							
						?>	
                        <div class="form-group" >
                      <input type="text" placeholder="your name" class="form-control input-lg" name="userName" value="<?php if(isset($_SESSION['user'])){ echo $_SESSION['user']; } ?>" readonly>
                        </div>
                        <div class="form-group">
                          <input type="email" placeholder="your e-mail" class="form-control input-lg" name="userEmail">
                        </div>
                        <div class="form-group">
                          <textarea class="form-control" name="mailSubject"></textarea>
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