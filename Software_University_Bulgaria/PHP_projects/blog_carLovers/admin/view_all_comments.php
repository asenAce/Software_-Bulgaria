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
                    	<small>View All Comments</small>
                    </h1>                   
             <!-- Table -->
    <table class="table table-bordered table-hover">
    	 <thead>
         	<tr>
            	<th>Comment ID</th>
                <th>Comment Content</th>
                <th>Comment On</th>
                <th>Comment Post Title</th>
                <th>Comment Tag</th>
                <th>Delete</th>
            </tr>
         </thead>
         <tbody>
<?php
	// we count the rows in the comments db 
	$sqlCountAllComments = "SELECT * FROM comments";
	$executeCount =$theConnection->executeTheQuery($sqlCountAllComments);
	$countComments = mysqli_num_rows($executeCount);
	
	
	$sqlViewAllComments ="SELECT * FROM comments";
	$executeSqlComments = $theConnection->executeTheQuery($sqlViewAllComments);
	
		while($row = mysqli_fetch_assoc($executeSqlComments)){
			
			$comment_id = $row['comment_id'];
			$comment_content = $row['comment_content'];
			$comment_date = $row['comment_date'];
			$comment_post_title = $row['comment_post_title'];
			$comment_tag = $row['comment_tag'];
			
			
			
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
<?php
	echo "<h3 class='info'>Number of Comments are</h3>$countComments";		

?> 
<?php
	// fn delete comments
	deleteTheComment();
	
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