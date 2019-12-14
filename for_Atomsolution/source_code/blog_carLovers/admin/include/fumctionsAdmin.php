<?php
	include_once "db.php";
	$theConnection = new Db("localhost","root","","cms_carlovers");
	ob_start();
	
	function confirmTheQuery($incomig){
		global $theConnection;
			
			if(!$incomig){
				echo "Add Query Failed".mysqli_error($theConnection);
			}
		
	}

	

	function addPost(){
		global $theConnection;
	
		if(isset($_POST['create_post'])){
				
				$post_title = $_POST['title'];
				$post_author = $_POST['author'];
				$post_category_id = 6;
				$post_category = $_POST['category'];
				$post_status = $_POST['post_status'];
				
				$post_image = $_FILES['image']['name'];
				$post_image_temp = $_FILES['image']['tmp_name'];
				
				
				$post_tag = $_POST['post_tag'];
				$post_content = $_POST['post_content'];
				$post_date = date('d-m-y');
				$post_link = $_POST['post_link'];
				
				move_uploaded_file($post_image_temp,"image_cars/$post_image");
				
				$theQuery ="INSERT INTO posts(post_title,post_author,post_category_id,	post_category,post_status,post_image,post_tags,post_content,post_date,post_link)";
				$theQuery .= "VALUES('$post_title','$post_author','$post_category_id','$post_category','$post_status','$post_image','$post_tag','$post_content',now(),'$post_link')";
				
				$createPostQuery = $theConnection->executeTheQuery($theQuery);
					if(!$createPostQuery){
						echo "Query Failed" .mysqli_error($theConnection);
					}
				
			}			
		
		
		
	}
	
	function addService() {
		
		
		$service_title = $_POST['title'];
		$sub_service_title = $_POST['sub_service'];
		$service_description = $_POST['service_description'];
		$sub_service_description = $_POST['sub_service_description'];
		
		$main_menu_image = $_FILES['main_menu_image']['name'];
		$main_menu_image_temp = $_FILES['main_menu_image']['tmp_name'];
		
		$sub_menu_image = $_FILES['sub_menu_image']['name'];
		$sub_menu_image_temp = $_FILES['sub_menu_image']['tmp_name'];
		
		$service_key_word = $_POST['service_key_word'];
		$sub_service_key_word = $_POST['sub_service_key_word'];
		
			move_uploaded_file($main_menu_image_temp,"image_cars/$main_menu_image");
			move_uploaded_file($sub_menu_image_temp,"image_cars/$sub_menu_image");
		
		$theQuery = "INSERT INTO menu (main_menu,sub_menu,description_menu,image_menu,image_sub_menu,description_sub_menu,key_word_main_service,key_word_sub_service)";
		$theQuery .="VALUES ('$service_title','$sub_service_title','$service_description','$main_menu_image','$sub_menu_image','$sub_service_description','$service_key_word','$sub_service_key_word')";
	
		$addService = $theConnection2->executeTheQuery($theQuery);
		
			if(!$addService){
						echo "Query Failed" .mysqli_error($theConnection2);
					}
		
	}
	
	
	
	function editPost(){
		global $theConnection;
		
		if(isset($_POST['edit_post'])){
			
				$postID = $_POST['post_id'];
				$post_title = $_POST['title'];
				$post_author = $_POST['author'];
				$post_category_id = 6;
				$post_category = $_POST['category'];
				$post_status = $_POST['post_status'];
				
				$post_image = $_FILES['image']['name'];
				$post_image_temp = $_FILES['image']['tmp_name'];
				
					if(empty($post_image)){
						$takeTheImage = $theConnection->executeTheQuery("SELECT * FROM posts WHERE post_id ='$postID'");
							while($row=mysqli_fetch_assoc($takeTheImage)){
								$post_image = $row['post_image'];
							}
					}
				
				$post_tag = $_POST['post_tag'];
				$post_content = $_POST['post_content'];
				$post_date = date('d-m-y');
				$post_link = $_POST['post_link'];
				
				move_uploaded_file($post_image_temp,"image_cars/$post_image");
		
				$editQuery ="UPDATE posts SET post_title ='$post_title',post_category_id='$post_category_id',post_date='$post_date',post_author='$post_author',post_status='$post_status',";
				$editQuery .="post_tags='$post_tag',post_content='$post_content',post_image='$post_image',post_category='$post_category' ";
				$editQuery .="WHERE post_id = '$postID'";
				
				$editPostbyID = $theConnection->executeTheQuery($editQuery);
					if(!$editPostbyID){
						echo "Query Edit Failed".mysqli_error($theConnection);
					}
					
					if($editPostbyID){
						echo "The Post was edited successfully";
						header("Location:view_all_posts.php");
					}
		
	}
		
		
	}
	
	
	function deletePost(){
		global $theConnection;
		
		if(isset($_GET['delete'])){
		$thePostID = $_GET['delete'];
		$deleteQuery = $theConnection->executeTheQuery("DELETE FROM posts WHERE post_id = '$thePostID'");
			if(!$deleteQuery){
				echo "Delete query failed".mysqli_error($theConnection);
			}
			
		header("Location:view_all_posts.php");
		
		}
		
		
	}
	
	function displayCategories(){
		global $theConnection;
		
		$selectAllCategories= $theConnection->executeTheQuery("SELECT * FROM categories");
				   	while($row=mysqli_fetch_assoc($selectAllCategories)){
						$category_id=$row['cat_id'];
						$category_title=$row['cat_title'];
						
							echo "<tr>";
								echo "<td>$category_id</td>";
								echo"<td>$category_title</td>";
								echo "<td><a href='categories.php?edit=$category_id'>Edit</a></td>";
								echo "<td><a href='categories.php?delete=$category_id'>Delete</a></td>";
							echo "</tr>";
					}	
		
	}
	
	function deleteCategory(){
		global $theConnection;
		
		if(isset($_GET['delete'])){
		     $theCatID = $_GET['delete'];
										
			$deleteTheSelectedCategory = $theConnection->executeTheQuery("DELETE FROM categories WHERE cat_id ='$theCatID'");
			header("Location:view_all_categories.php");	
			}
		
	}
	
	function addAdmin(){
		global $theConnection;
		
		if(isset($_POST['create_admin'])){
		
		$admin_username = $_POST['admin_username'];
		$admin_pasword = $_POST['admin_password'];
		
			if($admin_username == "" || empty($admin_username) || $admin_pasword == "" || empty($admin_pasword)){
				echo "The field should not be empty!";
			} else {
				$insertIntoAdmins = $theConnection->executeTheQuery("INSERT INTO admin (admin_username,admin_password) VALUES('$admin_username','$admin_pasword')");
					confirmTheQuery($insertIntoAdmins);
			}
		
	} 
		
	}
	
	function displayAdmins(){
		global $theConnection;
		
		$sellectAllAdmins=$theConnection->executeTheQuery("SELECT * FROM admin");
						while($row=mysqli_fetch_assoc($sellectAllAdmins)){
							$adminID=$row['admin_id'];
							$admin_username=$row['admin_username'];
							$admin_password=$row['admin_password'];
							
								echo "<tr>";
									echo "<td>$adminID</td>";
									echo "<td>$admin_username</td>";
									echo "<td>$admin_password</td>";
									echo "<td><a href='editAdmin.php?edit=$adminID'>Edit</a></td>";
									echo "<td><a href='editAdmin.php?delete=$adminID'>Delete</a></td>";
								echo "</tr>";
						}
		
	}
	
	
	function editAdmin(){
		global $theConnection;
		
		if(isset($_POST['edit_admin'])){
			
			 $theAdminID =$_POST['edit_admin'];
			 
			 //$adminid = $_POST['the_adminid'];
			 $adminid = $_POST['adminid'];
			 $adminUsername =$_POST['admin_username'];
			 $adminPassword =$_POST['admin_password'];
			 
			 	$editAdminQuery = "UPDATE admin SET admin_username='$adminUsername',admin_password='$adminPassword' WHERE admin_id='$adminid'";
				$editTheAdmin =$theConnection->executeTheQuery($editAdminQuery);
					confirmTheQuery($editTheAdmin);
					header("Location:view_all_admins.php");
		}	
		
		
	}
	
	function deleteAdmin(){
		global $theConnection;
		
		if(isset($_GET['delete'])){
			$thedeleteadminid = $_GET['delete'];
			$deletetheAdmin = $theConnection->executeTheQuery("DELETE FROM admin WHERE admin_id='$thedeleteadminid'");
				confirmTheQuery($deletetheAdmin);
				header("Location:view_all_admins.php");	
			
		}	
		
	}
	
	function deleteTheComment(){
		global $theConnection;
		
		if(isset($_GET['delete'])){
		$theDeleteID = $_GET['delete'];
		
			$deleteQuery = "DELETE FROM comments WHERE comment_id = '$theDeleteID'";
				$deleteTheComment=$theConnection->executeTheQuery($deleteQuery);
				  header("Location:view_all_comments.php");
		}
		
	}

	function deleteTheUser(){
		global $theConnection;
		if(isset($_GET['delete'])){
			
		$deleteUserID = $_GET['delete'];
			$deleteUserQuery = "DELETE FROM users WHERE user_id = '$deleteUserID'";
			  $delteTheUser = $theConnection->executeTheQuery($deleteUserQuery);
			  	confirmTheQuery($delteTheUser);
			  	header("Location:view_all_users.php");
		}	
		
	}






?>