
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
                            <small>Posts</small>
                        </h1>
                   <!-- Table Posts -->     
 <?php
 				   // Craete Posts Function
					createPosts();
 
 ?>                  
                       <form action="add_post.php" method="post" enctype="multipart/form-data">
                                <div class="form-group">
                                    <label for="title">Post Title</label>
                                    <input type="text" class="form-control" name="title"></input>
                                </div>
 							    <div class="form-group">
                                    <label for="post_category">Available Post Categories</label>
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
                                    <label for="title">Write the Category</label>
                                    <input type="text" class="form-control" name="theCategory" value="please write a category from the list"></input>
                                </div>
                                <div class="form-group">
                                    <label for="title">Post Author</label>
                                    <input type="text" class="form-control" name="author"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_status">Post Status</label>
                                    <input type="text" class="form-control" name="post_status"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_image">Post Image</label>
                                    <input type="file" class="form-control" name="image"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_tag">Post Tags</label>
                                    <input type="text" class="form-control" name="post_tag"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_content">Post Contents</label>
                                    <textarea class="form-control" name="post_content" id="" cols="30" rows="10"></textarea>
                                </div>
                                 <div class="form-group">
                                    <label for="post_date">Post Date</label>
                                    <input type="date" class="form-control" name="post_date"></input>
                                </div>
                                <div class="form-group">
                                    <input class="btn btn-primary" type="submit" name="create_post" value="Publish Post"></input>
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
