
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
                    <h1>Contact Us</h1>
                    	<hr>
                    <?php
						if(!$_SESSION['user']){
								echo "<a href='registration.php?theKeyWord=New Movies'>";
								echo "<button class='btn btn-lg btn-warning pull-left' style='margin-bottom:3%;'>Registration</button>";
								echo "</a>";
							}
					
					?>    
                     <!-- Contact Form-->   
                    <form role="form" action="sendEmail.php" method="post">
                       <?php
							if($_SESSION['user']){
								echo"<button class='btn btn-lg btn-warning pull-right' style='margin-bottom:2%;' name='sendTheEmail'>SEND</button>";
							}
							
						
							
						?>  
                        <div class="form-group">	
                   	<input type="text" placeholder="Your Name" name="userName" value="<?php if(isset($_SESSION['user'])){ echo $_SESSION['user']; } ?>" class="form-control input-lg" readonly>
                        </div>
                        <div class="form-group">
                        	<input type="email" placeholder="Your Email" name="userEmail" required class="form-control input-lg">
                        </div>
                        <div class="form-group">
                        	<textarea  class="form-control " name="theMessage"></textarea>
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