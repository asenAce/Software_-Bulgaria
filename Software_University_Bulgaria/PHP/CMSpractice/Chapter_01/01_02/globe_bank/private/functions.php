<?php


    function url_for($script_paht){
		
		if($script_paht[0] != '/'){
			
			$script_paht="/".$script_paht;
		}
		
		return WWW_ROOT .$script_paht;
	}


?>
