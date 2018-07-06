
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
                            <small>View All Admins</small>
                        </h1>
                 <!-- The Category form -->       
                        <div class="col-xs-6" >
						 <form action="" method="post" style="width:100%; height:100%;">
                          	 <div class="form-group">
                                <label for="cat-title">Edit Admin</label>
                                <?php
								//Edit Process GET

									if(isset($_GET['edit'])){
										$adminID = $_GET['edit'];
										
										$editAdmin = $theConnection->executeTheQuery("SELECT * FROM admin WHERE admin_id ='$adminID' ");
											  while($row=mysqli_fetch_assoc($editAdmin)){
												  $TheadminID= $row['admin_id'];
												  $Theadmin_username= $row['admin_username'];
												  $Theadmin_password= $row['admin_password'];
								?>	
                                <label for="cat-title">Admin ID</label>	
									<input class="form-control" type="text" readonly name="TheadminID" value="<?php  if(isset($TheadminID)){ echo $TheadminID;}?>"></input>
                                <label for="cat-title">Admin User name</label>   
                                    <input class="form-control"  type="text" name="Theadmin_username" value="<?php  if(isset($Theadmin_username)){ echo $Theadmin_username;}?>"></input>
                                 <label for="cat-title">Admin Password</label>   
                                    <input class="form-control"  type="password" name="Theadmin_password" value="<?php  if(isset($Theadmin_password)){ echo $Theadmin_password;}?>" ></input>
								<?php 	} 
											}?>                           
                         </div>
                           <div class="col-xs-6" style="width:100%; height:100%;">    	 
                       		<table class="table table-bordered table-hover" >
                            	<thead>
                                	<tr>
                                    	<th>Admin ID</th>
                                        <th>Admin User Name</th>
                                        <th>Admin User Password</th>
                                        <th>Delete</th>
                                        <th>Edit</th>
                                    </tr>
                                </thead>
                                <tbody>
                                	<tr>
                                       <?php 
									   //find all Admins
									   //re-factoring
										findAllAdmins();
						 			 	?>   	
                                    </tr>
                                <?php
									  //Delete re-factoring
								    	deleteAdmin();
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
