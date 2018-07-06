
<?php 
	include "includes/header.php"; 
	include "includes/adminFunctions.php";
	ob_start();
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
                            <small>View All Users</small>
                        </h1>
                   <!-- Table Posts -->     
                      <table class="table table-bordered table-hover">
                      	<thead>
                        	<tr>
                            	<th>ID User</th>
                                <th>User Name</th>
                                <th>User Password</th>
                                <th>User First Name</th>
                                <th>User Last Name</th>
                                <th>User email</th>
                                <th>User Role</th>
                                <th>User Registared on</th>
                                <th>Delete</th>
                            </tr>
                        </thead>
                        <tbody>
           <?php
		      $selectAllUsers = $theConnection->executeTheQuery("SELECT * FROM users");
			  $countUsers= mysqli_num_rows($selectAllUsers);
				  while($row=mysqli_fetch_assoc($selectAllUsers)){
					  $user_id= $row['user_id'];
					  $username= $row['username'];
				      $user_password= $row['user_password'];
					  $user_firstname= $row['user_firstname'];
					  $user_lastname=$row['user_lastname'];	
					  $user_email= $row['email'];
					  $user_role= $row['role'];
					  $user_registered_on= $row['user_registered_on'];
					  
					  
					  
					  echo "<tr>";
					    echo "<td>$user_id</td>";
						echo "<td>$username</td>";
						echo "<td>$user_password</td>";
						echo "<td>$user_firstname</td>";
						echo "<td>$user_lastname</td>";
						echo "<td>$user_email</td>";
						echo "<td>$user_role</td>";
						echo "<td>$user_registered_on</td>";
						echo "<td><a href='view_all_users.php?delete=$user_id'>Delete</a></td>";
					  echo "</tr>"; 
				  }
		   ?>             
                      	<tr>
                        	<td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td> 
                        </tr>
                      </tbody>
                      </table>
                      <?php echo "<h3>Number of users is</h3>".$countUsers; ?>
        <?php
			//function delete post 
			     deleteUser();
		?>              
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
