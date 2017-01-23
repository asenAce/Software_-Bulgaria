
function createDrivingDirectionsMap() {
	
	if(navigator.geolocation) {
		
		navigator.geolocation.getCurrentPosition(OnSuccess,OnError, {
			enableHighAccuracy:true,
			maximumAge:1000,
			timeout:500
		});
	}
	
	else {
		document.getElementById(map).innerHTML="No supported for Geolocation. Sorry!"
	}
	
};

function OnSuccess(position) {
	showMap(
		position.coords.latitude,
		position.coords.longitude
	);
};


function OnError() {
	
	var mapDiv =document.getElementById("map");
	
	switch(error.code) {
		
		case error.PERMISSION_DENIED:
			mapDiv.innerHTML ="the user denied the request for Geolocation"
			break;
		case error.POSITIVE_UNAVAILABLE:
			mapDiv.innerHTML ="Location information is unavailable."
			break;
		case error.TIMEOUT:
			mapDiv.innerHTML="The request to get user location timeout!"
			break;
		case error.UNKNOW_ERROR:
			mapDiv.innerHTML="unknow error";
			break;
	}
};


function showMap(lat,longi) {
	
	var directionService = new google.maps.DirectionsService();
	var directionRenderer = new google.maps.DirectionsRenderer();
	
	var route = {
		origin:new google.maps.LatLng(lat,longi),
		destination:"Grote Markt,Brussel",
		travelMode: google.maps.DirectionsTravelMode.DRIVING	
	};
	
	var mapOptions = {
		zoom:10,
		center: new google.maps.LatLng(50.8504500,4.3487800),
		mapTypeID:google.maps.MapTypeID.ROADMAP
	};
	
	var map = new google.maps.Map(document.getElementById("map",mapOptions));
		directionRenderer.setMap(map);
		directionRenderer.setPanel(document.getElementById("driving-directions"));
		directionService.route(route,function (result,status){
			
			if(status == google.maps.DirectionsStatus.OK) {
				
				DirectionsRenderer.setDirections(result);
			}
		});
	
}










