<?php

   class Db {
		
		// db properties
		private $host;
		private $user;
		private $password;
		private $theDb;
		private $myConnection; 
		private $sql;  
	   
	   		public function __construct($host,$user,$password,$theDb){
				//global $myConnection;
				 $this->myConnection = mysqli_connect($host,$user,$password,$theDb);
				 	if($this->myConnection){
						echo "";
					} else {
						
						echo "No connection!".mysqli_error($this->myConnection);
					}
				
			}
			
		    function confirmTheQuery($incomig) {
				global $theConnection;
			
				if(!$incomig){
					echo "Add Query Failed".mysqli_error($theConnection);
				}

			}
	   
	   		public function executeTheQuery($sql){
				
				$executeQuery = mysqli_query($this->myConnection,$sql);
				 if(!$executeQuery){
					 echo "Query Failed".mysqli_error($this->myConnection);
				 } 
				 
				 return $executeQuery;
			}
	   
	   		public function displayCategories($procesedData){
				
				while($row = mysqli_fetch_assoc($procesedData)){
					
					$category_id = $row['cat_id'];
					$category_title= $row['cat_title'];

					$display = "<li><a style='text-decoration:none;' href='category.php?theCategoryTitle=$category_title'>$category_title</a></li>";
					
					 	echo $display;
				}
				
				
			}
	   		
	   
	   
	   
   }






?>