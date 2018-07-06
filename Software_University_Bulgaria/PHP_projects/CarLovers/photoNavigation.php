<?php
	require_once"include/db.php";
	$theConnection = new Db("localhost","root","","cms");

    

?>
        <!-- Navigation -->
        <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="index.php">Cars Lovers Photo Album</a>
            </div>
            <!-- Top Menu Items -->
            <ul class="nav navbar-right top-nav">
              <li><a href="index.php">Home</a></li>
                
            </ul>
            <!-- Sidebar Menu Items - These collapse to the responsive navigation menu on small screens -->
            <div class="collapse navbar-collapse navbar-ex1-collapse">
<ul class="nav navbar-nav side-nav">              
<li>
 <a href="javascript:;" data-toggle="collapse" data-target="#carstCategories"><i class="fa fa-fw fa-arrows-v"></i> Cars Categories <i class="fa fa-fw fa-caret-down"></i></a>
                      <ul id="carstCategories" class="collapse">
                        <li>
                 <?php
				 	//show all categories
					$queryCarsCategories="SELECT * FROM categories";
					$showCarsCategories=$theConnection->executeTheQuery($queryCarsCategories);
						if(!$showCarsCategories){
							echo"show cat Failed".mysqli_error($theConnection);
						} else {
							while($row=mysqli_fetch_assoc($showCarsCategories)){
								 $theCategory=$row['cat_title'];
							
								 echo "<a href='showPhotos.php?theCategoryIs=$theCategory'>$theCategory</a>"; 
							}
							
						}
				 
				 ?>       
                          
                        </li>
                      </ul>
                    </li>
                    <li>
  
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </nav>
