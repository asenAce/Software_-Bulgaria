
<?php 
	include "includes/header.php"; 
	include "includes/adminFunctions.php";
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
                            <small>Edit Photos</small>
                        </h1>
                   <!-- Table Posts -->     
 <?php
 				   // Edit Photo Get
				   if(isset($_GET['edit'])){
					    $editPhotoID = $_GET['edit'];
						$editPhotoById=$theConnection->executeTheQuery("SELECT * FROM photoalbum WHERE photo_id='$editPhotoID'");
						confirmTheQuery($editPhotoById);
							while($row=mysqli_fetch_assoc($editPhotoById)){
								$photo_id= $row['photo_id'];
							    $photo_title= $row['photo_title'];
							    $photo_image= $row['photo_image'];
							    $photo_post_category= $row['photo_post_category'];
							}
						
					   
				   }
					
 				editPhoto();
 ?>                  
                       <form action="edit_photos.php" method="post" enctype="multipart/form-data">
                       			<div class="form-group">
                                    <label for="title">Photo ID</label>
                                    <input type="text" class="form-control" name="photoID" readonly value="<?php echo $photo_id; ?>"></input>
                                </div>
                                <div class="form-group">
                                    <label for="title">Photo Title</label>
                                    <input type="text" class="form-control" name="title" value="<?php echo $photo_title; ?>"></input>
                                </div>
 							    <div class="form-group">
                                    <label for="post_category">Available Photo-Post Categories</label>
                                    <select name="post_category" id="">
                                        <?php
											$theCategory = $theConnection->executeTheQuery("SELECT * FROM categories ");
											  while($row=mysqli_fetch_assoc($theCategory)){
												  $category_title= $row['cat_title'];
											
												  
												  echo "<option  value=''>$category_title</option>";
											  }
										
										
										?>
                                    </select>
							    </div>
                                <div class="form-group">
                                    <label for="title">Write the Photo-Category</label>
                                    <input type="text" class="form-control" name="theCategory" value="<?php echo $photo_post_category; ?>"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_image">Photo Image</label>
                                    <img   src='../images/cars/<?php echo $photo_image; ?>' alt='post_image' width='200' height='250'>
                                    <input type="file" class="form-control" name="image"></input>
                                </div>
                                <div class="form-group">
                                    <input class="btn btn-primary" type="submit" name="editPhoto" value="Edit Image"></input>
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
    <!-- /#wrapper -->
  <?php include "includes/footer.php" ?>
