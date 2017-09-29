<?php
   
   class Perosn {
	
	  public $age;
	  public $name;
	  
	  
	  		function __construct(string $name,int $age){
			
				$this->name = $name;
				$this->age = 0;
				
				echo $his->name . " ". $this->age;
			}   
	   
   }
   //3-ta
   
   $number = trim(fgets(STDIN));
   $info=[];
   
   for($i=0;$i<$number;$i++){
	  $personInfo =explode(trim(fgets(STDIN)));
	  $Person= new Perosn($personInfo[0],$personInfo[1]);
	  $info=$Person; 
   }
   
   foreach ($info as $Person){
	   if($Person->age >30){
	        echo $Person->name. " ".$Person->age;
	   }
   }
   
   
   
   $person = new Perosn();
   $person('Pesho',22);
   
   $person2 = new Perosn();
   $person2('Ivan',34);
   
   print_r($person);
   
   
   
   
   class Employee {
	
	   public $name;
	   public $salary;
	   public $position;
	   public $departament;
	   public $email;
	   public $age;
	   
	   
	   function __construct($name,$salary,$position,$department,$email='n/a',$age = -1){
		   
		   $this->age=$age;
		   $this->name=$name;
		   $this->salary=$salary;
		   $this->position=$position;
		   $this->departament=$department;
		   $this->email=$email;
		   
		   $n= trim(fgets(STDIN));
           $employee=[];		  
		   
		   for($i=0;$i<$n;$i++){
			   
			 $input=explode(" ",trim(fgets(STDIN))); 
			 
			 $name =$input[0];
			 $salary=$input[1];
			 $position=$input[2];
			 $department=$input[3];
			// $email=$input[4];
			// $age=$input[5];
			 
			 $email =array_key_exists(key: 4,$input) ? $input[4] : "n/a";
			 $age =array_key_exists(key:5,$input) ? $input[5] : -1;
			 $employee[]=new Employee($name,$salary,$position,$department,$email,$age); 
			   
		   }
		   
		   
		   
		   
		
		   
	   }
	   
	      
	   
   }
   
   
   
   


?>