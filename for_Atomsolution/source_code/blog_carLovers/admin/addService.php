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
                    	<small>Create new Service</small>
                    </h1>
<?php
 
	addService();
 ?>                   
             <!-- Form -->
             <form  action="addService.php" method="post" enctype="multipart/form-data">
             	<div class="form-group">
                	<label for="title">Services Title</label>
                    <input type="text" class="form-control" name="title"></input>	
                </div>
                <div class="form-group">
                	<label for="title">Sub Service Title</label>
                    <input type="text" class="form-control" name="sub_service"></input>	
                </div>
                <div class="form-group">
                	<label for="title">Service Description</label>
                    <textarea type="text" class="form-control" name="service_description" value="please write service description"></textarea>
                </div>
                 <div class="form-group">
                	<label for="title">Sub Service Description</label>
                    <textarea type="text" class="form-control" name="sub_service_description" value="please write service description"></textarea>
                </div>       
                <div class="form-group">
                	<label for="service_image">Service Image</label>
                    <input type="file" class="form-control" name="main_menu_image"></input>	
                </div>
                <div class="form-group">
                	<label for="service_image">Sub Service Image</label>
                    <input type="file" class="form-control" name="sub_menu_image"></input>	
                </div>
                <div class="form-group">
                	<label for="title">Services key word</label>
                    <input type="text" class="form-control" name="service_key_word"></input>	
                </div>
                <div class="form-group">
                	<label for="title">Sub Services key word</label>
                    <input type="text" class="form-control" name="sub_service_key_word"></input>	
                </div>
                <div class="form-group">
                	<input class="btn btn-primary" type="submit" name="create_service" value="Publish Service"></input>
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