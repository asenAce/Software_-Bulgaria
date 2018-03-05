<?php
	session_start();
	ob_start();
	include"db.php";
?>

<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Untitled Document</title>
	<link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="css/blog-home.css" rel="stylesheet" type="text/css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="css/custom.css" rel="stylesheet" type="text/css">
    <link href="css/sb-admin.css" rel="stylesheet" type="text/css">

</head>
<body>
	<?php include("navigation.php");  ?>
    </br>
    </br>
    </br>
    <div class="container" style="margin-top:280px"; >
			
		<form method="post" action="login.php" >
        		<h1>Log in Form</h1>	
        	<div class="form-group">	
            	<input type="text" name="username" placeholder="Please enter your username" class="form-control"></input>
        	</div>
        	<div class="form-group">	
            	<input type="password" name="password" placeholder="Please enter your password" class="form-control"></input>
        	</div>
            <span class="input-group-btn">
            	<button name="login" class=" btn btn-primary" type="submit" value="Log In" style="text-height:font-size:40px;">
                                  Log In
                </button>
           	</span>
        </form>
     </div>   
     <?php
	 	if(isset($_POST['login'])){
			
			$username = $_POST['username'];
			$userpassword =$_POST['password'];
			
			
			if(empty($username) && empty($userpassword)){
				
				echo "<h2>Fields can not be empty</h2>";
				
			} else {
				
				//$username= mysqli_real_escape_string($connection,$username);
				//$userpassword= mysqli_real_escape_string($connection,$userpassword);
				
				
				$query = "SELECT * FROM admins";
				$send_query = mysqli_query($connection,$query);
				
				while($row=mysqli_fetch_array($send_query)){
					
					$the_username = $row['admin_username'];
					$the_password = $row['admin_password'];
					
					if($the_username == $username && $the_password == $userpassword){
						
						$_SESSION['admin_username'] =$the_username ;
						
						header("Location:admin_page.php");
						
					} else {
						
						echo "<h2>No such Admin!</h2>";	
						
					}
					
					
				}
				
				
				
			}
			
			
			
		}
		
		if($_SESSION['admin_username']){
			
			echo "<h2>You are loged in</h2>". $_SESSION['admin_username'];
		} else {
			
			echo "<h2>Please login</h2>";	
		}
	 
	 
	 ?>
</body>
</html>