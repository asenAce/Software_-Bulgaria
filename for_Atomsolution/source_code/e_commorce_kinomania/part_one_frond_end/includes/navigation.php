<?php
	
	function displayCategories($procesedData){
					
				while($row=mysqli_fetch_assoc($procesedData)){
					
					$category_title = $row['cat_title'];
					$category_link = $row['cat_link'];
						$display="<li><a href='$category_link'>$category_title</a></li>";
						
						echo $display;
				}
			}
?>
<div class="container-fluid">
    	<div class="row">
        	<nav class="navbar navbar-inverse" role="navigation">
            	<div class="container">
                	<div class="navbar-header header">
                    	<div class="container">
                        	<div class="row">
                            	<div class="col-lg-12">
                                	<h1><a href="#">KinoMania<i style="font-size:60%; position:absolute; ">&reg;</i></a></h1>
                                    	<p>Buy Greatest Movies</p>
                                </div>
                            </div>
                        </div>
                        <button type="button" data-target="#navbarCollapse" data-toggle="collapse" class="navbar-toggle">
                        	<span class="sr-only">Toggle Nav</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>    
                    </div>
                    <div id="navbarCollapse" class="collapse navbar-collapse navbar-right">
                    	<ul class="nav nav-pills">
                        	<li class="active"><a href="index.php">Home</a></li>
                            <?php
								$selectAllCategories = $theConnection->executeTheQuery("SELECT * FROM categories");
								$theConnection->displayCategories($selectAllCategories);	
							?>
                          
                            
                            <?php
								if($_SESSION['admin_username']){
									
									echo "<li><a href='admin/index.php'>CMS</a></li>";
									echo "<li><a href='includes/logOut.php'>LogOut</a></li>";
								}
								
								if($_SESSION['user']) {
									
									echo "<li><a href='includes/logOut.php'>LogOut</a></li>";
								}
							?>
                            
                       <?php
					   		if($_SESSION['admin_username']){
									
									$adminName = $_SESSION['admin_username'];
								
								echo "<li><a href='#'>Wellcome $adminName</a></li>";
							}
							
							if($_SESSION['user']){
								
								   $userName = $_SESSION['user'];
								    
								   echo "<li><a href='#'>Wellcome $userName</a></li>";	
							}
							
					   ?>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
    </div>