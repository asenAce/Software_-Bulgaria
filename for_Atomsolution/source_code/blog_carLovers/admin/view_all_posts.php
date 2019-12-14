<?php
	include "include/header.php";
	include "include/fumctionsAdmin.php";
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
                    	<small>View All Posts</small>
                    </h1>
<?php
   
 ?>                   
             <!-- Table -->
    <table class="table table-bordered table-hover">
    	 <thead>
         	<tr>
            	<th>ID</th>
                <th>Title</th>
                <th>Author</th>
                <th>Category ID</th>
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
	
	$sqlCountAllPosts = "SELECT * FROM posts";
	$executeCount =$theConnection->executeTheQuery($sqlCountAllPosts);
	$countPosts = mysqli_num_rows($executeCount);
	
	
	$sqlViewAllPosts ="SELECT * FROM posts";
	$executeSqlPosts = $theConnection->executeTheQuery($sqlViewAllPosts);
	
		while($row = mysqli_fetch_assoc($executeSqlPosts)){
			
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
			
			
			echo "<tr>";
				echo "<td>$post_id</td>";
				echo "<td>$post_title</td>";
				echo "<td>$post_author</td>";
				echo "<td>$post_category_id</td>";
				echo "<td>$post_category</td>";
				echo "<td>$post_status</td>";
				echo "<td><img src='image_cars/$post_image' alt='thecarImage' width='230' height='250'></td>";
				echo "<td>$post_tags</td>";
				echo "<td>$post_comment_count</td>";
				echo "<td>$post_content</td>";
				echo "<td>$post_date</td>";
				echo "<td><a href='editPost.php?edit=$post_id'>Edit</a></td>";
				echo "<td><a href='view_all_posts.php?delete=$post_id'>Delete</a></td>";
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
<?php
	echo "<h3 class='info'>Number of posts are</h3>".$countPosts;		

?> 
<?php
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
<?php
	include "include/footer.php";

?> 