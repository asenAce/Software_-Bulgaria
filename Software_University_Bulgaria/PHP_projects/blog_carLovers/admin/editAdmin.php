<?php
	include "include/header.php";
	include "include/fumctionsAdmin.php";
	ob_start();

?>

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
                    	<small>Edit the Admin</small>
                    </h1>
<?php
	editAdmin();
 ?>             
 <?php
 		if(isset($_GET['edit'])){
			$theAdmin_ID = $_GET['edit'];
			
			$theEditAdmin = $theConnection->executeTheQuery("SELECT * FROM admin WHERE admin_id='$theAdmin_ID'");
				while($row=mysqli_fetch_assoc($theEditAdmin)){
					$theadminid=$row['admin_id'];
					$theAdmin_username=$row['admin_username'];
					$theAdmin_password = $row['admin_password'];
					
		
 ?>      
             <!-- Form -->
             <form  action="" method="post" enctype="multipart/form-data">
             	<div class="form-group">
                	<label for="title">Admin ID</label>
                    <input type="text" class="form-control" name="adminid" value="<?php echo $theadminid; ?>" readonly ></input>	
                </div> 
             	<div class="form-group">
                	<label for="title">Admin Username</label>
                    <input type="text" class="form-control" name="admin_username" value="<?php echo $theAdmin_username; ?>"></input>	
                </div> 
                <div class="form-group">
                	<label for="title">Admin Password</label>
                    <input type="text" class="form-control" name="admin_password" value="<?php echo $theAdmin_password; ?>"></input>	
                </div>     
                <div class="form-group">
                	<input class="btn btn-primary" type="submit" name="edit_admin" value="Edit This Admin"></input>
                </div>
             </form>  
 <?php
 			}
			
		}
 ?>            
                   
                </div>
  <?php
  		deleteAdmin();
  ?>              
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
 