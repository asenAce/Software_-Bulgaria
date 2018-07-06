
<?php 
	include "includes/header.php"; 
	include "includes/adminFunctions.php";
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
      <?php include "includes/navigation.php" ?>
        <div id="page-wrapper">
            <div class="container-fluid">

                <!-- Page Heading -->
                <div class="row">
                
                    <div class="col-lg-12">
                    	<h1 class="page-header">
                            Wellcome to Admin user:
                            <small>View All Photos</small>
                        </h1>
                   <!-- Table Posts -->     
                      <table class="table table-bordered table-hover">
                      	<thead>
                        	<tr>
                            	<th>ID</th>
                                <th>Title</th>
                                <th>Category Releted:</th>
                                <th>Image</th>
                                <th>Delete</th>
                                <th>Edit</th>
                            </tr>
                        </thead>
                        <tbody>
           <?php
		      $selectAllPhotos = $theConnection->executeTheQuery("SELECT * FROM photoalbum LIMIT $page_1,3");
			  $queryCount ="SELECT * FROM photoalbum";
			  $ThequeryCount= $theConnection->executeTheQuery($queryCount);
			  $countPhotos= mysqli_num_rows($ThequeryCount);
				  while($row=mysqli_fetch_assoc($selectAllPhotos)){
					  $photo_id= $row['photo_id'];
					  $photo_title= $row['photo_title'];
				      $photo_image= $row['photo_image'];
					  $photo_post_category= $row['photo_post_category'];
					  
					  
					  
					  echo "<tr>";
					    echo "<td>$photo_id</td>";
						echo "<td>$photo_title</td>";
						echo "<td>$photo_post_category</td>";
						echo "<td><img  src='../images/cars/$photo_image' alt='post_image' width='200' height='250'></td>";
						echo "<td><a href='view_all_photos.php?delete=$photo_id'>Delete</a></td>";
						echo "<td><a href='edit_photos.php?edit=$photo_id'>Edit</a></td>";
					  echo "</tr>"; 
				  }
		   ?>             
                      	<tr>
                        	<td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td> 
                        </tr>
                      </tbody>
                      </table>
                   <?php echo "<h3>Number of Photos is</h3>".$countPhotos; ?>   
        <?php
			//function delete post 
			     deletePhoto();
		?>              
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
					echo "<li><a href='view_all_photos.php?page=$i'>$i</a></li>";
				}
				if($i == $page){
					echo "<li><a class='active_link' href='view_all_photos.php?page=$i'>$i</a></li>";
				} else {
					echo "<li><a href='view_all_photos.php?page=$i'>$i</a></li>";
				}
			?>
    </ul>
    <!-- /#wrapper -->
  <?php include "includes/footer.php" ?>
