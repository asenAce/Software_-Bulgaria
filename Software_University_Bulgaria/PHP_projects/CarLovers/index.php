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
      <div class="row ">
         <div class="col-md-8" style="margin-top:5px;" >
				<?php
					if(isset($_GET['page'])){
						$page=$_GET['page'];
						
					} else {
						$page="";	
					}
				
					if($page == "" || $page==1){
						$page_1=0;
					} else{
						$page_1= ($page * 3) - 3;	
					}
				
                     $postQueryCount="SELECT * FROM posts";
				     $findCoutPosts = $theConnection->executeTheQuery($postQueryCount);	
					 $count= mysqli_num_rows($findCoutPosts);
					 $count = ceil($count / 2);
					
                    $selectAllPosts = $theConnection->executeTheQuery("SELECT * FROM posts LIMIT $page_1,3");
                      while($row=mysqli_fetch_assoc($selectAllPosts)) {
						  $post_id=$row['post_id'];
                          $post_title = $row['post_title'];
                          $post_author = $row['post_author'];
                          $post_date = $row['post_date'];
                          $post_image = $row['post_image'];
                          $post_content = $row['post_content']; 
                ?>
                			
                            <h1 class="page-header" style="margin-bottom:15px;">
                                Page Heading
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
                            <img class="img-responsive"  alt="cars" width="300" height="230" src="images/cars/<?php echo $post_image; ?>">
                            <p><?php echo $post_content; ?></p>
                            <a class="btn btn-primary" href="#">Read More <span class="glyphicon glyphicon-chevron-right"></span></a>
            
                          
               <?php  } ?>             
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
		<ul class="pager">
        	<?php
				for($i=1;$i<= $count;$i++){
					echo "<li><a href='index.php?page=$i'>$i</a></li>";
				}
				if($i == $page){
					echo "<li><a class='active_link' href='index.php?page=$i'>$i</a></li>";
				} else {
					echo "<li><a href='index.php?page=$i'>$i</a></li>";
				}
			?>
        </ul>
        <!-- Footer -->
       
  <?php
  
  	include "include/footer.php";
  
  ?>