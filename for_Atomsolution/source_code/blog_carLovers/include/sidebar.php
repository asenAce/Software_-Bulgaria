<div class="col-md-4 pull-right" style="margin-top:2%">
    	 <!-- The Blog Search Well -->
         <div class="well">
         	<h4><strong>Blog Search</strong></h4>
            <form action="search.php" method="post">
                	<div class="input-group">
                    	<input name="search" type="text" class="form-control"  placeholder="Search by Tag">
                        	<span class="input-group-btn">
                            	<button class="btn btn-default" name="submitSearch" type="submit">
                                	<span class="glyphicon glyphicon-search"></span>
                                </button>
                            </span>
                    </div>
             </form>
    </div>  
    <div class="well">
    	<h4><strong>Blog Categories</strong></h4>
        <div class="row">
        	<div class="col-md-12">
            	<ul class="list-unstyled">
                	 <!-- php code -->
                	<?php
						$sellectAllCategories= $theConnection->executeTheQuery("SELECT * FROM categories");
						$theConnection->displayCategories($sellectAllCategories);
						echo "<li><a style='text-decoration:none;' href='#'>Photo Album</a></li>";
					?>
                </ul>
            </div>
        </div>
    </div>
    	<!-- The Advert Banner -->
    <div class="well">
    	<h4>BG Auto</h4>
        	<section>	
            	<div class="banner">
                	<div class="animated">
                    	<a href="https://www.auto.bg/pcgi/index.cgi" target="_blank">
                        	<div class="text1">
                            	<p>Unlimeted Storage of Cars</p>
                            </div>
                            <div class="text2">
                            	<p>from $1800 to $80000</p>
                            </div>
                        </a>
                    </div>
                </div>
            </section>
    </div>
</div>