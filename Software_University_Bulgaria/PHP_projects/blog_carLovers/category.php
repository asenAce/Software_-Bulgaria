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
 <!-- Here The Sidebar -->
 <section>
 	<?php
		include "include/sidebar.php";
	?>
 </section>

 <!-- Page Content -->
 <?php
 	 // php pagination
	 //Here Paggination
 	if(isset($_GET['page'])){
		$page = $_GET['page'];
		
	} else {
		$page = "";	
	}
	
	if($page == "" || $page == 1){
		$page_1 = 0 ;	
	} else {
		$page_1 = ($page * 3) - 3;
	}
 
 	
	if(isset($_GET['theCategoryTitle'])){
		
		 $theCateTitle =$_GET['theCategoryTitle'];
			$selectSpecificPosts = $theConnection->executeTheQuery("SELECT * FROM posts WHERE post_category LIKE '%$theCateTitle%' LIMIT $page_1,3");
			// here will write the code for counting the rows in DB
			$countCategoryTitleQuery = "SELECT * FROM posts WHERE post_category LIKE '%%$theCateTitle%%'";
			$countCategoriesTitle = $theConnection->executeTheQuery($countCategoryTitleQuery);
				$count = mysqli_num_rows($countCategoriesTitle);
				$count = ceil($count / 6);	
			
			if(!$selectSpecificPosts){
				echo "Select Category Failed".mysqli_error($theConnection);
			}
			
			while($row=mysqli_fetch_assoc($selectSpecificPosts)){
				
				$post_id = $row['post_id'];
				$post_title = $row['post_title'];
				$post_author=$row['post_author'];
				$post_date = $row['post_date'];
				$post_image=$row['post_image'];
				$post_content=$row['post_content'];
	
		
 
 ?>
 
 	<div class="container">
    	<div class="row">
        	<div class="col-md-8">
            	<!-- First Blog Post -->
                <h2>
                <!-- Post Title-->	
                	<a style="text-decoration:none;" href="post.php?p_id=<?php echo $post_id; ?>"><?php echo $post_title; ?></a>
                </h2>
                <p class="lead">
                	by <a style="text-decoration:none;" href="post.php?p_id=<?php echo $post_id; ?>"><?php echo $post_author; ?></a>
                </p>
                <p><span class="glyphicon glyphicon-time" style="margin-right:5px;"></span><?php echo $post_date; ?></p>
                <img class="img-responsive" alt="carImageTitle" src="admin/image_cars/<?php echo $post_image; ?>">
                 <!-- Post Content-->	
                <p></p>
                <a class="btn btn-primary" href="post.php?p_id=<?php echo $post_id; ?>">Read More<span class="glyphicon glyphicon-chevron-right"></span></a>
             <?php
				}
			
		}		 
			 
		    ?>   
        
               </div>

            </div>
     
        </div>	
 <!-- Paggination -->
 	<ul class="pager">
    	<?php
			for($i=1;$i<=$count;$i++){
					// url with two parametars;
				echo "<li><a href='category.php?page=$i&theCategoryTitle=$theCateTitle'>$i</a></li>";
			}
			// php check are we on the last page and we have the last item in our db;
				if($i == $page){
					// url with two parametars;
					echo "<li><a class='active_link' href='category.php?page=$i&theCategoryTitle=$theCateTitle'>$i</a></li>";
				} else {
					// url with two parametars;
					echo "<li><a href='category.php?page=$i&theCategoryTitle=$theCateTitle'>$i</a></li>";
				}
			
		?>	
    </ul>		
 <!-- Footer -->
 <?php
	include "include/footer.php";
?>

