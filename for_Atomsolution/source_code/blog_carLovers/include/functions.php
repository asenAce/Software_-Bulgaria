<?php

	require_once"db.php";
	$theConnection = new Db("localhost","root","","cms_carlovers");

	function confirmTheQuery($incomig) {
				global $theConnection;
			
				if(!$incomig){
					echo "Add Query Failed".mysqli_error($theConnection);
				}

			}
	
	function createAnUser(){
		global $theConnection;
		
		if(isset($_POST['createUser'])){
		
		$userName = $_POST['user_Name'];
		$userPassword = $_POST['password_user'];
		$userFirstName = $_POST['user_firstname'];
		$userLastName = $_POST['user_lastname'];
		$userEmail = $_POST['user_email'];
		$userDate = date('d-m-y');
		$userRole = "an user";
		
			$userQuery = "INSERT INTO users(user_name,user_password,users_firstname,user_lastname,email,role,user_registered_on) ";
			$userQuery .="VALUES('$userName','$userPassword','$userFirstName','$userLastName','$userEmail','$userRole',now())";
				$cerateTheUser = $theConnection->executeTheQuery($userQuery);
					confirmTheQuery($cerateTheUser);
					
		}	
		
	}

?>