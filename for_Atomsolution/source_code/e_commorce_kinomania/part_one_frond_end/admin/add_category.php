
<?php 
	include "includes_admin/header_admin.php"; 
	include "includes_admin/admin_navigation.php";
	include "includes_admin/admin_functions.php";
?>

    <div id="wrapper" style="margin-top:70px;">
    
        <div id="page-wrapper">
            <div class="container-fluid">

                <!-- Page Heading -->
                <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">
                            Wellcome to Admin:
                            <small>Create a Category on the Navigation</small>
                        </h1>
                 <!-- The Category form -->       
                        <div class="col-xs-6">
                        <?php
							//function insert new Category;
							insertNewCategory();
						?>
                          <form action="" method="post">
                          	 <div class="form-group">
                                <label for="cat-title">Category Title</label>
                             	<input class="form-control" type="text" name="cat_title"></input>
                             </div>
                              <div class="form-group">
                                <label for="cat-title">Category Href</label>
                             	<input class="form-control" type="text" name="cat_href"></input>
                             </div>
                             <div class="form-group">
                             	<input class="btn btn-primary" type="submit" name="submit_category" value="Add Category"></input>
                             </div>
                          </form>
                          <form action="" method="post">
                          	 <div class="form-group">
                                <label for="cat-title">Edit Category</label>
                                <?php
								//Edit Process GET
								//Edit function
									/*if(isset($_GET['edit'])){
										$cat_id = $_GET['edit'];
										
										$editCategory = $theConnection->executeTheQuery("SELECT * FROM categories WHERE cat_id ='$cat_id' ");
											  while($row=mysqli_fetch_assoc($editCategory)){
												  $category_title= $row['cat_title'];
												  $category_id= $row['cat_id'];*/
								?>		
									<!--<input class="form-control" type="text" name="cat_title" value="<?php  /*if(isset($category_title)){ echo $category_title;}*/?>"></input>-->
								<?php 	
								
									/*} 
											}*/
								?>
                                            
                             <?php
							    //Edit Process POST no factoring on this
								
						/*if(isset($_POST['edit'])){
							   $theCatTitle =$_POST['cat_title'];
							   $EditTheSelectedCate=$theConnection->executeTheQuery("UPDATE categories SET cat_title ='$theCatTitle' WHERE cat_id ='$cat_id'"); 
								 if(!$EditTheSelectedCate){
									   die("Edit Query failed").mysqli_error($theConnection);
									} else {
									   header("Location:categories.php");
								    } 
						}*/
							  ?>              
	                           </div>
                             <div class="form-group">
                             	<input class="btn btn-primary" type="submit" name="edit" value="Edit Category"></input>
                             </div>
                          </form>
                         </div>
                       <div class="col-xs-6">    	 
                       		<table class="table table-bordered table-hover">
                            	<thead>
                                	<tr>
                                    	<th>ID</th>
                                        <th>Category Title</th>
                                        <th>Delete</th>
                                        <th>Edit</th>
                                    </tr>
                                </thead>
                                <tbody>
                                	<tr>
                                       <?php 
									   //find all categories
									   //re-factoring
										//findAllCategories();
						 			 	?>   	
                                    </tr>
                                <?php
									  //Delete re-factoring
								      //	deleteCategory();
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

