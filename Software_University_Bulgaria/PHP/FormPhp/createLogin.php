<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <title>Create Login</title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha   384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

  </head>
  <body>
  <?php
	// To be able to connect to the database via PHP.
	$connection = mysqli_connect('localhost', 'root', '', 'loginapp');
	
	if(!$connection) {
	  die('Database connection failed!');
	} else {
		echo "connected";
	}
	
	
	function createRows(){

		//global $connection;
		$username = $_POST['username'];
		$password = $_POST['password'];
		// Used to escape all the data inside the field, it helps prevent SQL injection.
		$username = mysqli_real_escape_string($connection, $username);
		$password = mysqli_real_escape_string($connection, $password);
		
		$query = "INSERT INTO users(username,password) VALUES('$username', '$password')";
		$result = mysqli_query($connection, $query);
		if (!$result) {
		  die('query FAILED' . mysqli_error($connection));
		} else {
		  echo "Record Created";
		}
  }
  
  if (isset($_POST['submit'])) {
	  $username = $_POST['username'];
	  $password = $_POST['password'];
  
		  // if ($username && $password) {
		  //   echo $username . $password;
		  // } else {
		  //   echo "Nope, not set";
		  // }
		  // echo $username . $password;
		  // }
  
	createRows();
}
?>
  <div class="container">
      <div class="col-sm-6">
        <h1 class="text-center">Create</h1>
        <form class="" action="createLogin.php" method="post">
          <div class="form-group">
            <label for="username">Username</label>
            <input type="text" name="username" class="form-control">

          </div>
          <div class="form-group">
            <label for="password">Password</label>
            <input type="password" name="password" class="form-control">

          </div>

          <input type="submit" name="submit" value="Create" class="btn btn-info">

        </form>
   </div>
  </body>  