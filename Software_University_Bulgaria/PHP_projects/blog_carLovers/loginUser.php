<?php
	
	require_once"include/functions.php";
	require_once"include/db.php";
	  $theConnection = new Db("localhost","root","","cms_carlovers");
?>
<!-- Header -->
<?php
	include "include/header.php";
?>
 <!-- Navigation -->
<?php
	include "include/navigation.php";
?> 
 <!-- Form Content -->
 <div class="container">
 	<div class="row">
    	<!-- Register User -->
        <div class="col-lg-12">
        	<h1 class="page-header">
            	Log in User
            </h1>
            
 <?php

 	if(isset($_POST['loginuser'])){
		$username = $_POST['user_Name'];
		$userpassword= $_POST['password_user'];
		
			$queryUser = "SELECT * FROM users";
			 $logUser = $theConnection->executeTheQuery($queryUser); 
			 	$theConnection->confirmTheQuery($logUser);
			 
			 	while($row = mysqli_fetch_assoc($logUser)){
					$theusername = $row['user_name'];
					$thepassword = $row['user_password'];
					
					
						if($theusername == $username && $thepassword == $userpassword){
							$_SESSION['user'] = $theusername;
							header("Location:index.php");
						} else {
							echo "<h2>No Such User!</h2>";	
						}
				}
	}
 	
 ?>           
            <form action="" method="post" enctype="multipart/form-data">
            	<div class="form-group">
                	<label for="userName">User Name</label>
                    	<input type="text" class="form-control" name="user_Name" placeholder="Please Write your user name"></input>
            	</div>
                <div class="form-group">
                	<label for="userPass">User Passowrd</label>
                    	<input type="password" class="form-control" name="password_user" placeholder="Please Write your user password"></input>
            	</div>
                <div class="form-group">
                	<input class="btn btn-primary" type="submit" name="loginuser" value="Log in"></input>
                </div>
            </form>
        </div>
    </div>
 </div>
 <!-- Form end --> 	
 
 <!-- Footer -->
 
 <?php
	include "include/footer.php";
?>

