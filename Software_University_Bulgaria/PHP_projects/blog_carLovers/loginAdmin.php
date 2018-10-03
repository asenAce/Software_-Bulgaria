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
            	Log in Admin
            </h1>
            
 <?php

 	if(isset($_POST['loginadmin'])){
		$adminname = $_POST['admin_Name'];
		$adminpassword= $_POST['password_admin'];
		
			$queryAdmin = "SELECT * FROM admin";
			 $logAdmin = $theConnection->executeTheQuery($queryAdmin); 
			 	$theConnection->confirmTheQuery($logAdmin);
			 
			 	while($row = mysqli_fetch_assoc($logAdmin)){
					$theadminname = $row['admin_username'];
					$theadminpassword = $row['admin_password'];
					
					
						if($theadminname == $adminname && $theadminpassword == $adminpassword){
							$_SESSION['admin'] = $theadminname; // !NOT $theAdmin BUT $theadminname;
							header("Location:admin/index.php");
						} else {
							echo "<h2>No Such Admin!</h2>";	
						}
				}
	}
 	
 ?>           
            <form action="" method="post" enctype="multipart/form-data">
            	<div class="form-group">
                	<label for="userName">Admin Name</label>
                    	<input type="text" class="form-control" name="admin_Name" placeholder="Please Write your admin name"></input>
            	</div>
                <div class="form-group">
                	<label for="userPass">Admin Passowrd</label>
                    	<input type="password" class="form-control" name="password_admin" placeholder="Please Write your admin password"></input>
            	</div>
                <div class="form-group">
                	<input class="btn btn-primary" type="submit" name="loginadmin" value="Log in"></input>
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

