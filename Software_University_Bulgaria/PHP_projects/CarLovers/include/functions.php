<?php
	session_start();
	require_once"db.php";
	$theConnection = new Db("localhost","root","","cms");

	function confirmTheQuery($incoming){
				global $theConnection;
				if(!$incoming){
					echo "Add Query Failed".mysqli_error($theConnection);
				} 
				
				
			}
			
	function createanUser(){
	  global $theConnection;
			if(isset($_POST['createUser'])){
		
			    $userName=$_POST['userName'];
				$userPassword=$_POST['userPassword'];
			    $userFirstName=$_POST['userFirstName'];
				$userLastname=$_POST['userLastname'];
					 
				//$user_image = $_FILES['image']['name'];
				//$user_image_temp = $_FILES['image']['tmp_name'];
					 
				$userEmail=$_POST['userEmail'];
				$userRegisteredOn=date('d-m-y');
				$userRole="an user";
			
					 
					 
			    // move_uploaded_file($user_image_temp,"images/users/$user_image");
					
				
					$theQuery ="INSERT INTO users(username,user_password,user_firstname,user_lastname,email,role,user_registered_on) ";
					$theQuery .="VALUES('$userName','$userPassword','$userFirstName','$userLastname','$userEmail','$userRole',now())";	
					 $createanUser=$theConnection->executeTheQuery($theQuery);
							confirmTheQuery($createanUser);
							if($createanUser){
								$theUser=$_SESSION['user'];
								header("Location:loginUser.php");
							}
					}
	}


?>