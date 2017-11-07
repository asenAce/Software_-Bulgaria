<?php  require('../private/functions.php'); ?>

<?php
  if(!isset($page_title)){
	  
	  $page_title = 'Staff Area';
  }

?>

<!doctype html>

<html lang="en">
  <head>
    <title>GBI - <?php $page_title; ?> </title>
    <meta charset="utf-8">
  <link href="../CSS/staff.css" media="all" rel="stylesheet" type="text/css">
  </head>

  <body>
	<header>
    	<h1>GBI Staff Area</h1>
    </header>
    
    <navigation>
       <ul>
       	   <li><a href="<?php echo url_for('/staff/index.php') ;  ?>">Menu</a></li>	
       </ul>
    </navigation>