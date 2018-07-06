
<?php 
	include "includes/header.php"; 
	include "includes/adminFunctions.php";
	//Edit do not work
	
?>

    <div id="wrapper" style="margin-top:70px;">
      <?php include "includes/navigation.php" ?>
        <div id="page-wrapper">
            <div class="container-fluid">

                <!-- Page Heading -->
                <div class="row">
                    <div class="col-lg-12" >
                        <h1 class="page-header">
                            Wellcome to Admin user:
                            <small>View All Categories</small>
                        </h1>
                 <!-- The Category form -->       
                        <div class="col-xs-6" > 
                       		<table class="table table-bordered table-hover">
                            	<thead>
                                	<tr>
                                    	<th>ID</th>
                                        <th>Category Title</th>
                                        <th>Delete</th>
                                        <th>Edit</th>
                                    </tr>
                                </thead>
                                <tbody>
                                	<tr>
                                       <?php 
									   //find all categories
									   //re-factoring
										findAllCategories();
						 			 	?>   	
                                    </tr>
                                <?php
									  //Delete re-factoring
								    	deleteCategory();
								?>
                                </tbody>
                            </table>
                       </div>     
                    </div>
                </div>
                <!-- /.row -->

            </div>
            <!-- /.container-fluid -->

        </div>
        <!-- /#page-wrapper -->

    </div>
    <!-- /#wrapper -->
  <?php include "includes/footer.php" ?>
