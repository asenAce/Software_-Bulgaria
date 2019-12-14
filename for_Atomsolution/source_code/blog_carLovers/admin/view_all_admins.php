<?php
	include "include/header.php";
	include "include/fumctionsAdmin.php"; // function.php
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
                    	<small>View All Admins</small>
                    </h1>                   
             <!-- Table -->
    <table class="table table-bordered table-hover">
    	 <thead>
         	<tr>
            	<th>ID</th>
                <th>Admin Username</th>
                <th>Admin Password</th>
                <th>Edit</th>
                <th>Delete</th>
            </tr>
         </thead>
         <tbody>         
         	<tr>
            	<?php
					displayAdmins();
				?>
            </tr>
         </tbody>        
    </table> 

    
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