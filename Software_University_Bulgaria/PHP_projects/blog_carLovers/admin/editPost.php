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
                    	<small>Edit The Post</small>
                    </h1>
<?php
    // disply the edit post selected
	if(isset($_GET['edit'])){
		$editID = $_GET['edit'];
		
		$selectPostbyID=$theConnection->executeTheQuery("SELECT * FROM posts WHERE post_id = '$editID'");
			// refactoring attestation
			if(!$selectPostbyID){
				echo "SELECT post by ID Failed".mysqli_error($theConnection);
			} else {
					
				while($row=mysqli_fetch_assoc($selectPostbyID)){
					
					$post_id = $row['post_id'];
					$post_title = $row['post_title'];
					$post_author = $row['post_author'];
					$post_category_id = $row['post_category_id'];
					$post_category = $row['post_category'];
					$post_status=$row['post_status'];
					$post_image = $row['post_image'];
					$post_tags = $row['post_tags'];
					$post_comment_count = $row['post_comment_count'];
					$post_content = $row['post_content'];
					$post_date = $row['post_date'];
					$post_link = $row['post_link'];
				}
			}
		
	}
	
	
 ?>           
 <?php
 	
 	editPost();
 ?>        
             <!-- Form -->
             <form  action="editPost.php" method="post" enctype="multipart/form-data">
             	<div class="form-group">
                	<label for="title">Post ID</label>
                    <input type="text" class="form-control" value="<?php echo $post_id; ?>" name="post_id" readonly></input>	
                </div>
             	<div class="form-group">
                	<label for="title">Post Title</label>
                    <input type="text" class="form-control" value="<?php echo $post_title; ?>" name="title"></input>	
                </div>
                <div class="form-group">
                	<label for="post_categories">Available Post Categories</label>
                    <select name="post_category">
                    	<?php
							$theCategory = $theConnection->executeTheQuery("SELECT * FROM categories ");
								while($row=mysqli_fetch_assoc($theCategory)){
									$category_title = $row['cat_title'];
									
									echo "<option value=''>$category_title</option>";
								}
						?>
                    </select>
                </div>
                <div class="form-group">
                	<label for="title">Write the Category</label>
                    <input type="text" class="form-control" name="category" value="please write existing category"></input>
                </div>
                <div class="form-group">
                	<label for="title">Post Author</label>
                    <input type="text" class="form-control" value="<?php echo $post_author; ?>" name="author"></input>	
                </div>            
                <div class="form-group">
                	<label for="post_status">Post Status</label>
                    <input type="text" class="form-control" value="<?php echo $post_status; ?>" name="post_status"></input>	
                </div>
                <div class="form-group">
                	<label for="post_image">Post Image</label>
                    <img src="image_cars/<?php echo $post_image; ?>" alt="thePostImagebyId" width="200" height="250">
                    <input type="file" class="form-control" name="image"></input>	
                </div>
                <div class="form-group">
                	<label for="post_tag">Post Tag</label>
                    <input type="text" class="form-control" value="<?php echo $post_tags; ?>" name="post_tag"></input>	
                </div>
                <div class="form-group">
                	<label for="post_content">Post Content</label>
                    <textarea type="text" class="form-control" name="post_content" cols="30" rows="10">
                    	<?php
							echo $post_content;
						?>
                    </textarea>	
                </div>
                <div class="form-group">
                	<label for="post_date">Post Date</label>
                    <input type="date" class="form-control" value="<?php echo $post_date; ?>" name="post_date"></input>	
                </div>
                <div class="form-group">
                	<label for="post_link">Post Link</label>
                    <input type="text" class="form-control" value="<?php echo $post_link; ?>" name="post_link"></input>	
                </div>
                <div class="form-group">
                	<input class="btn btn-primary" type="submit" name="edit_post" value="Edit the Post"></input>
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