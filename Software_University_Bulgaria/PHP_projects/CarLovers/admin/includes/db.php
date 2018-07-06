<?php

	class Db{
		// db properties
		private $host;
		private $user;
		private $password;
		private $theDb;
		private $myConnection;
		public  $sql;
			
			public function __construct($host,$user,$password,$theDb){
				//global $myConnection;
				$this->myConnection=mysqli_connect($host,$user,$password,$theDb);
					if($this->myConnection){
						echo "you are connected!!";
					} else {
						echo "you are not connected!!".mysqli_error($this->myConnection);	
					}
				
			}
			
			
			public function executeTheQuery($sql){
				
				$executeQuery = mysqli_query($this->myConnection,$sql);
					if(!$executeQuery){
					    echo "Query failed".mysqli_error($this->myConnection);
					} 
				return $executeQuery;	
			}
			
			public function displyCategories($procesedData){
				
				while($row=mysqli_fetch_assoc($procesedData)){
					$category_title = $row['cat_title'];
					$disply="<li><a href='#'>{$category_title}</a></li>";
					
					echo $disply;
				}
				
				 
				
			}
			
			
		
		
	}

	
?>