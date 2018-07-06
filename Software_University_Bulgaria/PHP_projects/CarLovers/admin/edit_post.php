
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
                            <small>Edit Post</small>
                        </h1>
                   <!-- Table Posts -->     
 <?php
   //for dispy
 	if(isset($_GET['edit'])){
		 $editID=$_GET['edit'];
		 
		  $selectPostbyId = $theConnection->executeTheQuery("SELECT * FROM posts WHERE post_id='$editID'");
		  	confirmTheQuery($selectPostbyId);
				  while($row=mysqli_fetch_assoc($selectPostbyId)){
					  $post_id= $row['post_id'];
					  $post_author= $row['post_author'];
				      $posty_title= $row['post_title'];
					  $post_category_id= $row['post_category_id'];
					  $post_status= $row['post_status'];
		              $post_image= $row['post_image'];
					  $post_tags= $row['post_tags'];
					  $post_comment_count= $row['post_comment_count'];
					  $post_content= $row['post_content'];
					  $post_date= $row['post_date'];			
				
				}
				
	}
				// Function Edit Post
				editPost();	
	
 ?>                  
                       <form action="edit_post.php" method="post" enctype="multipart/form-data">
                       	<div class="form-group">
                               <label for="title">Post ID</label>
                                <input value="<?php echo $post_id;  ?>" type="text" class="form-control" name="post_id" readonly></input>
                             </div>
                             <div class="form-group">
                               <label for="title">Post Title</label>
                                <input value="<?php echo $posty_title;  ?>" type="text" class="form-control" name="title"></input>
                             </div>
							    <div class="form-group">
                                    <label for="post_category">Post Category</label>
                                    <select name="post_category" id="">
                                        <?php
											$theCategory = $theConnection->executeTheQuery("SELECT * FROM categories ");
											  while($row=mysqli_fetch_assoc($theCategory)){
												  $category_title= $row['cat_title'];
											
												  
												  echo "<option value=''>$category_title</option>";
											  }
										
										?>
                                    </select>
							    </div>
                                <div class="form-group">
                                    <label for="title">Post Author</label>
                                    <input value="<?php echo $post_author;  ?>" type="text" class="form-control" name="author"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_status">Post Status</label>
                                    <input value="<?php echo $post_status;  ?>" type="text" class="form-control" name="post_status"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_image">Post Image</label>
                                    <img src="../images/<?php echo $post_image; ?>"  alt='post_image' width='200' height='250'>
                                    <input  type="file" class="form-control" name="image"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_tag">Post Tags</label>
                                    <input value="<?php echo $post_tags; ?>" type="text" class="form-control" name="post_tags"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_content">Post Contents</label>
                                    <textarea  class="form-control" name="post_content" id="" cols="30" rows="10"><?php echo $post_content; ?></textarea>
                                </div>
                                 <div class="form-group">
                                    <label for="post_date">Post Date</label>
                                    <input value="<?php echo $post_date; ?>" type="date" class="form-control" name="post_date"></input>
                                </div>
                                <div class="form-group">
                                    <input class="btn btn-primary" type="submit" name="edit_post" value="Edit Post"></input>
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
