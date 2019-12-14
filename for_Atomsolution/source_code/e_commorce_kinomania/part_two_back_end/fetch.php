<?php
	
	
	$connect = new PDO('mysql:host=localhost;dbname=kinomania',"root",'');
	$query ="SELECT * FROM business ORDER BY id DESC";
	$statement = $connect->prepare($query);

	$statement->execute();
	$result = $statement->fetchAll();
	$output = '';
		
			foreach($result as $row){
				$rating = count_rating($row["id"],$connect);
				$color = '';
				$output .='<h3 class="text-primary">'.$row['business_name'].'</h3>
				  <ul class="list-inline" data-rating="'.$rating.'" title="Average Rating-'.$rating.'">	
				';
					
					for($count=1;$count <=5;$count++){
						
						if($count <= $rating){
							
							$color = 'color:#ffcc00';
							
						} else {
							
						}
					}
			}
			
			
	function count_rating($business_id,$connect){
			
			$output = 0;
			$query ="SELECT AVG(rating) as rating FROM rating WHERE business_id = '$business_id'";
			
			$statement = $connect->prepare($query);
			$statement->execute();
			$result = $statement->fetchAll();
			$total_row = $statement->rowCount();
				if($total_row > 0){
					foreach($result as $row){
						$output = round($row["rating"]);
					}
				}
		   return $output;
	}

?>