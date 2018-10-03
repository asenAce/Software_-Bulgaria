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
            	Wellcome to Cars Lovers Blog
                	<small>New User</small>
            </h1>
 <?php
 	
 	createAnUser();
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
                	<label for="firstName">User First Name</label>
                    	<input type="text" class="form-control" name="user_firstname" placeholder="Please Write your first name"></input>
            	</div>
                <div class="form-group">
                	<label for="lastName">User Last Name</label>
                    	<input type="text" class="form-control" name="user_lastname" placeholder="Please Write your last name"></input>
            	</div>
                <div class="form-group">
                	<label for="userEmail">User E-mail</label>
                    	<input type="email" class="form-control" name="user_email" placeholder="Please Write your email"></input>
            	</div>
                <div class="form-group">
                	<input class="btn btn-primary" type="submit" name="createUser" value="Registrate"></input>
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

