<link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css">
<?php
	require_once "db.php";
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
            	<a class="navbar-brand" href="https://www.auto.bg/pcgi/index.cgi" target="_blank">DamEngineering</a>
        </div>
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
        	<ul class="nav navbar-nav">
            	<li><a href="index.php">Home</a></li>
              
                <!-- Display All Categories -->
                <?php
					$queryDisplayCategories = "SELECT * FROM categories";
					$selectTheCategories = $theConnection->executeTheQuery($queryDisplayCategories);
				    $theConnection->displayCategories($selectTheCategories);
					// Validation for the User
						if($_SESSION['user']){
							
								$theUser = $_SESSION['user'];
									echo "<li><a href='logout.php'>Logout</a></li>";
									echo "<li><a style='text-align:right;margin-left:100px;' href='#'>Wellcome $theUser</a></li>";
						} else {
							if(!$_SESSION['admin']){
								echo "<li><a href='loginUser.php'>User Login</a></li>";
								echo "<li><a href='registration.php'>Registrate</a></li>";	
							}
						}
						
					// Validation for the Admin	
						if($_SESSION['admin']){
							$theAdmin = $_SESSION['admin'];
								
								echo "<li><a href='admin/index.php'>Control Panel</a></li>";
								echo "<li><a href='logout.php'>Logout</a></li>";
								echo "<li><a style='text-align:right;margin-left:100px;' href='#'>Wellcome $theAdmin</a></li>";
						} else {
							 if(!$_SESSION['user']){
								echo "<li><a href='loginAdmin.php'>Admin Login</a></li>";	
							 }
						}
					
				?>
               	<li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown">Хидроизолация<span class="caret"></span></a>
               			<ul class="dropdown-menu" role="menu">
                        	<li><a href="#" >Покриви</a></li>
                            <li><a href="#">Хидросъоръжения</a></li>
                            <li><a href="#">Основи на сгради</a></li>
                        </ul>
                 </li>	  
            </ul>
        </div>
    </div>
</nav>
