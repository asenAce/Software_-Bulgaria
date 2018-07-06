<?php

  include_once "db.php";
  $theConnection = new Db("localhost","root","","cms");
  
  			function confirmTheQuery($incoming){
				global $theConnection;
				if(!$incoming){
					echo "Add Query Failed".mysqli_error($theConnection);
				} 
				
				
			}
  
  

  			 function insertNewCategory(){
						global $theConnection;
						if(isset($_POST['submit'])){
								$cat_title=$_POST['cat_title'];
								
								if($cat_title == "" || empty($cat_title)){
									echo "the field should not be empty";	
								} else {
									$insertIntoCategories=$theConnection->executeTheQuery("INSERT INTO categories(cat_title) VALUES('$cat_title') ");
									if(!$insertIntoCategories){
										die('Query Insert Failed').mysqli_error($theConnection);
									}
								}
							}	  	  
 			 }
			 
			 function createNewAdmin(){
				   global $theConnection;
				   if(isset($_POST['submitAdmin'])){
					    $add_admin=$_POST['add_admin'];
					    $add_password=$_POST['add_admin_password'];
						
						if($add_admin == "" || empty($add_password)){
									echo "the field/s should not be empty";	
								} else {
							 $addNewAdmin=$theConnection->executeTheQuery("INSERT INTO admin(admin_username,admin_password) VALUES('$add_admin','$add_password') ");
									if(!$addNewAdmin){
										die('Query Insert Failed').mysqli_error($theConnection);
									}
								}			
						
				   }
				 
			 }
			 
			 function createNewUser(){
				global $theConnection;
				   if(isset($_POST['submitUser'])){
					    $userName=$_POST['userName'];
					    $userPassword=$_POST['userPassword'];
						$firstName=$_POST['firstName'];
						$userLastname=$_POST['userLastname'];
						$userEmail=$_POST['userEmail'];
						$userRole=$_POST['userRole'];
						$userRegisteredOn=date('d-m-y');
						
						
						if($userName == "" || empty($userPassword)){
									echo "the field/s should not be empty";	
								} else {
								$newUserQuery="INSERT INTO users(username,user_password,user_firstname,user_lastname,email,role,user_registered_on) ";
								$newUserQuery.="VALUES('$userName','$userPassword','$firstName','$userLastname','$userEmail','$userRole','$userRegisteredOn') ";	
							    $addNewUser=$theConnection->executeTheQuery($newUserQuery);
									if(!$addNewUser){
										die('Query Insert Failed').mysqli_error($theConnection);
									}
								}			
						
				   }	 
				 
			 }
			 
			 
			 
			 function deleteCategory(){
				    global $theConnection;
					if(isset($_GET['delete'])){
						  $theCatid =$_GET['delete'];
						  $deleteTheSelectedCate=$theConnection->executeTheQuery("DELETE FROM categories WHERE cat_id ='$theCatid' ");
						   header("Location:categories.php");
					}		
								
			 }
			 
			 function deleteAdmin(){
				 global $theConnection;
					if(isset($_GET['delete'])){
						  $theAdminID =$_GET['delete'];
						  $deleteTheSelectedAdmin=$theConnection->executeTheQuery("DELETE FROM admin  WHERE admin_id ='$theAdminID' ");
						  confirmTheQuery($deleteTheSelectedAdmin);
						   header("Location:addAdmin.php");
					}		
				 
			 }
			 
			 
			 
			 function findAllCategories(){
				global $theConnection;
				$selectAllCategories = $theConnection->executeTheQuery("SELECT * FROM categories");
						  while($row=mysqli_fetch_assoc($selectAllCategories)){
									$category_title= $row['cat_title'];
									$category_id= $row['cat_id'];
												  
												  echo "<tr>";
												  	  echo"<td>$category_id</td>";
													  echo"<td>$category_title</td>";
													  echo"<td><a href='categories.php?delete=$category_id'>Delete</a></td>";
													  echo"<td><a href='categories.php?edit=$category_id'>Edit</a></td>";
												  echo "</tr>";
	         	  } 
				 
			 }
			 
			 
			 function findAllAdmins(){
				global $theConnection;
				$selectAllAdmins = $theConnection->executeTheQuery("SELECT * FROM admin");
						  while($row=mysqli_fetch_assoc($selectAllAdmins)){
							  		$adminID= $row['admin_id'];
									$admin_username= $row['admin_username'];
									$admin_password= $row['admin_password'];
												  
												  echo "<tr>";
												  	  echo"<td>$adminID</td>";
													  echo"<td>$admin_username</td>";
													  echo"<td>$admin_password</td>";
													  echo"<td><a href='addAdmin.php?delete=$adminID'>Delete</a></td>";
													  echo"<td><a href='addAdmin.php?edit=$adminID'>Edit</a></td>";
												  echo "</tr>";
	         	  } 
				 
			 }
			 
			 function findAllUsers(){
				 global $theConnection;
				$selectAllUsers = $theConnection->executeTheQuery("SELECT * FROM users");
					confirmTheQuery($selectAllUsers);
						  while($row=mysqli_fetch_assoc($selectAllUsers)){
							  		$userID= $row['user_id'];
									$username= $row['username'];
									$user_password= $row['user_password'];
									$firstName=$row['user_firstname'];
									$user_Lastname=$row['user_lastname'];
									$user_Email=$row['email'];
									$user_Role=$row['role'];
									$user_RegisteredOn=$row['user_registered_on'];
												  
												  echo "<tr>";
												  	  echo"<td>$userID</td>";
													  echo"<td>$username</td>";
													  echo"<td>$user_password</td>";
													   echo"<td>$firstName</td>";
													  echo"<td>$user_Lastname</td>";
													  echo"<td>$user_Email</td>";
													   echo"<td>$user_Role</td>";
													    echo"<td>$user_RegisteredOn</td>";
													  echo"<td><a href='addUser.php?delete=$userID'>Delete</a></td>";
													  echo"<td><a href='addUser.php?edit=$userID'>Edit</a></td>";
												  echo "</tr>";
	         	  } 
				 
			 }
			 
			 
			 
			 function submitEditedAdmin(){
				 global $theConnection;
					if(isset($_POST['submitEditedAdmin'])){
						
							   $selectedAdminID =$_POST['submitEditedAdmin'];
							   
							   $upIDAdmin=$_POST['TheadminID'];
							   $upAdmin=$_POST['Theadmin_username'];
							   $upAdminPass=$_POST['Theadmin_password'];
							   
							    $upDateQuery="UPDATE admin SET admin_username='$upAdmin',admin_password='$upAdminPass' WHERE admin_id='$upIDAdmin'";
								
								$editTheAdmin=$theConnection->executeTheQuery($upDateQuery); //if you have problem changet with the other category_id;
								 if(!$editTheAdmin){
									   die("Edit Query failed").mysqli_error($theConnection);
									} else {
									   header("Location:addAdmin.php");
								    } 
							} 
				 
				 
			 }
			 
			 function submitEditedUser(){
				 global $theConnection;
					if(isset($_POST['submitUser'])){
									   
							   $upIDUser=$_POST['TheUserID'];
							   $upUserName=$_POST['TheUserName'];
							   $upUserPass=$_POST['TheUserPassword'];
							   $TheUserFirstName=$_POST['TheUserFirstName'];
							   $TheUserLastName=$_POST['TheUserLastName'];
							   $TheUserEmail=$_POST['TheUserEmail'];
							   $TheUserRole=$_POST['TheUserRole'];
							   $TheUserRegistration=$_POST['TheUserRegistration'];
							   
							    $upDateUserQuery="UPDATE users SET username='$upUserName',user_password='$upUserPass',user_firstname='$TheUserFirstName',user_lastname='$TheUserLastName'";
								$upDateUserQuery .=",email='$TheUserEmail',role='$TheUserRole',user_registered_on=now() ";
								$upDateUserQuery .="WHERE user_id='$upIDUser'";
								
								        // WHERE admin_id='$upIDAdmin'";
								
								
								$editTheUser=$theConnection->executeTheQuery($upDateUserQuery); //if you have problem changet with the other category_id;
								 if(!$editTheUser){
									   die("Edit Query failed").mysqli_error($theConnection);
									} else {
									   header("Location:addUser.php");
								    } 
							} 
				 
			 }
			 
			 
			 
			 function createPosts(){
				  global $theConnection;
					if(isset($_POST['create_post'])){
		
					 $post_title=$_POST['title'];
					 $post_author=$_POST['author'];
					 $post_category_id = 6; //$_POST['post_category_id'];
					 $post_category=$_POST['theCategory'];
					 $post_status=$_POST['post_status'];
					 
					 $post_image = $_FILES['image']['name'];
					 $post_image_temp = $_FILES['image']['tmp_name'];
					 
					 $post_tags=$_POST['post_tag'];
					 $post_content=$_POST['post_content'];
					 $post_date=date('d-m-y');
					 $post_comment_count =4;
					 
					 
					 move_uploaded_file($post_image_temp,"../images/$post_image");
					
				
					$theQuery ="INSERT INTO posts(post_title,post_author,post_category_id,post_category,post_date,post_image,post_content,post_tags,post_comment_count,post_status) ";
					$theQuery .="VALUES('$post_title','$post_author','$post_category_id','$post_category',now(),'$post_image','$post_content','$post_tags','$post_comment_count','$post_status')";	
					 $createPostQuery=$theConnection->executeTheQuery($theQuery);
							confirmTheQuery($createPostQuery);
		 				 
					} 
				 
				 
			 }
			 
			 
			 function addPhoto(){
				 global $theConnection;
					if(isset($_POST['create_photo'])){
		
					 $photo_title=$_POST['title'];
					 $photo_category=$_POST['theCategory'];
					 
					 
					 $photo_image = $_FILES['image']['name'];
					 $photo_image_temp = $_FILES['image']['tmp_name'];
					 				 
					 move_uploaded_file($photo_image_temp,"../images/$photo_image");
					
				
					$theQuery ="INSERT INTO photoalbum(photo_title,photo_post_category,photo_image) ";
					$theQuery .="VALUES('$photo_title','$photo_category','$photo_image')";	
					$createPhotoQuery=$theConnection->executeTheQuery($theQuery);
							confirmTheQuery($createPhotoQuery);
		 				 
					} 
				 
				 
			 }
			 
			 
			 
			 function editPost(){
				global $theConnection;
				if(isset($_POST['edit_post'])){
		
					 $thePost_id=$_POST['post_id'];
					 $post_title=$_POST['title'];
					 $post_author=$_POST['author'];
					 $post_category_id = 6; //$_POST['post_category_id'];
					 $post_status=$_POST['post_status'];
					 $post_category =$_POST['post_category']; 
					 
					 $post_image = $_FILES['image']['name'];
					 $post_image_temp = $_FILES['image']['tmp_name'];
						if(empty($post_image)){
							$takeTheImage=$theConnection->executeTheQuery("SELECT * FROM posts WHERE post_id='$thePost_id'");
							 while($row=mysqli_fetch_assoc($takeTheImage)){
								 $post_image- $row['post_image'];
							 }
						}
						
					 $post_tags=$_POST['post_tags'];
					 $post_content=$_POST['post_content'];
					 $post_date=date('d-m-y');
					 $post_comment_count =4;	
					 
					 move_uploaded_file($post_image_temp,"../images/$post_image");
					 
					 $editQuery = "UPDATE posts SET post_title='$post_title',post_category_id='$post_category_id',post_date='$post_date',post_author='$post_author',post_status='$post_status',";
					 $editQuery .="post_tags='$post_tags',post_content='$post_content',post_image='$post_image',post_category='$post_category' WHERE post_id='$thePost_id'";
					 
					 $editPostbyId = $theConnection->executeTheQuery($editQuery);
					 confirmTheQuery($editPostbyId);
			        if($editPostbyId){
						echo "Post was edited successfully";
						header("Location:view_all_posts.php");
					}
				} 
		 
			 }
			 
			 
			  function editPhoto(){
				global $theConnection;
				if(isset($_POST['editPhoto'])){
		
					 $photoID=$_POST['photoID'];
					 $title=$_POST['title'];
					 $theCategory=$_POST['theCategory'];
					 
					 
					 $photo_image = $_FILES['image']['name'];
					 $photo_image_temp = $_FILES['image']['tmp_name'];
						if(empty($photo_image)){
							$takeTheImage=$theConnection->executeTheQuery("SELECT * FROM photoalbum WHERE photo_id='$photoID'");
							 while($row=mysqli_fetch_assoc($takeTheImage)){
								 $photo_image=$row['photo_image'];
							 }
						}
					
					 
					 move_uploaded_file($photo_image_temp,"../images/$photo_image");
					 
					 $editQuery = "UPDATE photoalbum SET photo_title='$title',photo_image='$photo_image',photo_post_category='$theCategory' ";
					 $editQuery .="WHERE photo_id='$photoID'";
					 
					 $editPhotobyId = $theConnection->executeTheQuery($editQuery);
					 confirmTheQuery($editPhotobyId);
			        if($editPhotobyId){
						echo "Post was edited successfully";
						header("Location:view_all_photos.php");
					}
				} 
		 
			 }
			 
			 
			 
			 
			 
			 function deletePost(){
				global $theConnection;
					if(isset($_GET['delete'])){
					$thePostid =$_GET['delete'];
					
					$deleteQuery=$theConnection->executeTheQuery("DELETE FROM posts WHERE post_id ='$thePostid' ");
					confirmTheQuery($deleteQuery);
					header("Location:view_all_posts.php");
				}  
				 
			 }
			 
			 function deletePhoto(){
				global $theConnection;
					if(isset($_GET['delete'])){
					$thePhotoID =$_GET['delete'];
					
					$deleteQuery=$theConnection->executeTheQuery("DELETE FROM photoalbum WHERE 	photo_id ='$thePhotoID' ");
					confirmTheQuery($deleteQuery);
					header("Location:view_all_photos.php");
				}  	 
				 
			 }
			 
			 
			 
			 function deleteComment(){
				global $theConnection;
					if(isset($_GET['delete'])){
					$theCommentid =$_GET['delete'];
					
					$deleteCommentQuery=$theConnection->executeTheQuery("DELETE FROM comments WHERE comment_id ='$theCommentid' ");
					confirmTheQuery($deleteCommentQuery);
					header("Location:view_all_comments.php");
				}  	 
				 
			 }
			 
			 
			 
			 function deleteUser(){
				global $theConnection;
					if(isset($_GET['delete'])){
					$theUserID =$_GET['delete'];
					
					$deleteQuery=$theConnection->executeTheQuery("DELETE FROM users WHERE user_id ='$theUserID' ");
					confirmTheQuery($deleteQuery);
					header("Location:view_all_users.php");
				}  
				 
			 }
			 
			 
			 
			 

?>