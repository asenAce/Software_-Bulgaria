<?php
include("includes/header.php");



?>
<!DOCTYPE html>
<html>
 <head>
  <title>PHP Star Rating System by using Ajax JQuery</title>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
 </head>
 <body>
  <div class="container" style="width:800px;">
   <h2 align="center">PHP Star Rating System by using Ajax JQuery</h2>
   <br />
   <span id="business_list"></span>
   <br />
   <br />
  </div>
  <script>
  	$(document).ready(function() {
        
		function load_business_data()
		{
			$.ajax({
				url:'fetch.php',
				method:"POST",
				success: function(data)
				{
					$('#business_list').html(data);	
				}
			})
		}
		
    });
  </script>
 </body>
</html>