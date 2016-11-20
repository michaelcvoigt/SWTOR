var rotationSpeedX = 0.0; 
var rotationSpeedY = 0.0; 
var rotationSpeedZ = 0.0;

private var mouseOver = false;

function Update () { 
	
  if( ! mouseOver)
  {
  
 	var rotationx = rotationSpeedX; 
 	rotationx *= Time.deltaTime;
 	var rotationy = rotationSpeedY; 
 	rotationy *= Time.deltaTime; 
 	var rotationz = rotationSpeedZ; 
 	rotationz *= Time.deltaTime; 
 
 	transform.Rotate (rotationx, rotationy, rotationz); 
 
  }
 
 
} 

function setMouseOver(_flag) 
{ 
	mouseOver = _flag;
}