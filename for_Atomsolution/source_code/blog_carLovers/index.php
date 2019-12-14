<?php
	require_once"include/db.php";
	  $theConnection = new Db("localhost","root","","cms_carlovers");
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
        	<div class="col-md-8">
            	<!-- Place the php blog of code here -->
    <?php
 	if(isset($_GET['page'])){
		$page = $_GET['page'];
		
	} else {
		$page ="";	
	}
	
	if($page == "" || $page == 1){
		$page_1 = 0;
	} else {
		$page_1 = ($page * 3) - 3;	
	}
 
 
 	
 	$postQueryCount = "SELECT * FROM posts";
	$findCountPosts =$theConnection->executeTheQuery($postQueryCount);
		$count = mysqli_num_rows($findCountPosts);
		// with 6 display the exact numbers of pages 
		$count = ceil($count / 6); 
 
 	//Here Paggination
	$sqlSelectAllPosts = "SELECT * FROM posts LIMIT  $page_1,3";
	$selectAllPosts = $theConnection->executeTheQuery($sqlSelectAllPosts);
		while($row = mysqli_fetch_assoc($selectAllPosts)){
			
			$post_id = $row['post_id'];
			$post_title = $row['post_title'];
			$post_author = $row['post_author'];
			$post_date = $row['post_date'];
			$post_image = $row['post_image'];
			$post_content = $row['post_content'];
		
 
 ?>            
            	<!-- First Blog Post -->
                <h2>
                <!-- Post Title-->	
                	<a style="text-decoration:none;" href="post.php?p_id=<?php echo $post_id; ?>"><?php echo $post_title; ?></a>
                </h2>
                <p class="lead">
                	by <a style="text-decoration:none;" href="post.php?p_id=<?php echo $post_id; ?>"><?php echo $post_author; ?></a>
                </p>
                <p><span class="glyphicon glyphicon-time" style="margin-right:5px;"></span><?php echo $post_date; ?></p>
                <img class="img-responsive" alt="carImageTitle"  src="admin/image_cars/<?php echo $post_image; ?>">
                 <!-- Post Content-->	
                <p></p>
                <a class="btn btn-primary" href="post.php?p_id=<?php echo $post_id; ?>">Read More<span class="glyphicon glyphicon-chevron-right"></span></a>
             <?php
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
 <ul class="pager">
 	<?php
 		for($i=1;$i<=$count;$i++){
			echo "<li><a  href='index.php?page=$i'>$i</a></li>";
		}
		// last page !!
		if($i == $page){
			echo "<li><a class='active_link' href='index.php?page=$i'>$i</a></li>";
		} else {
			echo "<li><a  href='index.php?page=$i'>$i</a></li>";
		}
		
	?>
 </ul>
 <?php
	include "include/footer.php";
?>

