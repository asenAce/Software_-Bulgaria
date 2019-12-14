<?php
			include("includes/header.php");
			ob_start();
			
			
					
					
			
					if(isset($_POST['submitTheComment'])){
						
						$theUserNameIs = $_POST['theUserName'];
						$theCommentIs = $_POST['theComment'];
						$theMovieTitle = $_POST['theMovieTitle'];
						
						
						
							
							
						
							$commentQuery = "INSERT INTO comments(comment_author,comment_content,comment_movie_title) VALUES('$theUserNameIs','$theCommentIs','$theMovieTitle')";
								$sendComment = $theConnection->executeTheQuery($commentQuery);
								
								if($sendComment){
									
									header("Location:index.php?theKeyWord=$theKeyWord");
								}
						
					}
				
?>