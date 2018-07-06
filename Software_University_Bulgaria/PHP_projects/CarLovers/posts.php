<?php
	require_once"include/db.php";
	require_once"include/functions.php";
	$theConnection = new Db("localhost","root","","cms");
	ob_start();
	
   
?>
<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

<title>Cars Lovers Bootstrap Blog Template</title>

    <!-- Bootstrap Core CSS -->
    
    <!-- Custom CSS -->

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// 
    	<aside  class="pull-right well" style="width:800px">  
		
  		</aside> 
    
    -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

<link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
<link href="css/blog-home.css" rel="stylesheet" type="text/css">
<link href="css/adsBanner.css" rel="stylesheet" type="text/css">
<script src="/js/bootstrap.min.js"></script>
</head>
<body style="background-image: url(images/bluePrints/bluePrintFr.PNG); background-repeat:no-repeat; background-size:100%; background-size:cover; ">

    <!-- Navigation -->
	<?php	
		include "include/navigation.php";
		include "include/sidebar.php"; 
	?>
   	<!-- Side bar -->
      
    <!-- Page Content -->
<div class="container"> 
      <div class="row">
         <div class="col-md-8" style="margin-top:5px;">
				<?php
				  
						if(isset($_POST['subComment'])){
							$theComment = $_POST['leaveComment'];
							$theCommentTag = $_POST['commentTag'];
							$theDate = date('d-m-y');
							$comment_post_title=$_POST['comment_post_title'];
							//add
							
						
							$comment_author=$_SESSION['user'];
							
							$commentQuery  ="INSERT INTO comments(comment_content,comment_tag,comment_date,comment_post_title,comment_author) ";
							$commentQuery .="VALUES('$theComment','$theCommentTag',now(),'$comment_post_title','$comment_author')";	       			
							
							$upLoadTheComment = $theConnection->executeTheQuery($commentQuery);
							confirmTheQuery($upLoadTheComment);
						}
					
				
				// show  comment by ID     
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

                
              <div class="well">
                	<!-- Show all the comments    -->
                    <?php
					// $searchQuery = $theConnection->executeTheQuery("SELECT * FROM posts WHERE post_tags LIKE '%$searchWord%' ");
						$showAllComments = $theConnection->executeTheQuery("SELECT * FROM comments WHERE comment_post_title LIKE '%$post_title%' ORDER BY comment_date DESC");
						confirmTheQuery($showAllComments);
						
						while($row=mysqli_fetch_assoc($showAllComments)){
							$comment_content=$row['comment_content'];
							$comment_date = $row['comment_date'];
							$comment_tag = $row['comment_tag'];
							$comment_author=$row['comment_author'];
					
					?>
                    
                    <div class="glyphicon-comment">
                    	<h4>Previous Comment:</h4>
                            <p  type="text"  class="info"  >
                                <?php echo $comment_content; ?>
                            </p>
                             <h4>Tags:<?php echo $comment_tag ?></h4>  
                             <h4>By:<?php echo $comment_author ?></h4>
                        	 <h4 style="margin-bottom:5px;">Commented on:</h4><p><span class="glyphicon glyphicon-time"></span><?php echo $comment_date; ?></p>
                    </div>
              </div>      
                   <?php } ?> 
                   </br>
                   <div class="well">
                        <!-- Comments Form -->
                        <form  role="form" method="post" action=" " enctype="multipart/form-data" >
                           <h4>Leave a Comment:</h4>
                            <div class="form-group">
                                <label for="title">Post Title:</label>
                                <input type="text" class="form-control" name="comment_post_title" readonly value="<?php echo $post_title;  ?>" ></input>
                             </div>
                             <div class="form-group">
                                <label for="title">Comment Tag:</label>
                                <input type="text" class="form-control" name="commentTag"  placeholder="Please write your comment tag here" ></input>
                             </div>
                            <div class="form-group">
                                <label for="the comment">Comment Content:</label>
                                <textarea class="form-control" rows="3" name="leaveComment" placeholder="Please write your comment here"></textarea>
                            </div>
                          
                            <?php
                                    if($_SESSION['user']){
                                            echo "<button type='submit' class='btn btn-primary' name='subComment'>Submit</button>";
                                    } else {
                                            echo "<button type='submit' class='btn btn-primary' name='goToregister'>Go to Registration</button>";		
                                    }
                                    
                                    if(isset($_POST['goToregister'])){
                                        header("Location:registerUser.php");
                                    }
                            ?>	
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