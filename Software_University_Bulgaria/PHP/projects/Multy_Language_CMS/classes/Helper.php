<?php
class Helper {






	public static function sanitise($string = null) {
		if (!empty($string)) {
			$string = strtolower(trim($string));
			$string = preg_replace("/[^A-Za-z0-9.\s]/", "", $string);
			return preg_replace("/[\s]+/", "-", $string);
		}
	}










	public static function makeArray($array = null) {
		return is_array($array) ? $array : array($array);
	}
	
	
	
	
	
	
	
	
	public static function getPlug($file = null, $data = null) {
		if (!empty($file)) {
			$file = ROOT_PATH.DS.'plugs'.DS.$file.'.php';
			if (is_file($file)) {
				ob_start();
				require_once($file);
				return ob_get_clean();
			}
		}
	}
	
	
	
	
	
	
	
	
	
	
	public static function clearString($string = null, $array = null) {
		if (!empty($string) && !self::isEmpty($array)) {
			$array = self::makeArray($array);
			foreach($array as $key => $value) {
				$string = str_replace($value, '', $string);
			}
			return $string;
		}
	}
	
	
	
	
	
	
	
	
	public static function isEmpty($value = null) {
		return empty($value) && !is_numeric($value) ? true : false;
	}
	
	
	
	
	
	
	
	
	public static function redirect($location = null) {
		if (!empty($location)) {
			header("Location: {$location}");
			exit;
		}
	}
	
	
	
	
	
	
	
	






}