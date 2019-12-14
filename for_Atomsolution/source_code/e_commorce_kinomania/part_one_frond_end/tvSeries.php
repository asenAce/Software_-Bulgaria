
	<?php
		include("includes/header.php");
		include("includes/navigation.php");
		
	?>
    <div class="wrapper">
    	<div class="container">
        	<div class="row">
            	<div class="col-lg-9 col-lg-push-3" >
                	<form role="search" method="post" class="visible-xs">
                    	<div class="form-group">
                        	<div class="input-group">
                            	<input type="search" class="form-control input-lg" placeholder="Search a movie">
                                <div class="input-group-btn">
                                	<button class="btn btn-default btn-lg" type="submit"><i class="glyphicon glyphicon-search"></i></button>
                                </div>
                            </div>
                        </div>
                    </form>
                    <h2>TV Series</h2>
                    <hr>
           <div class="row">
           <?php
   						if(isset($_GET['page'])){
							 $page=$_GET['page'];
						 } else {
							$page = ""; 
						 }
						 
						 if($page == "" || $page==1){
							 $page_1 = 0;
						 }else {
							$page_1 = ($page * 3) - 3; 
						 }
			   
			   			 $tvSeriesQueryCount="SELECT * FROM tv_series";
						 $findCoutTVSeriesMovies = $theConnection->executeTheQuery($tvSeriesQueryCount);	
						 $count= mysqli_num_rows($findCoutTVSeriesMovies);
						 $count = ceil($count / 6);
   
   
   
   			$sellectAllTVMovies = $theConnection->executeTheQuery("SELECT * FROM tv_series LIMIT $page_1,3");
			   					while($row=mysqli_fetch_assoc($sellectAllTVMovies)){
									$movie_title = $row['movie_title'];
									$movie_description	 = $row['movie_description'];
									$movie_movie_post_img = $row['movie_post_img'];
									$movie_id = $row['id'];
   
   
   
   			?>                           
                        	<div class="well clearfix">
                            	<div class="col-lg-3 text-center col-md-2">
                                  <a href="theTvSeries.php?p_id=<?php echo $movie_id; ?>">	
                                	<img class="img-thumbnail"  src="img/tv_series/<?php echo $movie_movie_post_img; ?>">
                                    	<p><?php echo $movie_title; ?></p>
                                   </a>      
                                </div>
                                <div class="col-lg-9 col-md-10">
                                	<p><?php echo $movie_description; ?></p>
                                </div>
                                <div class="col-lg-12">
                                	<a  href="theTvSeries.php?p_id=<?php echo $movie_id; ?>"class="btn btn-lg btn-warning pull-right">See More Info</a>
                                    <a href="#" class="btn btn-lg btn-warning pull-left">Buy Now</a>
                                </div>
                            </div>
       <?php
						       }
   ?>                                             
                        </div>
                        
                        <div class="margin-8 clear"></div>
                </div>
                
               <!--Left site min-menu-->
               <?php
			   		include("includes/leftSiteMinMenu.php");
			   ?>
            </div>
        </div>
    </div>
 <hr>
 <ul class="pager">
    	<?php
			for($i=1;$i<= $count;$i++){
				echo "<li><a href='tvSeries.php?page=$i'>$i</a></li>";
			}
			//for the selected page
			if($i == $page){
				echo "<li><a class='active_link' href='tvSeries.php?page=$i'>$i</a></li>";
			}else {
				echo "<li><a href='tvSeries.php?page=$i'>$i</a></li>";
			}
			
		?>
 </ul>   
	<?php 
		include("includes/footer.php");
	?>
</body>
</html>