<?php
	include "include/header.php";
	include "include/fumctionsAdmin.php";

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
                    	<small>Create new Admin</small>
                    </h1>
<?php
     addAdmin();
 ?>                   
             <!-- Form -->
             <form  action="" method="post" enctype="multipart/form-data">
             	<div class="form-group">
                	<label for="title">Admin Username</label>
                    <input type="text" class="form-control" name="admin_username"></input>	
                </div> 
                <div class="form-group">
                	<label for="title">Admin Password</label>
                    <input type="password" class="form-control" name="admin_password"></input>	
                </div>     
                <div class="form-group">
                	<input class="btn btn-primary" type="submit" name="create_admin" value="Create The Admin"></input>
                </div>
             </form>  
                   
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
 