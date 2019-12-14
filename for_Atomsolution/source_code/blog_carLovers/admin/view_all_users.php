<?php
	include "include/header.php";
	include "include/fumctionsAdmin.php";
	ob_start();

?>
<!-- delete it -->

<div id="wrapper" style="margin-top:70px;">
	    <!-- Navigation -->
   <?php
   	 include "include/navigation.php";	
   ?>     
	<div id="page-wrapper">
    	<div class="container-fluid">
        	<!-- Page Heading -->
             <div class="row">
             	<div class="col-lg-12">
                	<h1 class="page-header">Wellcome to Control Panel
                    	<small>View All Users</small>
                    </h1>                   
             <!-- Table -->
    <table class="table table-bordered table-hover">
    	 <thead>
         	<tr>
            	<th>User ID</th>
                <th>User Name</th>
                <th>User First Name</th>
                <th>User Last Name</th>
                <th>User Email</th>
                <th>Registrated On</th>
                <th>Delete</th>
            </tr>
         </thead>
         <tbody>
<?php
	// we count the rows in the users db 
	$sqlCountAllUserss = "SELECT * FROM users";
	$executeCount =$theConnection->executeTheQuery($sqlCountAllUserss);
	$countUsers = mysqli_num_rows($executeCount);
	
	
	$sqlViewAllUsers ="SELECT * FROM users";
	$executeSqlUsers = $theConnection->executeTheQuery($sqlViewAllUsers);
	
		while($row = mysqli_fetch_assoc($executeSqlUsers)){
			
			$user_id = $row['user_id'];
			$user_name = $row['user_name'];
			$user_firstname = $row['users_firstname'];
			$user_lastname = $row['user_lastname'];
			$user_email = $row['email'];
			$user_date = $row['user_registered_on'];
			
			
			
			echo "<tr>";
				echo "<td>$user_id</td>";
				echo "<td>$user_name</td>";
				echo "<td>$user_firstname</td>";
				echo "<td>$user_lastname</td>";
				echo "<td>$user_email</td>";
				echo "<td>$user_date</td>";
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
            </tr>
         </tbody>        
    </table> 
<?php
	echo "<h3 class='info'>Number of Comments are</h3>$countUsers";		

?> 
<?php
	// fn delete comments
	deleteTheUser();
	
?>     
         		</div>
             </div>
             <!-- /.row -->
        </div>
           <!-- /.container-fluid -->
    </div>
    	<!-- /#page-wrapper -->
</div>
<?php
	include "include/footer.php";

?> 