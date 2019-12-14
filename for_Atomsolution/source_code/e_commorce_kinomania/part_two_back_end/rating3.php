<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Untitled Document</title>
<!--<link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">-->
<style>
	/*---------- general ----------*/
	body {
		background: #ff7070;
		color: #F3FCF0;
		font-family: sans-serif;
		text-align: center;
	}
	h1 {
		font-family: 'Raleway', sans-serif;
		text-shadow: 2px 2px 0 #843a3a;
		text-transform: uppercase;
	}
	
	/*---------- star rating ----------*/
	%flex-display {
		display: flex;
	}
	.star-rating {
		@extend %flex-display;
		align-items: center;
		font-size: 3em;
		justify-content: center;
		margin-top: 50px;
	}
	.back-stars {
		@extend %flex-display;
		color: #bb5252;
		position: relative;
		text-shadow: 4px 4px 10px #843a3a;
	}
	.front-stars {
		@extend %flex-display;
		color: #FFBC0B;
		overflow: hidden;
		position: absolute;
		text-shadow: 2px 2px 5px #d29b09;
		top: 0;
	}

</style>
<link href="fonts/font-awesome.min.css" rel="stylesheet" type="text/css">

</head>

<body>
	<h1>Percentage based star rating with Font Awesome</h1>
<p>Feel free to use is, but please, like and share. =)</p>
<div class="star-rating" title="50%">
    <div class="back-stars">
        <i class="fa fa-star" aria-hidden="true"></i>
        <i class="fa fa-star" aria-hidden="true"></i>
        <i class="fa fa-star" aria-hidden="true"></i>
        <i class="fa fa-star" aria-hidden="true"></i>
        <i class="fa fa-star" aria-hidden="true"></i>
        
        <div class="front-stars" style="width: 50%">
            <i class="fa fa-star" aria-hidden="true"></i>
            <i class="fa fa-star" aria-hidden="true"></i>
            <i class="fa fa-star" aria-hidden="true"></i>
            <i class="fa fa-star" aria-hidden="true"></i>
            <i class="fa fa-star" aria-hidden="true"></i>
        </div>
    </div>
</div>    
</body>
</html>