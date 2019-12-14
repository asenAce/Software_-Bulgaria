
	<?php
		include("includes/header.php");
		include("includes/navigation.php");
		
	?>
    <div class="wrapper">
    	<div class="container">
        	<div class="row">
            	<div class="col-lg-9 col-lg-push-3" >
                	<form role="search" method="post" class="visible-xs">
                    	<div class="form-group">
                        	<div class="input-group">
                            	<input type="search" class="form-control input-lg" placeholder="Search a movie">
                                <div class="input-group-btn">
                                	<button class="btn btn-default btn-lg" type="submit"><i class="glyphicon glyphicon-search"></i></button>
                                </div>
                            </div>
                        </div>
                    </form>
                    <h2>Best Movies Raitings</h2>
                    <hr>
                <table class="table table-striped">
                        <thead>
                            <tr>
                                <th></th>
                                <th>Movie</th>
                                <th class="text-center">Year</th>
                                <th class="text-center">Raiting</th>
                                <th class="text-center">Price</th>
                            </tr>
                        </thead>
                    <tbody>
                        <tr>
                            <td class="col-lg-1 col-md-1 col-xs-2">
                                <img class="img-responsive img-thumbnail" src="img/movie_posters/39ba2d7ab6f6470c640647bf3d028be9.jpg" alt="Iniana Jhones">
                            </td>
                            <td class="vert-align"><a href="theMovie.php">Indiana Jhones</a></td>
                            <td class="text-center vert-align">2016</td>
                            <td class="text-center vert-align"><span class="badge">9.0</span></td>
                            <td class="text-center vert-align"><span class="badge">$9.77</span></td>
                        </tr>
                        <tr>
                            <td class="col-lg-1 col-md-1 col-xs-2">
                                <img class="img-responsive img-thumbnail" src="img/movie_posters/633bbdab878f1cef2c6a58c37cbcaee8.jpg" alt="Iniana Jhones">
                            </td>
                            <td class="vert-align"><a href="theMovie.php">The Matrix</a></td>
                            <td class="text-center vert-align">1999</td>
                            <td class="text-center vert-align"><span class="badge">8.0</span></td>
                            <td class="text-center vert-align"><span class="badge">$5.77</span></td>
                        </tr>
                         <tr>
                            <td class="col-lg-1 col-md-1 col-xs-2">
                                <img class="img-responsive img-thumbnail" src="img/movie_posters/268x0w.png" alt="Iniana Jhones">
                            </td>
                            <td class="vert-align"><a href="theMovie.php">Saving Private Rayan</a></td>
                            <td class="text-center vert-align">2000</td>
                            <td class="text-center vert-align"><span class="badge">8.9</span></td>
                            <td class="text-center vert-align"><span class="badge">$4.77</span></td>
                        </tr>
                    </tbody>
                </table>
                        <div class="margin-8 clear"></div>
                </div>
                
               <!--Left site min-menu-->
               <?php
			   		include("includes/leftSiteMinMenu.php");
			   ?>
            </div>
        </div>
    </div>
	<?php 
		include("includes/footer.php");
	?>
</body>
</html>