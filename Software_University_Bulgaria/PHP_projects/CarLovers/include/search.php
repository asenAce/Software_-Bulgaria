<?php
	require_once"db.php";
	$theConnection = new Db("localhost","root","","cms");
	
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
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

<link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css">
<link href="../css/blog-home.css" rel="stylesheet" type="text/css">
<script src="../js/bootstrap.min.js"></script>
</head>
<body>
    <!-- Navigation -->
  <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
    <div class="container">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="../index.php">Home</a>
        </div>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            <ul class="nav navbar-nav">
		<?php
			$selectAllCategories = $theConnection->executeTheQuery("SELECT * FROM categories");
			$theConnection->displyCategories($selectAllCategories);	
					
		?>			
               <li><a href="admin">Admin</a></li>
            </ul>
        </div>
        <!-- /.navbar-collapse -->
    </div>
    <!-- /.container -->
  </nav>
    <!-- Page Content -->
    <div class="container">
        <div class="row">
    <!-- Side Bar -->
    <section class="pull-right" style="right:auto;">
            <!-- Blog Categories Well -->
            <div class="well">
                <h4><strong>Blog Categories</strong></h4>
                <div class="row">
                    <div class="col-lg-12">
                        <ul class="list-unstyled">
                            <?php 
                                $selectAllCategories = $theConnection->executeTheQuery("SELECT * FROM categories");
                                $theConnection->displyCategories($selectAllCategories);  
                            ?>                  
                        </ul>
                    </div>
                </div>
                <!-- /.row -->
            </div>
            <!-- Side Widget Well -->
        </div>
      </div>
        <!-- /.row -->  
        <hr>
  </section>       
            <!-- Blog Entries Column -->
            <div class="col-md-8">
 	<?php
		if(isset($_POST['submitSearch'])){
		     $searchWord = $_POST['search'];
		
		     $searchQuery = $theConnection->executeTheQuery("SELECT * FROM posts WHERE post_tags LIKE '%$searchWord%' ");
			   if(!$searchQuery){
				   
				   echo "Search Query Failed ".mysqli_error($theConnection);
				   die();
			   }
			   $count = mysqli_num_rows($searchQuery);
			   
			   if($count == 0){
			      echo "<h1>No Results</h1>";
				  die();
			   }else{
					   while($row=mysqli_fetch_assoc($searchQuery)) {
						  $post_title = $row['post_title'];
						  $post_author = $row['post_author'];
						  $post_date = $row['post_date'];
						  $post_image = $row['post_image'];
						  $post_content = $row['post_content']; 
					   }
			  }
	   }
	?>
                <h1 class="page-header">
                    Page Heading
                    </br>
                    <small class="text-left" style="text-align:left;">Secondary Text</small>
                </h1>
                <!-- First Blog Post -->
                <h2 >
                    <a href="#"><?php echo $post_title; ?></a>
                </h2>
                <p class="lead">
                    by <a href="../index.php"><?php echo $post_author; ?></a>
                </p>
                <p><span class="glyphicon glyphicon-time"></span><?php echo $post_date; ?></p>
                <hr>
                <img class="img-responsive"  alt="cars" width="300" height="230" src="../images/cars/<?php echo $post_image; ?>">
                <hr>
                <p><?php echo $post_content; ?></p>
                <a class="btn btn-primary" href="#">Read More <span class="glyphicon glyphicon-chevron-right"></span></a>
                <hr>
            </div>
            <!-- Blog Sidebar Widgets Column -->
          </div>
            <!-- /.row -->
        </div>         
     </div>
   </div>
             <!-- /.row -->
    <hr>
             <!-- Footer -->
   <footer>
       <div class="row">
          <div class="col-lg-12">
               <p> &copy; CMS Blog 2017 aceAsen</p>
          </div>
             <!-- /.col-lg-12 -->
       </div>
             <!-- /.row -->
   </footer>
    </div>
		      <!-- /.container -->
    		  <!-- jQuery -->
    <script src="js/jquery.js"></script>
    		   <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>