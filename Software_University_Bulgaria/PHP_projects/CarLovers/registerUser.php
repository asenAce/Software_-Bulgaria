<?php
	require_once"include/db.php";
	require_once"include/functions.php";
	$theConnection = new Db("localhost","root","","cms");
	
?>
<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

<title>Cars Lovers Bootstrap Blog Template</title>

    <!-- Bootstrap Core CSS -->
    
    <!-- Custom CSS -->

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

<link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
<link href="css/blog-home.css" rel="stylesheet" type="text/css">
<link href="css/adsBanner.css" rel="stylesheet" type="text/css">
<script src="/js/bootstrap.min.js"></script>
</head>
<body style="background-image: url(images/bluePrints/bluePrintFr.PNG); background-repeat:no-repeat; background-size:100%; background-size:cover; ">

    <!-- Navigation -->
	<?php
			
	include "include/navigation.php";
	?>
    <!-- Page Content -->
<div class="container">    
      <div class="row">
        <!--  Register User  -->
         <div class="col-lg-12">
                    	<h1 class="page-header">
                            Wellcome to Cars Lovers Blog
                            <small>New User</small>
                        </h1>
                   <!-- Table Posts -->     
 <?php
 				   // Craete User Function
				   createanUser();
 
 ?>                  
                       <form action="registerUser.php" method="post" enctype="multipart/form-data">
                                <div class="form-group">
                                    <label for="userName">User Name</label>
                                    <input type="text" class="form-control" name="userName" value="please write a   user name"></input>
                                </div>
 							    <div class="form-group">
                                    <label for="userPassword">User Password</label>
                                     <input  type="password" class="form-control" name="userPassword" ></input>
                                </div>
                                <div class="form-group">
                                    <label for="userFirstName">User first Name</label>
                                    <input  type="text" class="form-control" name="userFirstName" value="please write a your first name"></input>
                                </div>
                                <div class="form-group">
                                    <label for="userLastName">User Last Name</label>
                                    <input type="text" class="form-control" name="userLastname" value="please write a your last name"></input>
                                </div>
                                <div class="form-group">
                                    <label for="userEmail">User email</label>
                                    <input  type="email" class="form-control" name="userEmail" value="please write a your email"></input>
                                </div>
                                <!-- User Picture
                                <div class="form-group">
                                    <label for="userPicture">User Picture</label>
                                    <input type="file" class="form-control" name="image" value="please upload a profile picture"></input>
                                </div>
                                -->  
                                <div class="form-group">
                                    <input class="btn btn-primary" type="submit" name="createUser" value="Registar"></input>
                                </div> 
                            </form>    
                    </div>
     </div>
 </div>

        </div>
        <!-- /.row -->


        <hr>


        <!-- Footer -->
        
  <?php
  
  	include "include/footer.php";
  
  ?>