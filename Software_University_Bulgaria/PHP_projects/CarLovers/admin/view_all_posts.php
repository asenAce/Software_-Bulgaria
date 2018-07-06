
<?php 
	include "includes/header.php"; 
	include "includes/adminFunctions.php";
	ob_start();
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
                            <small>View All Posts</small>
                        </h1>
                   <!-- Table Posts -->     
                      <table class="table table-bordered table-hover">
                      	<thead>
                        	<tr>
                            	<th>ID</th>
                                <th>Author</th>
                                <th>Title</th>
                                <th>Category ID:</th>
                                <th>Category</th>
                                <th>Status</th>
                                <th>Image</th>
                                <th>Tags</th>
                                <th>Comments</th>
                                <th>Content</th>
                                <th>Date</th>       
                                <th>Delete</th>
                                <th>Edit</th>
                            </tr>
                        </thead>
                        <tbody>
           <?php
		      $selectAllPosts = $theConnection->executeTheQuery("SELECT * FROM posts");
			  $countPosts= mysqli_num_rows($selectAllPosts);
				  while($row=mysqli_fetch_assoc($selectAllPosts)){
					  $post_id= $row['post_id'];
					  $post_author= $row['post_author'];
				      $post_title= $row['post_title'];
					  $post_category_id= $row['post_category_id'];
					  $post_category=$row['post_category'];	
					  $post_status= $row['post_status'];
		              $post_image= $row['post_image'];
					  $post_tags= $row['post_tags'];
					  $post_comment_count= $row['post_comment_count'];
					  $post_content= $row['post_content'];
					  $post_date= $row['post_date'];
					  
					  
					  echo "<tr>";
					    echo "<td>$post_id</td>";
						echo "<td>$post_author</td>";
						echo "<td>$post_title</td>";
						echo "<td>$post_category_id</td>";
						echo "<td>$post_category</td>";
						echo "<td>$post_status</td>";
						echo "<td><img  src='../images/cars/$post_image' alt='post_image' width='200' height='250'></td>";
						echo "<td>$post_tags</td>";
						echo "<td>$post_comment_count</td>";
						echo "<td>$post_content</td>";
						echo "<td>$post_date</td>";
						echo "<td><a href='view_all_posts.php?delete=$post_id'>Delete</a></td>";
						echo "<td><a href='edit_post.php?edit=$post_id'>Edit</a></td>";
					  echo "</tr>"; 
				  }
		   ?>             
                      	<tr>
                        	<td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                      </tbody>
                      </table>
                   <?php echo "<h3>Number of posts is</h3>".$countPosts; ?>   
        <?php
			//function delete post 
			     deletePost();
		?>              
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
