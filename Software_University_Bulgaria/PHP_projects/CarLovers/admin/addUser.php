
<?php 
	include "includes/header.php"; 
	include "includes/adminFunctions.php";
	//Edit do not work
	
?>

    <div id="wrapper" style="margin-top:70px;">
      <?php include "includes/navigation.php" ?>
        <div id="page-wrapper">
            <div class="container-fluid">
                <!-- Page Heading -->
                <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">
                            Wellcome to Admin user:
                            <small>Create an User</small>
                        </h1>
                 <!-- The Category form -->       
                        <div class="col-xs-6">
                        <?php
							//function insert new Category;
							createNewUser();
							//fc submitUser
							submitEditedUser();
						?>
                          <form action="" method="post">
                          	 <div class="form-group">
                                <label for="cat-title">Add  User Name</label>
                             	<input class="form-control" type="text" name="userName"></input>
                             </div>
                             <div class="form-group">
                                <label for="cat-title">Add User Password</label>
                             	<input class="form-control" type="password" name="userPassword"></input>
                             </div>
                             <div class="form-group">
                                <label for="cat-title">User First Name</label>
                             	<input class="form-control" type="text" name="firstName"></input>
                             </div>
                             <div class="form-group">
                                <label for="cat-title">User Last Name</label>
                             	<input class="form-control" type="text" name="userLastname"></input>
                             </div>
                             <div class="form-group">
                                <label for="cat-title">User  Email</label>
                             	<input class="form-control"  type="email" name="userEmail"></input>
                             </div>
                             <div class="form-group">
                                <label for="cat-title">User Role</label>
                             	<input class="form-control" type="text" name="userRole"></input>
                             </div>
                             <div class="form-group">
                                <label for="cat-title">User Registered on</label>
                             	<input class="form-control" type="text" name="userRegisteredOn" readonly></input>
                             </div>
                             <div class="form-group">
                             	<input class="btn btn-primary" type="submit" name="submitUser" value="Create User"></input>
                             </div>
                          </form>
  <?php  ?>                        
                          <form action="" method="post">
                          	 <div class="form-group">
                                <label for="cat-title">Edit User</label>
                                <?php
								//Edit Process GET
									if(isset($_GET['edit'])){
										$userID = $_GET['edit'];
										
										$editUser = $theConnection->executeTheQuery("SELECT * FROM users WHERE user_id ='$userID' ");
											  while($row=mysqli_fetch_assoc($editUser)){
												  $user_id= $row['user_id'];
												  $username= $row['username'];
												  $user_password= $row['user_password'];
												  $user_firstname= $row['user_firstname'];
												  $user_lastname= $row['user_lastname'];
												  $user_email= $row['email'];
												  $user_role= $row['role'];
												  $user_registered_on= $row['user_registered_on'];
								?>	
                                <label for="cat-title">User ID</label>	
									<input class="form-control" type="text" readonly name="TheUserID" value="<?php  if(isset($user_id)){ echo $user_id;}?>"></input>
                                <label for="cat-title">User name</label>   
                                    <input class="form-control"  type="text" name="TheUserName" value="<?php  if(isset($username)){ echo $username;}?>"></input>
                                 <label for="cat-title">User Password</label>   
                                    <input class="form-control"  type="password" name="TheUserPassword" value="<?php  if(isset($user_password)){ echo $user_password;}?>" ></input>
                                 <label for="cat-title">User First Name</label>   
                                    <input class="form-control"  type="text" name="TheUserFirstName" value="<?php  if(isset($user_firstname)){ echo $user_firstname;}?>" ></input>
                                 <label for="cat-title">User Last Name</label>   
                                    <input class="form-control"  type="text" name="TheUserLastName" value="<?php  if(isset($user_lastname)){ echo $user_lastname;}?>" ></input>
                                 <label for="cat-title">User Email</label>   
                                    <input class="form-control"  type="email" name="TheUserEmail" value="<?php  if(isset($user_email)){ echo $user_email;}?>" ></input>
                                 <label for="cat-title">User Role</label>   
                                    <input class="form-control"  type="text" name="TheUserRole" value="<?php  if(isset($user_role)){ echo $user_role;}?>" ></input>   
                                 <label for="cat-title">User was registered on</label>   
                                    <input class="form-control"   type="date" name="TheUserRegistration" value="<?php  if(isset($user_registered_on)){ echo $user_registered_on;}?>" ></input>           
								<?php 	} 
											}?>
	                           </div>
                             <div class="form-group">
                             	<input class="btn btn-primary" type="submit" name="submitEditedUser" value="Edit User"></input>
                             </div>
                          </form>
       <?php  ?>  
                         </div>
                           <div class="col-xs-6">    	 
                       		<table class="table table-bordered table-hover">
                            	<thead>
                                	<tr>
                                    	<th>User ID</th>
                                        <th>User Name</th>
                                        <th>User Password</th>
                                        <th>User First Name</th>
                                        <th>User Last Name</th>
                                        <th>User Email</th>
                                        <th>User Role</th>
                                        <th>User Registered On</th>
                                        <th>Delete</th>
                                        <th>Edit</th>
                                    </tr>
                                </thead>
                                <tbody>
                                	<tr>
                                       <?php 
									   //find all Admins
									   //re-factoring
										findAllUsers();
						 			 	?>   	
                                    </tr>
                                <?php
									  //Delete re-factoring
								    	deleteUser();
								?>
                                </tbody>
                            </table>   	 
                       </div>     
                    </div>
                </div>
                <!-- /.row -->

            </div>
            <!-- /.container-fluid -->

        </div>
        <!-- /#page-wrapper -->

    </div>
    <!-- /#wrapper -->
  <?php include "includes/footer.php" ?>
