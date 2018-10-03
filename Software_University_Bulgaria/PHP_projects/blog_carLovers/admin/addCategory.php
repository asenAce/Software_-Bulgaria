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
                    	<small>Create new Category</small>
                    </h1>
<?php
    if(isset($_POST['create_category'])){
		
		$cat_title = $_POST['cat_title'];
		
			if($cat_title == "" || empty($cat_title)){
				echo "The field should not be empty!";
			} else {
				$insertIntoCategory = $theConnection->executeTheQuery("INSERT INTO categories(cat_title) VALUES('$cat_title')");
					if(!$insertIntoCategory){
						die('Query Insert Failed').mysqli_error($theConnection);
					}
			}
		
	}
	
 ?>                   
             <!-- Form -->
             <form  action="" method="post" enctype="multipart/form-data">
             	<div class="form-group">
                	<label for="title">Create Category</label>
                    <input type="text" class="form-control" name="cat_title"></input>	
                </div>     
                <div class="form-group">
                	<input class="btn btn-primary" type="submit" name="create_category" value="Create The Category"></input>
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