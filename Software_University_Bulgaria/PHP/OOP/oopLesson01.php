<?php
  
  
   class Product {
	   
	  public static $manufacturer ="BBG";
	  
	  public $name='default_name';
	  public $price='0';
	  public $desc='default_desc';
	  
	  function __construct($name,$price,$desc){
		  $this->name=$name;
		  $this->price=$price;
		  $this->desc=$desc;
		  
	  }
	
	  public function getInfo(){
		  return "Product Name:" . $this->name;
	  }
	  
	  public function getMaker(){
		   return self::$manufacturer;
		   
	  }
	   
   }
   
   class Soda extends Product{
	  public $flavor;
	  
	   function __construct($name,$price,$desc,$flavor){
		  parent::__construct($name,$price,$desc);
		  
		  $this->flavor = $flavor;
		  
	  }
	  
	  public function getInfo(){
	      return "Product Name: " . $this->name . " Flavor: " . $this->flavour;  
	  }
	     
   }
   
   echo $shirt::$manufacturer;
   echo $shirt->getMaker();
   
   
   $shirt = new Product("Space Juice",20,"XXL cotton");
   $soda = new Product("Fizi Soda",3.6,"with vanila flavour");
   $soda = new Soda("Fizi Soda",3.9,"with vanila flavour 2 ","Grape");
   
   echo $shirt->getMaker();
   echo $soda->getInfo();
   echo $shirt->getInfo();
   
   /*
   $p = new Product();
   $p->name = "sp text";
   echo $p->name; 
    */
	?>
	<?php
	
	$this
	
	self::method();
	self::property_name;
	
	Class->method();
	Class->property_name;
	
	/*Interfaces*/
	
	interface Rideable{
	  public function howToRide();
	  	
	}
	
	class Skateboard implements Rideable
	{
	    public function howToRide(){
		    $steps = array();
			
			$steps[]="Balance your front foot";
			$steps[]="Kick";
			$steps[]="Dont fall";
			
			return $steps;	
		}  	
	}
	
	try {
		
	} catch(Exception $e) {
	   $e->getMessage();
	   $e->getCode();
	   $e->getFile();
	   $e->getTrace();
	   $e->getTraceAsString();
	   	
	}
	
	
	method_exists(object,method_name);
	
	return method_exists("Product","getPrice");
	
	$p=new Product("Name",20,"Description");
	
	return method_exists($p,"getPrice")';
	
	
	class Product{
	   	
	}
	
	class Soda extends Product {
	  	
	}
	
	$s = new Soda();
	
	is_subclass_of($s,"Product");
	
	$class = "Product";
	$p = new $class;
	
	$m="getName";
	$name = $p->m();
	
	?>

 




