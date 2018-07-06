
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
                            <small>View All Comments</small>
                        </h1>
                   <!-- Table Posts -->     
                      <table class="table table-bordered table-hover">
                      	<thead>
                        	<tr>
                            	<th>Comment ID</th>
                                <th>Comment Content</th>
                                <th>Commented on</th>
                                <th>Comment Post Title</th>
                                <th>Comment Tag</th>
                                <th>Delete</th>                   
                            </tr>
                        </thead>
                        <tbody>
           <?php
		      $selectAllUsers = $theConnection->executeTheQuery("SELECT * FROM comments");
			  $countComments= mysqli_num_rows($selectAllUsers);
				  while($row=mysqli_fetch_assoc($selectAllUsers)){
					  $comment_id= $row['comment_id'];
					  $comment_content= $row['comment_content'];
				      $comment_date= $row['comment_date'];
					  $comment_post_title= $row['comment_post_title'];
					  $comment_tag=$row['comment_tag'];	
					  
					  
					  
					  echo "<tr>";
					    echo "<td>$comment_id</td>";
						echo "<td>$comment_content</td>";
						echo "<td>$comment_date</td>";
						echo "<td>$comment_post_title</td>";
						echo "<td>$comment_tag</td>";
						echo "<td><a href='view_all_comments.php?delete=$comment_id'>Delete</a></td>";		
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
                        </tr>
                      </tbody>
                      </table>
                 <?php echo"Number of comments is ".$countComments; ?>     
        <?php
			//function delete post 
			     deleteComment();
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
