
<?php 
	include "include/headerPhoto.php"; 
	
	ob_start();
	
				  
	
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
                            <small>Blog Selected Images</small>
                        </h1>
                   <!-- Table Posts -->     
                      <table class="table table-bordered table-hover">
                      	<thead>
                        	<tr>
                                <th>Image<a href="showPhotos.php"><span class="glyphicon-step-backward">Back</span></a></th>
                            </tr>
                        </thead>
                        <tbody>
                        
           <?php
		   
		   if(isset($_GET['selectedImage'])){
			      $thePhotoId=$_GET['selectedImage'];

				  $selectThePhoto = $theConnection->executeTheQuery("SELECT * FROM photoalbum WHERE photo_id ='$thePhotoId'");
				  
				  while($row=mysqli_fetch_assoc($selectThePhoto)){
				      $photo_image= $row['photo_image'];
	  
					  echo "<tr>";
						echo "<td><img  src='images/cars/$photo_image' alt='post_image' width='400' height='350'></td>";
					  echo "</tr>"; 
				  }
				  
			  
		   
		  }  
		   
		   
		      
		   ?>             
                      	<tr>
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
    
    <!-- /#wrapper -->
  <?php include "include/footerPhoto.php" ?>
