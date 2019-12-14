
<?php 
	include "includes_admin/header_admin.php"; 
	include "includes_admin/admin_navigation.php";
	include "includes_admin/admin_functions.php";
?>

    <div id="wrapper" style="margin-top:70px;">
        <div id="page-wrapper">
            <div class="container-fluid">
                <!-- Page Heading -->
                <div class="row">
                    <div class="col-lg-12">
                    	<h1 class="page-header">
                            Wellcome to Admin 
                              <small>Create New Movies</small>
                        </h1>
                   <!-- Table Posts
                   
                    -->     
 <?php
 				   // Craete Posts Function
				    createNewMovies();
 
 ?>                  
                       <form action="add_newMovies.php" method="post" enctype="multipart/form-data">
                                <div class="form-group">
                                    <label for="title">New Movie Title</label>
                                    <input type="text" class="form-control" name="movie_title"></input>
                                </div>
                                <div class="form-group">
                                    <label for="title">Movie Description</label>
                                    <textarea class="form-control" name="movie_description" id="" cols="30" rows="10"></textarea>
                                </div>
                                <div class="form-group">
                                    <label for="title">Movie Trailer Href</label>
                                    <input type="text" class="form-control" name="movie_trailer_href"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_status">Movie Year</label>
                                    <input  type="number" class="form-control" name="movie_year"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_image">Movie Image Poster</label>
                                    <input type="file" class="form-control" name="movie_image_poster"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_image">Movie Image DVD</label>
                                    <input type="file" class="form-control" name="movie_image_dvd"></input>
                                </div>
                                <div class="form-group">
                                    <label for="post_tag">Movie Rating</label>
                                    <input type="number" class="form-control" name="movie_raiting"></input>
                                </div>
                                <div class="form-group">
                                    <label for="title">Movie Director</label>
                                    <input type="text" class="form-control" name="movie_director"></input>
                                </div>
                                <div class="form-group">
                                    <label for="title">Movie Category</label>
                                    <input type="text" class="form-control" name="movie_category"></input>
                                </div>
                                 <div class="form-group">
                                    <label for="title">Movie Price</label>
                                    <input type="number" class="form-control" name="movie_price"></input>
                                </div>
                                <div class="form-group">
                                    <input class="btn btn-primary" type="submit" name="create_newMovies" value="Publish New Movie"></input>
                                </div> 
                            </form>    
                    </div>
                </div>
                <!-- /.row -->

            </div>
            <!-- /.container-fluid -->

        </div>
        <!-- /#page-wrapper -->

    </div>
    <!-- /#wrapper -->

