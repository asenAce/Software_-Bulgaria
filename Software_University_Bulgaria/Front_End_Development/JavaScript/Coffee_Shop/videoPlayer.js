
function initializeVideoPlayerControls(){
	
	var video = document.getElementById("videoPlayer");
	
	function playVideo(evt) {
		
		button = evt.target;
		if(video.paused){
			video.paly();
			button.textContent = "Pause";
		} else {
			video.pause();
			button.textContent= "Play";
		}
	}
	
	function seek (numberOfSeconds) {
		try {
			if (numberOfSeconds == 0) {
				video.currentTime = numberOfSeconds;
			} else {
				video.currentTime += numberOfSeconds;
			}
		} catch (err) {
			displayError("error");
		}
	}
	
	document.getElementById("playButton").addEventListener("click",playVideo,false);
	document.getElementById("backButton").addEventListener("click" function() {
		seek(-5);
	},false);
	
	document.getElementById("slowerButton").addEventListener("click" function() {
		video.playbackRate -= .25;
	},false);
	
	document.getElementById("fasterButton").addEventListener("click" function() {
		video.palybackRate += .25;
	},false);
	
	document.getElementById("mute").addEventListener("click" function(s) {
		if(video.muted) {
			video.muted = false;
		} else {
			video.muted = true;
		}
		
	},false);
	
}








