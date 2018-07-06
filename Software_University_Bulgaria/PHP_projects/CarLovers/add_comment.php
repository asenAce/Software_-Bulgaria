<?php
	require_once"include/db.php";
	require_once"include/functions.php";
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
      	<?php
		
					if(isset($_POST['submitComment'])){
						$theComment = $_POST['submitComment'];
						
						echo $theComment;
								
					}
				
		 ?>	
		
		
         <div class="col-md-8" style="margin-top:5px;">
				<?php
                    /*
                        $selectAllCategories = $theConnection->executeTheQuery("SELECT * FROM categories");
                        $theConnection->displyCategories($selectAllCategories);	
                    */
			  if(isset($_GET['p_id'])){
				   $p_id=$_GET['p_id'];		
                    $selectAllPosts = $theConnection->executeTheQuery("SELECT * FROM posts WHERE post_id='$p_id'");
                      while($row=mysqli_fetch_assoc($selectAllPosts)) {
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
                                <a href="#"><?php echo $post_title; ?></a>
                            </h2>
                            <p class="lead">
                                by <a href="index.php"><?php echo $post_author; ?></a>
                            </p>
                            <p><span class="glyphicon glyphicon-time"></span><?php echo $post_date; ?></p>
                            <hr>
                            <img class="img-responsive"  alt="cars" width="300" height="230" src="images/cars/<?php echo $post_image; ?>">
                            <hr>
                            <p><?php echo $post_content; ?></p>
                            <!-- Cut beggining -->
                <!-- Blog Comments -->

                <!-- Comments Form -->
                <div class="well">
                    <h4>Leave a Comment:</h4>
                    <form  role="form" method="post" action="">
                       <div class="form-group">
                            <label for="title">Post Title</label>
                            <input type="text" class="form-control" name="comment_post_title" readonly value="<?php echo $post_title;  ?>" ></input>
                         </div>
                         <div class="form-group">
                            <label for="title">Comment Tag</label>
                            <input type="text" class="form-control" name="commentTag"   value="Please write a comment tag" ></input>
                         </div>
                        <div class="form-group">
                            <textarea class="form-control" rows="3" name="leaveComment"></textarea>
                        </div>
                        <button type="submit" class="btn btn-primary" name="submitComment">Submit</button>
                    </form>
                </div>
                <hr>
				
                <!-- Posted Comments -->

                <!-- Comment -->
                <div class="media">
                    <a class="pull-left" href="#">
                        <img class="media-object" src="http://placehold.it/64x64" alt="">
                    </a>
                    <div class="media-body">

                        <h4 class="media-heading">Start Bootstrap
                            <small>August 25, 2014 at 9:30 PM</small>
                        </h4>
                        Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
                    </div>
                </div>

                <!-- Comment -->
                <div class="media">
                    <a class="pull-left" href="#">
                        <img class="media-object" src="http://placehold.it/64x64" alt="">
                    </a>
                    <div class="media-body">
                        <h4 class="media-heading">Start Bootstrap
                            <small>August 25, 2014 at 9:30 PM</small>
                        </h4>
                        Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
                        <!-- Nested Comment -->
                        <div class="media">
                            <a class="pull-left" href="#">
                                <img class="media-object" src="http://placehold.it/64x64" alt="">
                            </a>
                            <div class="media-body">
                                <h4 class="media-heading">Nested Start Bootstrap
                                    <small>August 25, 2014 at 9:30 PM</small>
                                </h4>
                                Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
                            </div>
                        </div>
                        <!-- End Nested Comment -->
                    </div>
                </div>
<?php //cut here ?>           
                            <a class="btn btn-primary" href="#">Read More <span class="glyphicon glyphicon-chevron-right"></span></a>
            
                            <hr>
                            
               <?php  
				   	}
			  }
				 ?>  
               
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