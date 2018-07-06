<?php
	require_once"include/db.php";
	$theConnection = new Db("localhost","root","","cms");
	
?>
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
         <div class="col-md-8" style="margin-top:5px;">
				<?php
                    /*
                        $selectAllCategories = $theConnection->executeTheQuery("SELECT * FROM categories");
                        $theConnection->displyCategories($selectAllCategories);	
						
						 $searchQuery = $theConnection->executeTheQuery("SELECT * FROM posts WHERE post_tags LIKE '%$searchWord%' ");
                    */
			if(isset($_GET['theCategoryTitle'])){
				$theCatTitle= $_GET['theCategoryTitle'];		
                    $selectSpecificPosts = $theConnection->executeTheQuery("SELECT * FROM posts WHERE post_category LIKE '%$theCatTitle%'");
				
					if(!$selectSpecificPosts){
						echo "Add Query Failed".mysqli_error($theConnection);
					} 
				
				
			
							
                      while($row=mysqli_fetch_assoc($selectSpecificPosts)) {
						  $post_id= $row['post_id'];
                          $post_title = $row['post_title'];
                          $post_author = $row['post_author'];
                          $post_date = $row['post_date'];
                          $post_image = $row['post_image'];
                          $post_content = $row['post_content']; 
                ?>
                            <h1 class="page-header" style="margin-bottom:15px;">
                                Page Heading
                                </br>
                                <small class="text-left" style="text-align:left;">Secondary Text</small>
                            </h1>
            
                            <!-- First Blog Post -->
                            <h2 >
                                <a href="posts.php?p_id=<?php echo $post_id;  ?>"><?php echo $post_title; ?></a>
                            </h2>
                            <p class="lead">
                                by <a href="index.php"><?php echo $post_author; ?></a>
                            </p>
                            <p><span class="glyphicon glyphicon-time"></span><?php echo $post_date; ?></p>
                            <hr>
                            <img class="img-responsive"  alt="cars" width="300" height="230" src="images/cars/<?php echo $post_image; ?>">
                            <hr>
                            <p><?php echo $post_content; ?></p>
                            <a class="btn btn-primary" href="#">Read More <span class="glyphicon glyphicon-chevron-right"></span></a>
            
                            <hr>
               <?php  }
						}	?>             
 </div>
        	<section>
                   <?php
			
						include "include/sidebar.php";
					?>
             </section>       
            <!-- Blog Entries Column -->
    
            <!-- Blog Sidebar Widgets Column -->
            
          

                    </div>
                    <!-- /.row -->
                </div>
          </div>

        </div>
        <!-- /.row -->


        <hr>


        <!-- Footer -->
        
  <?php
  
  	include "include/footer.php";
  
  ?>