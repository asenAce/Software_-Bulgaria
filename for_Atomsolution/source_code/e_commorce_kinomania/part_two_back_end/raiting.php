
<div class="row">
	<?php
		if(isset($_POST['submitTheRaiting'])){
			
			$theMovieTitle = $_POST['movieTitles'];
			$theRaiting = $_POST['theRaiting'];
			
		
			$ratingQuery = "UPDATE new_movies  SET movie_rating='$theRaiting' WHERE movie_title LIKE '%$theMovieTitle%' ";
			$sendMovieRating=$theConnection->executeTheQuery($ratingQuery);
		
			header("Location:index.php");	
		}

	?>
<h3>Please Rate This Movies</h3>
<form role="form" method="post" action="">
  <div class="form-group">

    <select id="product-select" name="movieTitles" class="form-control custom-select">
    <option  value="0" disabled selected>Select Product</option>
    <?php
	
		if(isset($_GET['p_id'])){
			$theMovieId = $_GET['p_id'];
			
			$showTheRaitings = "SELECT * FROM new_movies WHERE id ='$theMovieId'";
			$showRaitings = $theConnection->executeTheQuery($showTheRaitings);
			while($row=mysqli_fetch_assoc($showRaitings)){
				$movieTitle = $row['movie_title'];
				$movieRating = $row['movie_rating'];
		
		
			
		
   ?>
        
        <option value="<?php echo $movieTitle; ?>"><?php echo $movieTitle; ?></option>
  <?php
			}
		}	
  ?>      
    </select>
  </div>
  <div class="form-group">
    <input type="number" id="rating-control" class="form-control" step="1" max="5" placeholder="Rate 1 - 5" disabled name="theRaiting">
  </div>
  	<button name="submitTheRaiting" type="submit" class="btn btn-lg btn-warning btn-block">Submit</button>
</form>

<table class="table table-striped">
  <?php
		$showTheRaitings = "SELECT * FROM new_movies LIMIT 6";
		$showRaitings = $theConnection->executeTheQuery($showTheRaitings);
			while($row=mysqli_fetch_assoc($showRaitings)){
				
				$movieTitle = $row['movie_title'];
				$movieRating = $row['movie_rating'];
				
			
		
   ?>
    <thead>
      <tr>
        <th><?php echo $movieTitle; ?></th>
        <th><?php echo $movieRating; ?></th>
      </tr>
    </thead>
    <tbody>
  <?php
  if($movieRating == 5){
				
				echo "<tr class='sony'>";
				echo "<td>$movieTitle</td>";
				echo "<td>";
					echo "<div class='stars-outer'>";
					echo "<div class='stars-inner'></div>";
					echo "</div>";
					echo "<span class='number-rating'>$movieRating</span>";
					echo "</td>";
					echo " </tr>";
					
 } else if($movieRating == 2){
	 
	 echo "<tr class='samsung'>";
				echo "<td>$movieTitle</td>";
				echo "<td>";
					echo "<div class='stars-outer'>";
					echo "<div class='stars-inner'></div>";
					echo "</div>";
					echo "<span class='number-rating'>$movieRating</span>";
					echo "</td>";
					echo " </tr>";
	 
 } else if($movieRating == 1) {
	 	
		echo "<tr class='vizio'>";
				echo "<td>$movieTitle</td>";
				echo "<td>";
					echo "<div class='stars-outer'>";
					echo "<div class='stars-inner'></div>";
					echo "</div>";
					echo "<span class='number-rating'>$movieRating</span>";
					echo "</td>";
					echo " </tr>";
	 
 } else if ($movieRating == 3){
	 
	 	echo "<tr class='panasonic'>";
				echo "<td>$movieTitle</td>";
				echo "<td>";
					echo "<div class='stars-outer'>";
					echo "<div class='stars-inner'></div>";
					echo "</div>";
					echo "<span class='number-rating'>$movieRating</span>";
					echo "</td>";
					echo " </tr>";
	 
 } else if($movieRating == 4){
	 
	 	echo "<tr class='phillips'>";
				echo "<td>$movieTitle</td>";
				echo "<td>";
					echo "<div class='stars-outer'>";
					echo "<div class='stars-inner'></div>";
					echo "</div>";
					echo "<span class='number-rating'>$movieRating</span>";
					echo "</td>";
					echo "</tr>";
	 
 }
 
 ?>
 <?php
 	}
 ?>
 </tbody>
  </table>
</div>
<script>
// Initial Ratings
const ratings = {
	  
	  sony: 5,
      samsung: 2,
      vizio: 1,
      panasonic: 3,
      phillips: 4
	

    }		
  
    // Total Stars
    const starsTotal = 5;

    // Run getRatings when DOM loads
    document.addEventListener('DOMContentLoaded', getRatings);

    // Form Elements
    const productSelect = document.getElementById('product-select');
    const ratingControl = document.getElementById('rating-control');

    // Init product
    let product;

    // Product select change
    productSelect.addEventListener('change', (e) => {
      product = e.target.value;
      // Enable rating control
      ratingControl.disabled = false;
      ratingControl.value = ratings[product];
    });

    // Rating control change
    ratingControl.addEventListener('blur', (e) => {
      const rating = e.target.value;

      // Make sure 5 or under
      if (rating > 5) {
        alert('Please rate 1 - 5');
        return;
      }

      // Change rating
      ratings[product] = rating;

      getRatings();
    });

    // Get ratings
    function getRatings() {
      for (let rating in ratings) {
        // Get percentage
        const starPercentage = (ratings[rating] / starsTotal) * 100;

        // Round to nearest 10
        const starPercentageRounded = `${Math.round(starPercentage / 10) * 10}%`;

        // Set width of stars-inner to percentage
        document.querySelector(`.${rating} .stars-inner`).style.width = starPercentageRounded;

        // Add number rating
        document.querySelector(`.${rating} .number-rating`).innerHTML = ratings[rating];
      }
    }
			
    </script>

