<?php
	require_once"include/db.php";
	  $theConnection = new Db("localhost","root","","cms_carlovers");
	ob_start();	
?>
<!-- Header -->
<?php
	include "include/header.php";
?>
 <!-- Navigation -->
<?php
	include "include/navigation.php";
?> 
 <!-- Page Content -->
 
 <div class="container">
    	<div class="row">
   <?php   
   	//TO DO Refactoring  
       if(isset($_POST['subComment'])){
		   $theComment = $_POST['leaveaComment'];
		   $theCommentTag = $_POST['commentTag'];
		   $comment_post_title =$_POST['comment_post_title'];
		   $theDate = date('d-m-y');
		   $comment_author = $_SESSION['user'];
		   
		   		$commentQuery = "INSERT INTO comments(comment_content,comment_tag,comment_post_title,comment_date,comment_author) ";
		   		$commentQuery .= "VALUES('$theComment','$theCommentTag','$comment_post_title',now(),'$comment_author')";
					$upLoadTheComment =$theConnection->executeTheQuery($commentQuery);
						$theConnection->confirmTheQuery($upLoadTheComment);
						
	   }
    ?>    
        	<div class="col-md-8">
            	<!-- Place the php blog of code here -->
    <?php
 	
 if(isset($_GET['p_id'])){
	 $p_id = $_GET['p_id'];

 	//Here Paggination
	$sqlSelectThePosts = "SELECT * FROM posts WHERE post_id ='$p_id' ";
	$selectThePost = $theConnection->executeTheQuery($sqlSelectThePosts);
		while($row = mysqli_fetch_assoc($selectThePost)){
			
			$post_id = $row['post_id'];
			$post_title = $row['post_title'];
			$post_author = $row['post_author'];
			$post_date = $row['post_date'];
			$post_image = $row['post_image'];
			$post_content = $row['post_content'];
			$post_video = $row['post_link'];
		
 
 ?>            
            	<!-- First Blog Post -->
                <h2>
                <!-- Post Title-->	
                	<a style="text-decoration:none;" href="#"><?php echo $post_title; ?></a>
                </h2>
                <p class="lead">
                	by <a style="text-decoration:none;" href="#"><?php echo $post_author; ?></a>
                </p>
                <p><span class="glyphicon glyphicon-time" style="margin-right:5px;"></span><?php echo $post_date; ?></p>
                <img class="img-responsive" alt="carImageTitle"  src="admin/image_cars/<?php echo $post_image; ?>">
                 <!-- Post Content-->	
                <p style="margin-top:20px;">
                	<?php echo $post_content; ?>
                </p>
                <a href="<?php echo $post_video; ?>" target="_blank">
                	<img src="images/gifs/imageeffects.gif" style="margin-bottom:15px;">
                </a>
 <!-- Comments Display-->
 <?php
 	$showallComments = $theConnection->executeTheQuery("SELECT * FROM comments WHERE comment_post_title LIKE '%$post_title%' ORDER BY comment_date DESC");
		$theConnection->confirmTheQuery($showallComments);
			
			while($row=mysqli_fetch_assoc($showallComments)){
				$comment_content = $row['comment_content'];
				$comment_date = $row['comment_date'];
				$comment_tag = $row['comment_tag'];
				$commentAuthor = $row['comment_author'];
				
				echo "<div class='well'>";
		
 ?>
 	<h3>Previous Comments:</h3>
    	<p class="info">
        	<?php echo $comment_content; ?>
        </p>
        <h4>Tags:<?php echo $comment_tag; ?></h4>
        <h4>By:<?php echo $commentAuthor;?></h4>
        <h4>Commented on:</h4><p><span style=" margin-right:7px;" class="glyphicon glyphicon-time"></span><?php echo $comment_date; ?></p>	
 <?php
 				echo "</div>";	
 	}
 ?>       	               
  </br>              
 <!-- Comment Form-->               
   <div class="well">
   	  <form role="form" method="post" action="" enctype="multipart/form-data">
      	 <h4>Leave a Comment:</h4>
           <div class="form-group">
           	 <label for="title">Post Title:</label>
               <input type="text" class="form-control" name="comment_post_title" value="<?php echo $post_title; ?>" readonly></input>
           </div>
           <div class="form-group">
           	  <label for="tag">Comment Tag:</label>
                 <input type="text" class="form-control" name="commentTag" placeholder="Please write our comment tag here"></input>
           </div>
           <div class="form-group">
           		<label for="the comment">Comment Content:</label>
                  <textarea class="form-control" rows="3" name="leaveaComment" placeholder="Please write our comment content here"></textarea> 	
           </div>
           	<!-- Validation for the User-->
      <?php
	  	  if($_SESSION['user']){
	  			echo "<button type='submit' class='btn btn-primary' name='subComment'>Submit</button>";
		  } else {
				echo "<button type='submit' class='btn btn-primary' name='goToregistration'>Go To Registration</button>";  
		  }
		  
		  	if(isset($_POST['goToregistration'])){
				header("Location:registration.php");
			}
	  ?>      	   
           
      </form>
   </div>             
             <?php
			 	}
//if statement close
 }
			 ?>
             
  <!-- col-md-8 -->                
       </div>
 <!-- Site Bar Search,Blog Categories,animated advert-->
 <section>
 	<?php
		include "include/sidebar.php";
	?>
 </section>
 <!--   end Sidebar-->       
   </div>
  <!-- Row end --> 	
</div>   
  <!-- Container end --> 	
 
 <!-- Footer -->
 
 <?php
	include "include/footer.php";
?>

