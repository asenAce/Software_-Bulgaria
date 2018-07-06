<?php
	require_once"db.php";
	$theConnection = new Db("localhost","root","","cms");
	
	
	       
	 	       
	 
?>
<div class="col-md-4 pull-right" style="margin-top:2%; ">
    <!-- Blog Search Well -->
    <div class="well">
     <h4><strong>Blog Search</strong></h4>
      <form class="" action="include/search.php" method="post">
        <div class="input-group">
            <input name="search" type="text" class="form-control">
            <span class="input-group-btn">
                <button class="btn btn-default" name="submitSearch" type="submit">
                    <span class="glyphicon glyphicon-search"></span>
                </button>
            </span>
        </div> 
      </form> <!--search form-->
        <!-- /.input-group -->
    </div>
    <!-- Blog Categories Well -->
    <div class="well">
        <h4><strong>Blog Categories</strong></h4>
        <div class="row">
            <div class="col-lg-12">
                <ul class="list-unstyled">
					<?php 
						$selectAllCategories = $theConnection->executeTheQuery("SELECT * FROM categories");
						$theConnection->displyCategories($selectAllCategories);		
					?>                  
                </ul>
            </div>
        </div>
        <!-- /.row -->
    </div>
    <!-- Side Widget Well -->
                <div class="well pull-right">
                    <h4>BG Auto</h4>
                      <section>
                        <div class="banner">
                           <div class="animated">
                             <a href="https://www.auto.bg/pcgi/index.cgi">
                            <div class="text1">
                                <p>Unlimeted Storage of Cars</p>
                            </div>
                            <div class="text2">
                                <p>from $1800 to $80000</p>
                            </div>
                          </div> 
                        </div>
                       </a> 
                    </section>
                </div>
</div>
</div>
<!-- /.row -->
<hr>
