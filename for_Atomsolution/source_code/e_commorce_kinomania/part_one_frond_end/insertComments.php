<?php
			include("includes/header.php");
			ob_start();
			
					if(isset($_POST['sendComment'])){
						
						$theUserNameIs = $_POST['theUser'];
						$theCommentIs = $_POST['theComment'];
						$theMovieTitle = $_POST['theMovieTitle'];
						
							$commentQuery = "INSERT INTO comments(comment_author,comment_content,comment_movie_title) VALUES('$theUserNameIs','$theCommentIs','$theMovieTitle')";
								$sendComment = $theConnection->executeTheQuery($commentQuery);
								
								if($sendComment){
									
									header("Location:index.php");
								}
					}
?>