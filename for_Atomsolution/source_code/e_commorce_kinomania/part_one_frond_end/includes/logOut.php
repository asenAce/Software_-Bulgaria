<?php

include("includes/header.php");
session_start();


								   $_SESSION['admin_username'] = null;	
								   $_SESSION['admin_id'] = null;
								   $_SESSION['user'] = null;
								   header("Location:../index.php");

?>