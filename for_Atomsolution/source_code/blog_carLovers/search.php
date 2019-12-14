<!-- Header -->
<?php
	  require_once"include/db.php";
	  $theConnection = new Db("localhost","root","","cms_carlovers");

	include "include/header.php";
?>
 <!-- Navigation -->
<?php
	include "include/navigation.php";
?> 
<div class="container">
    <div class="col-md-8">
        	 <!-- php code go here -->
<?php
	//php pagination functionality Alghoritam for our pagination
	if(isset($_GET['page'])){
		$page = $_GET['page'];
		// for GET search
	} else {
		$page ="";	
	}
	
	if($page =="" || $page == 1){
		$page_1 = 0;
	} else {
		$page_1 = ($page * 3) - 3;	
	}
// if for the $_POST
	if(isset($_POST['submitSearch'])){
	
			$searchWord = $_POST['search'];
			
			$searchQuery = $theConnection->executeTheQuery("SELECT * FROM posts WHERE post_tags LIKE '%$searchWord%' LIMIT $page_1,3");
			//the count row 
			$countPostTagsQuery = "SELECT * FROM posts WHERE post_tags LIKE '%$searchWord%'";
			$countPostTags = $theConnection->executeTheQuery($countPostTagsQuery);
				$count = mysqli_num_rows($countPostTags);
				$count = ceil($count / 6);
			
				if(!$searchQuery){
					echo "Search Query Failed".mysqli_error($theConnection);
						die();
				}
				
				$count2 =mysqli_num_rows($searchQuery);
					if($count2 == 0){
						echo "<h1>No Results Found</h1>";
						die();
					} else {
						while($row=mysqli_fetch_assoc($searchQuery)){
							$postid = $row['post_id'];
							$post_title = $row['post_title'];
							$post_author = $row['post_author'];
							$post_date = $row['post_date'];
							$post_image=$row['post_image'];

?>           
             	<h2><a href="post.php?p_id=<?php echo $postid; ?>" style="text-decoration:none;"><?php echo $post_title; ?></a></h2>
                <p class="lead" >
                	by<a style=" margin-left:4px; text-decoration:none;" href="post.php?p_id=<?php echo $postid; ?>"><?php echo $post_author; ?></a>
                </p>
                <p>
                	<span class="glyphicon glyphicon-time" style="margin-right:4px;"></span><?php echo $post_date; ?>
                </p>
                <img class="img-responsive" alt="cars" src="admin/image_cars/<?php echo $post_image;?>">
                	<a style="margin-top:10px;" href="post.php?p_id=<?php echo $postid; ?>" class="btn btn-primary">Read More<span class="glyphicon glyphicon-chevron-right"></span></a>
   <?php
   						}
						
					}
		
	
   		}
   ?>
	
<?php
// IF FOR THE $_GET
if(isset($_GET['search'])){
			$searchWord = $_GET['search'];
			
			$searchQuery = $theConnection->executeTheQuery("SELECT * FROM posts WHERE post_tags LIKE '%$searchWord%' LIMIT $page_1,3");
			//the count row 
			$countPostTagsQuery = "SELECT * FROM posts WHERE post_tags LIKE '%$searchWord%'";
			$countPostTags = $theConnection->executeTheQuery($countPostTagsQuery);
				$count = mysqli_num_rows($countPostTags);
				$count = ceil($count / 6);
			
				if(!$searchQuery){
					echo "Search Query Failed".mysqli_error($theConnection);
						die();
				}
				
				$count2 =mysqli_num_rows($searchQuery);
					if($count2 == 0){
						echo "<h1>No Results Found</h1>";
						die();
					} else {
						while($row=mysqli_fetch_assoc($searchQuery)){
							$postid = $row['post_id'];
							$post_title = $row['post_title'];
							$post_author = $row['post_author'];
							$post_date = $row['post_date'];
							$post_image=$row['post_image'];

?>           
             	<h2><a href="#"><?php echo $post_title; ?></a></h2>
                <p class="lead" >
                	by<a style=" margin-left:4px;" href="#"><?php echo $post_author; ?></a>
                </p>
                <p>
                	<span class="glyphicon glyphicon-time" style="margin-right:4px;"></span><?php echo $post_date; ?>
                </p>
                <img class="img-responsive" alt="cars" src="admin/image_cars/<?php echo $post_image;?>">
                	<a style="margin-top:10px;" href="#" class="btn btn-primary">Read More<span class="glyphicon glyphicon-chevron-right"></span></a>
   <?php
   						}
						
					}
		
	
   		}
   ?>
	 		
</div>   
     <section style="margin-top:20px;">
            <?php
                include "include/sidebar.php";
            ?>
     </section>       
</div>
	<ul class="pager">
    	<?php
			for($i=1;$i<=$count;$i++){
				echo "<li><a href='search.php?page=$i&search=$searchWord'>$i</a></li>";
			}
			
			//check for the last page
			if($i == $page){
				echo "<li><a class='active_link' href='search.php?page=$i&search=$searchWord'>$i</a></li>";
			} else {
				echo "<li><a  href='search.php?page=$i&search=$searchWord'>$i</a></li>";		
			}
		?>
    </ul>    
<?php
	include "include/footer.php";
?>



