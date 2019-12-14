<?php
	
			function displayCategories($procesedData){
					
				while($row=mysqli_fetch_assoc($procesedData)){
					
					$category_title = $row['cat_title'];
					$category_link = $row['cat_link'];
						$display="<li><a href='$category_link'>$category_title</a></li>";
						
						echo $display;
				}
			}


?>