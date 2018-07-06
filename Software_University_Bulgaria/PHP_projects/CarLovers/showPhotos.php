
<?php 
	include "include/headerPhoto.php"; 
	
	ob_start();
	
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
	
?>

    <div id="wrapper" style="margin-top:70px;">
      <?php include "photoNavigation.php" ?>
        <div id="page-wrapper">
            <div class="container-fluid">

                <!-- Page Heading -->
                <div class="row">
                
                    <div class="col-lg-12">
                    	<h1 class="page-header">
                            Photo Album
                            <small>Blog Images</small>
                        </h1>
                   <!-- Table Posts -->     
                      <table class="table table-bordered table-hover">
                      	<thead>
                        	<tr>
                                <th>Title</th>
                                <th>Image</th>
                                <th>View the Image</th>
                            </tr>
                        </thead>
                        <tbody>
           <?php
		   	  	  $queryCount ="SELECT * FROM photoalbum";
				  $ThequeryCount= $theConnection->executeTheQuery($queryCount);
				  $countPhotos= mysqli_num_rows($ThequeryCount);	
		   
		   	//LIMIT $page_1,3
		   
		      if(isset($_GET['theCategoryIs'])){
				  $thePhotoCategory=$_GET['theCategoryIs'];
				  $selectAllPhotos = $theConnection->executeTheQuery("SELECT * FROM photoalbum WHERE photo_post_category LIKE '%$thePhotoCategory%' LIMIT 0,4");
				  
				  while($row=mysqli_fetch_assoc($selectAllPhotos)){
					 
					  $photo_id= $row['photo_id'];
					  $photo_title= $row['photo_title'];
				      $photo_image= $row['photo_image'];
					  
					  
					  
					  
					  echo "<tr>";
						echo "<td>$photo_title</td>";
						echo "<td><img  src='images/cars/$photo_image' alt='post_image' width='200' height='250'></td>";
						echo "<td><a href='selectedPhotos.php?selectedImage=$photo_id'>Select</a></td>";
					  echo "</tr>"; 
				  }
				  
			  }
		   
		   
		   
		   
		      
		   ?>             
                      	<tr>
                        	<td></td>
                            <td></td> 
                            <td></td>   
                        </tr>
                      </tbody>
                      </table>
                    </div>
                </div>
                <!-- /.row -->

            </div>
            <!-- /.container-fluid -->

        </div>
        <!-- /#page-wrapper -->
    </div>
    <ul class="pager">
        	<?php
				for($i=1;$i<= $countPhotos;$i++){
					echo "<li><a href='showPhotos.php?page=$i'>$i</a></li>";
				}
				if($i == $page){
					echo "<li><a class='active_link' href='showPhotos.php?page=$i'>$i</a></li>";
				} else {
					echo "<li><a href='showPhotos.php?page=$i'>$i</a></li>";
				}
			?>
    </ul>
    <!-- /#wrapper -->
    
 	 <?php include "include/footerPhoto.php" ?>

   
