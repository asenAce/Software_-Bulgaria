<?php
	session_start();
	ob_start();
	include "admin/db_countries.php";
	include "db.php";
	
	
?>


<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Add Country</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="css/blog-home.css" rel="stylesheet" type="text/css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="css/sb-admin.css" rel="stylesheet" type="text/css">
    <link href="css/admin.css" rel="stylesheet" type="text/css">
</head>
<body>
	<?php include "navigation.php";  ?>
    <div class="container">
    	<h3 style="color:white;">Wellcome <?php echo $_SESSION['admin_username']; ?></h3>
    </div>
    
    <div class=" fa-align-center ">
    	<form style=" margin-top:200px; margin:80px auto;" class="col-lg-6 " action="add_country.php" method="post" enctype="multipart/form-data">
        	<label><h2 style="color:white;">Insert Information for the choosen Country</h2></label>
            <div class="form-group">
            	<label style="color:white;" for="title">Choose the Country</label>
              <select name='theCountry'>
				<?php
					$query="SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA ='countries'";
					$send_query_country= mysqli_query($connection_countries,$query);
					//$count_countries=mysqli_num_rows($send_query_country);
					

						echo "<option><h3>Select a Country</h3></option>";
						while($row=mysqli_fetch_assoc($send_query_country)){
							   
								
								$names_of_the_countries=$row['TABLE_NAME'];
								
										 
										 echo "<option  value='$names_of_the_countries'><h3> $names_of_the_countries </h3></option>";
										 							
						}

				?>
             </select>                
            </div>
            <div class="form-group">
                <label style="color:white;" for="title">Country ID</label>
                <input type="number" class="form-control" name="country_id" required></input>
            </div>
            <div class="form-group">
                <label style="color:white;" for="title">Country Introduction</label>
                <textarea type="text" class="form-control" name="country_intro"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Land and Resources</label>
                <textarea type="text" class="form-control" name="country_land_resources"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Rivers and Lakes</label>
                <textarea type="text" class="form-control" name="country_rivers_lakes"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_image">Country Climate</label>
                <textarea type="file" class="form-control" name="country_climate"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Vegetations and Animals</label>
                <textarea type="number" class="form-control" name="country_vegetables_animals"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Minerals</label>
                <textarea type="text" class="form-control" name="country_minerals"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Enviroment</label>
                <textarea type="text" class="form-control" name="country_enviroment"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Populations</label>
                <textarea type="text" class="form-control" name="country_population"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Education</label>
                <textarea type="text" class="form-control" name="country_education"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Culture Institutions</label>
                <textarea type="text" class="form-control" name="country_culture_institutions"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Economy</label>
                <textarea type="text" class="form-control" name="country_economy"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Agriculture</label>
                <textarea type="text" class="form-control" name="country_agriculture"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Foresty and Fishing</label>
                <textarea type="text" class="form-control" name="country_foresty_fishing"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Mining and Manufacturing</label>
                <textarea type="text" class="form-control" name="country_mining_manufacture"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Energy</label>
                <textarea type="text" class="form-control" name="country_energy"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Foreign Trade</label>
                <textarea type="text" class="form-control" name="country_foreign_trade"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Domestic Markets</label>
                <textarea type="text" class="form-control" name="country_domestic_markets"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Banking</label>
                <textarea type="text" class="form-control" name="country_banking"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Transportation</label>
                <textarea type="text" class="form-control" name="country_transportation"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Communication</label>
                <textarea type="text" class="form-control" name="country_communication"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Heavy Industries</label>
                <textarea type="text" class="form-control" name="country_heavy_industries"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Light Industries</label>
                <textarea type="text" class="form-control" name="country_light_industries"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Competative Advantages</label>
                <textarea type="text" class="form-control" name="country_competative_advantages"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Goverment</label>
                <textarea type="text" class="form-control" name="country_goverment"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Executives</label>
                <textarea type="text" class="form-control" name="country_executives"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Legislature</label>
                <textarea type="text" class="form-control" name="country_legislature"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Judiciary</label>
                <textarea type="text" class="form-control" name="country_judiciary"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Political Parties</label>
                <textarea type="text" class="form-control" name="country_political_parties"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Defence</label>
                <textarea type="text" class="form-control" name="country_defence"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Air Forces</label>
                <textarea type="text" class="form-control" name="country_air_forces"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Navy Forces</label>
                <textarea type="text" class="form-control" name="country_navy_forces"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Land Forces</label>
                <textarea type="text" class="form-control" name="country_land_forces"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country Rocket Forces</label>
                <textarea type="text" class="form-control" name="country_rocket_forces"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country  Anti Air Defence</label>
                <textarea type="text" class="form-control" name="country_anti_air_defence"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country  Internationa Organizations</label>
                <textarea type="text" class="form-control" name="country_internationsl_org"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country  History</label>
                <textarea type="text" class="form-control" name="country_history"></textarea>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country  National Flag</label>
                <input type="file" class="form-control" name="country_nat_flag"></input>
            </div>
            <div class="form-group">
                <label style="color:white;" for="post_status">Country  Map Picture</label>
                <input type="file" class="form-control" name="country_map"></input>
            </div
            <div class="form-group">
                <input class="btn btn-primary" type="submit" name="inser_info" value="Inser Info"></input>
            </div>
            
   		 </form>	
      </div>	
    <?php
		if(isset($_POST['inser_info'])){
			 
				$thenameofCountry=$_POST['theCountry'];
				
				$thecountry_id = intval($_POST['country_id']);
				$thecountry_introduction = $_POST['country_intro'];
				$thecountry_land_resources = $_POST['country_land_resources'];
				$thecountry_rivers_lakes = $_POST['country_rivers_lakes'];
				$thecountry_climate = $_POST['country_climate'];
				$thecountry_vegetables_animals = $_POST['country_vegetables_animals'];
				$thecountry_minerals = $_POST['country_minerals'];
				$thecountry_enviroment = $_POST['country_enviroment'];
				$thecountry_population = intval($_POST['country_population']);
				$thecountry_education = $_POST['country_education'];
				$thecountry_culture_institutions = $_POST['country_culture_institutions'];
				$thecountry_country_economy = $_POST['country_economy'];
				$thecountry_agriculture = $_POST['country_agriculture'];
				$thecountry_foresty_fishing = $_POST['country_foresty_fishing'];
				$thecountry_mining_manufacture = $_POST['country_mining_manufacture'];
				$thecountry_energy = $_POST['country_energy'];
				$thecountry_foreign_trade = $_POST['country_foreign_trade']; 
				$thecountry_domestic_markets = $_POST['country_domestic_markets'];
				$thecountry_banking = $_POST['country_banking'];
				$thecountry_transportation = $_POST['country_transportation'];
				$thecountry_communication = $_POST['country_communication'];
				$thecountry_heavy_industries = $_POST['country_heavy_industries'];
				
				$thecountry_light_industries = $_POST['country_light_industries'];
				$thecountry_competative_advantages = $_POST['country_competative_advantages'];
				$thecountry_goverment= $_POST['country_goverment'];
				$thecountry_executivest= $_POST['country_executives'];
				$thecountry_legislature= $_POST['country_legislature'];
				$thecountry_judiciary= $_POST['country_judiciary'];
				$thecountry_political_parties= $_POST['country_political_parties'];
				$thecountry_defence= $_POST['country_defence'];
				$thecountry_air_forces= $_POST['country_air_forces'];
				$thecountry_navy_forces= $_POST['country_navy_forces'];
				
				$thecountry_land_forces = $_POST['country_land_forces'];
				$thecountry_rocket_forces = $_POST['country_rocket_forces'];
				$thecountry_anti_air_defence = $_POST['country_anti_air_defence'];
				$thecountry_internationsl_org = $_POST['country_internationsl_org'];
				$thecountry_country_history = $_POST['country_history'];
				$thecountry_country_nat_flag = $_FILES['country_nat_flag']['name'];
				$thecountry_country_nat_flag_tmp =$_FILES['country_nat_flag']['tmp_name'];
				$thecountry_country_map = $_FILES['country_map']['name'];
				$thecountry_country_map_tmp = $_FILES['country_map']['tmp_name'];//39
			
				move_uploaded_file($thecountry_country_nat_flag_tmp,"countries/countries_images/$thecountry_country_nat_flag");
				move_uploaded_file($thecountry_country_map_tmp,"countries/countries_images/$thecountry_country_map");
			
			$insert_query ="INSERT INTO $thenameofCountry (country_id,country_introduction,country_land_and_resources,country_rivers_lakes,country_climate,country_vegetation_animals,";
			$insert_query .="country_minerals,country_enviroment,country_population,country_education,country_culture_institutions,country_economy,country_agriculture,";
			$insert_query .="country_forestry_fishing,country_mining_manufacturing,country_energy,country_foreign_trade,country_domestic_markets,currency_banking,country_transportation,";
			$insert_query .="country_communications,country_heavy_industries,country_light_industries,country_competativ_advantages,country_government,country_executives,";
			$insert_query .="country_legislature,country_judiciary,country_political_parties,country_defense,country_air_forces,country_navy_forces,country_land_forces,";
			$insert_query .="country_rocket_forces,country_anti_air_defense,country_international_organizations,country_history,country_nat_flag,country_map) ";	//39  
			
$insert_query .="VALUES($thecountry_id,'$thecountry_introduction','$thecountry_land_resources','$thecountry_rivers_lakes','$thecountry_climate','$thecountry_vegetables_animals','$thecountry_minerals',";
			$insert_query  .="'$thecountry_enviroment',$thecountry_population,'$thecountry_education','$thecountry_culture_institutions',";
			$insert_query  .="'$thecountry_country_economy','$thecountry_agriculture','$thecountry_foresty_fishing','$thecountry_mining_manufacture','$thecountry_energy',";
			$insert_query  .="'$thecountry_foreign_trade','$thecountry_domestic_markets','$thecountry_banking','$thecountry_transportation','$thecountry_communication',";
			$insert_query  .="'$thecountry_heavy_industries','$thecountry_light_industries','$thecountry_competative_advantages','$thecountry_goverment',";
			$insert_query  .="'$thecountry_executivest','$thecountry_legislature','$thecountry_judiciary','$thecountry_political_parties','$thecountry_defence',";
			$insert_query  .="'$thecountry_air_forces','$thecountry_navy_forces',";
			$insert_query  .="'$thecountry_land_forces','$thecountry_rocket_forces','$thecountry_anti_air_defence','$thecountry_internationsl_org',";
			$insert_query  .= "'$thecountry_country_history','$thecountry_country_nat_flag','$thecountry_country_map')";  //39  
			
			$send_insert_query = mysqli_query($connection_countries,$insert_query);
			//var_dump($connection_countries);
			
			if($send_insert_query){
				echo "<h1 style='color:white;'>Country Insertion Succesfull</h1>";
			} else {
				echo "<h1 style='color:white;'>FAILED</h1>".mysqli_error($connection_countries);
			}
			
			echo "$insert_query";
		}
		
	?>
</body>
</html>