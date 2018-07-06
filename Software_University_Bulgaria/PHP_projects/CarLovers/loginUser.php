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
    			
                  <h4 style="margin-top:140px; ">Log In Form User</h4>             
                    <form  action="" method="post" >
                    		<label for="cat-title">User Username:</label>
                            <div class="form-group">
                                <input name="username" placeholder="username" type="text" class="form-control">
                             </div> 
                             <label for="cat-title">User Password:</label>
                             <div class="form-group">  
                                <input name="password" placeholder="password"  type="password" class="form-control">
                             </div>
                             <div class="form-group">   
                     		  <span class="input-group-btn">
                                    <button name="loginUser" class=" btn btn-primary" type="submit" value="Log In" style="text-height:font-size:40px;">
                                       Log In
                                    </button>
                              </span>
                            </div> 
                    </form>
                    <?php
					//function login
						if(isset($_POST['loginUser'])){
							$user_name=$_POST['username'];		
							$user_password=	$_POST['password'];	
						
							$queryUser="SELECT * FROM users";	
							$loginUser=$theConnection->executeTheQuery($queryUser);
								if(!$loginUser){
									echo "user query failed".mysqli_error($theConnection);
								}
								
								while($row=mysqli_fetch_assoc($loginUser)){
									$theUsername=$row['username'];
									$theUserPassword=$row['user_password'];
									
									if($theUsername == $user_name && $theUserPassword==$user_password){
										 $_SESSION['user'] = $theUsername;
										 header("Location:index.php");
									} else {
										echo "No such user";	
									}
								}
	
						}
						
						
					
					?>
      </div>             
                    
   <div style="margin-top:30%;">            
		<?php include "include/footer.php" ?>
   </div> 
