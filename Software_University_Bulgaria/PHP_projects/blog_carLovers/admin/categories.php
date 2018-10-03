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
                    	<small>Categories Page</small>
                    </h1>
<?php
   
 ?>           
 				  <div class="col-xs-6">        
                     <!-- Form -->
                     <form action="" method="post">
                        <div class="form-group">
                            <label>Edit Category</label>
                      <?php
					  		if(isset($_GET['edit'])){
								$cat_id = $_GET['edit'];
								
								$editCategory = $theConnection->executeTheQuery("SELECT * FROM categories WHERE cat_id = '$cat_id'");
									while($row=mysqli_fetch_assoc($editCategory)){
										$category_title = $row['cat_title'];
										$category_id = $row['cat_id'];
							
					  ?>      
                   <input class="form-group" type="text" name="cat_title" value="<?php if(isset($category_title)){ echo $category_title;} ?>"></input>
                      <?php
					  			}
							}
					  ?>
                      <?php
					  //Edit Process POST 
					  if(isset($_POST['edit'])){
						  $theCatTitle = $_POST['cat_title'];
						  	$editQuery = "UPDATE categories SET cat_title ='$theCatTitle' WHERE ";
							$editQuery .="cat_id ='$cat_id'";
						  	$editTheSelectedCategory=$theConnection->executeTheQuery($editQuery);
						  		if(!$editTheSelectedCategory){
									die("Edit Query Failed").mysqli_error($theConnection);
								} else {
									header("Location:categories.php");	
								}
					  }
					  
					  
					  ?>      
                        </div>	
                        <div class="form-group">
                            <input class="btn btn-primary" type="submit" name="edit" value="Edit Category"></input>
                        </div>
                     </form>
            	  </div>
                  <div class="col-xs-6">   
                   <!-- Display all categories in a table-->
                    <table class="table table-bordered table-hover"> 
                    	<thead>
                        	<tr>
                            	<th>Category ID</th>
                                <th>Category Title</th>
                                <th>Edit</th>
                                <th>Delete</th>
                            </tr>
                        </thead>
                        <tbody>
                        	<tr>
                            	<?php
									displayCategories();
								?>
                            </tr>
                                <?php
									deleteCategory();		
								?>
                            </tbody>
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
<?php
	include "include/footer.php";

?> 