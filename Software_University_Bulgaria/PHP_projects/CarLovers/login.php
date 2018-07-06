<?php
	require_once"include/db.php";
	$theConnection = new Db("localhost","root","","cms");
	//session_start();
	include "include/header.php";

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
            <a class="navbar-brand" href="#">BG Cars Lovers</a>
        </div>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            <ul class="nav navbar-nav">
			
               <li><a href="index.php">Back</a></li>
            </ul>
        </div>
        <!-- /.navbar-collapse -->
    </div>
    <!-- /.container -->
</nav>

	<div class="container">
                  <h4 style="margin-top:140px;">Log In Form Admin</h4>             
                    <form  action="login.php" method="post">
                    		<label for="cat-title">Admin Username:</label>
                            <div class="form-group">
                                <input name="username" placeholder="username" type="text" class="form-control">
                             </div> 
                             <label for="cat-title">Admin Password:</label>
                             <div class="form-group">  
                                <input name="password" placeholder="password"  type="password" class="form-control">
                             </div>
                             <div class="form-group">   
                     		  <span class="input-group-btn">
                                    <button name="login" class=" btn btn-primary" type="submit" value="Log In" style="text-height:font-size:40px;">
                                       Log In
                                    </button>
                              </span>
                            </div> 
                    </form>
                    <?php
					//function login
						if(isset($_POST['login'])){
									
									$username= $_POST['username'];
									$password = $_POST['password'];
									
									
									$query = "SELECT * FROM admin";
									
						   			$loginAdmin=$theConnection->executeTheQuery($query);
									   if(!$loginAdmin){
										   echo "failed to log in".mysqli_error($theConnection);
									   }
				   
										while($row=mysqli_fetch_assoc($loginAdmin)){
											
											$admin_id = $row['admin_id'];
											$admin_username = $row['admin_username'];
											$admin_password = $row['admin_password'];

										if($admin_username == $username && $admin_password == $password){
											   
											   $_SESSION['admin_username'] = $admin_username;	
											   $_SESSION['admin_id'] = $admin_id;	
											   
											   
											   header("Location:admin/index.php"); 
											} else {
												echo "No such User";	
											}
							
							}
	
						}					
					?>
     </div>               
             
  <div style="margin-top:30%;">            
		<?php include "include/footer.php" ?>
   </div> 