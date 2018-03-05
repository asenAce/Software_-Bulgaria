<!doctype html>
<html>
<head>
    <meta charset="utf-8">
    <title>Indext</title>
        <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css" rel="stylesheet" type="text/css">
        <link href="../css/blog-home.css" rel="stylesheet" type="text/css">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
        <link href="../css/sb-admin.css" rel="stylesheet" type="text/css">
        <link href="css_countries/custom.css" rel="stylesheet" type="text/css">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
</head>
<body>
	<nav class="navbar navbar-inverse">
    	<div class="container-fluid">
        	<div class="navbar-header">
            	<a  href="../index.php" class="navbar-brand"><h2 style="color:white; margin-bottom:6px;">Magma Imperium</h2></a>
            </div>
          <div>  
        	<ul class="nav navbar-nav">
                    <li class="active"><a href="../selectCountry.php">Go To Countries</a></li>
                    <li class="active">
                            <a href="madagascar/introduction.php" >Introduction</a>
                    </li>
                 <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">Land and Resources <span class="caret"></span></a>
                         <ul class=" dropdown-menu">
                         	<li><a href="madagascar_country_land_and_resources.php">Land and Resources</a></li>
                            <li><a href="#">Rivers and Lakes</a></li>
                            <li><a href="#">Climate</a></li>
                            <li><a href="#">Vegetation and Animal Life</a></li>
                            <li><a href="#">Minerals Resources</a></li>
                            <li><a href="#">Enviroment</a></li>
                         </ul>   
                 </li>
                 <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">Population<span class="caret"></span></a>
                         <ul class=" dropdown-menu">
                            <li><a href="#">Population</a></li>
                            <li><a href="#">Education</a></li>
                            <li><a href="#">Cultural Institutions</a></li>     
                         </ul>   
                 </li>
                 <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">Economy<span class="caret"></span></a>
                         <ul class=" dropdown-menu">
                            <li><a  href="madagascar_economy.php">Economy</a></li>
                            <li><a href="madagascar_agriculture.php">Agriculture</a></li>
                            <li><a href="madagascar_foresty_fishing.php">Foresty Fishing</a></li>  
                            <li><a  href="mining_manufacturing.php">Mining Manufacturing</a></li> 
                            <li><a href="#">Energy</a></li>     
                            <li><a href="#">Foreign Trade</a></li> 
                            <li><a href="#">Currency Banking</a></li> 
                            <li><a href="#">Transportation</a></li> 
                            <li><a href="#">Communications</a></li> 
                         </ul>   
                 </li>
                 <ul class="nav navbar-nav">
                        <li class="active">
                            <a href="#">Light Industries</a>
                        </li>
                 </ul>
                 <ul class="nav navbar-nav">
                        <li class="active">
                            <a href="#">Heavy Industry</a>
                        </li>
                 </ul>
                 <ul class="nav navbar-nav">
                        <li class="active">
                            <a href="#">Local Markets</a>
                        </li>
                 </ul>
                 <ul class="nav navbar-nav">
                        <li class="active">
                            <a href="#">Commpetative Advantages</a>
                        </li>
                 </ul>
                 <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">Goverment<span class="caret"></span></a>
                         <ul class=" dropdown-menu">
                            <li><a href="#">Executive</a></li>
                            <li><a href="#">Legislation</a></li>
                            <li><a href="#">Judiciary</a></li>  
                            <li><a href="#">Political Parties</a></li> 
                            <li><a href="#">Defence</a></li>     
                            <li><a href="#">Internat Organization</a></li> 
                         </ul>   
                 </li>
                 <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">Arm Forces<span class="caret"></span></a>
                         <ul class=" dropdown-menu">
                            <li><a href="#">Air Forces</a></li>
                            <li><a href="#">Navy Forces</a></li>
                            <li><a href="#">Land Forces</a></li>  
                            <li><a href="#">Rocket  Forces</a></li> 
                            <li><a href="#">Anti-Air Forces</a></li>     
                         </ul>   
                 </li>
              </ul>
                    <ul class="nav navbar-nav">
                        <li class="active">
                            <a href="#">History</a>
                        </li>
                    </ul>
                   <ul class="nav navbar-nav navbar-right" >
                        <li><h2 style=" color:white; margin-right:8px;">Game character <?php echo $_SESSION['player_name']; ?></h2></li>
                   </ul> 
              </div>  
              </div>  
        </nav>
</body>
</html>