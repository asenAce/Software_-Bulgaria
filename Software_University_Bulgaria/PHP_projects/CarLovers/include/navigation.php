<?php
	require_once"db.php";
	ob_start();
	
?>
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
            <a class="navbar-brand" href="https://www.auto.bg/pcgi/index.cgi">BG CARS LOVERS</a>
        </div>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
          <ul class="nav navbar-nav">
            <li><a href="index.php">Home</a></li>
            <li><a href="photoAlbum.php">Photo Album</a></li>
            
		<?php
			$selectAllCategories = $theConnection->executeTheQuery("SELECT * FROM categories");
			$theConnection->displyCategories($selectAllCategories);	
				
			//the User
					if($_SESSION['user']){
						$theUser=$_SESSION['user'];
						
						echo "<li><a href='logout.php'>Logout User</a></li>";
						echo "<li><a href='#'>Wellcome $theUser</a></li>";
					} else {
						if(!$_SESSION['admin_username']){
						  echo "<li><a href='loginUser.php'>Login User</a></li>";	
						  echo "<li><a href='registerUser.php'>Please registared here</a></li>";
						}
					}
					
				
				
			//the Admin
			   		if($_SESSION['admin_username']){
						$theAdmin = $_SESSION['admin_username'];
						echo"<li><a href='admin/index.php'>Admin</a></li>";
						echo"<li><a href='logout.php'>Logout Admin</a></li>";
						echo"<li><a style='text-align:right; href='#' >Wellcome $theAdmin</a></li>";
					} else {
						if(!$_SESSION['user']){
						 	echo"<li><a href='login.php'>Login Admin</a></li>";	
						}
					}
				
		?>	   
           
            </ul>
        </div>
        <!-- /.navbar-collapse -->
    </div>
    <!-- /.container -->
</nav>