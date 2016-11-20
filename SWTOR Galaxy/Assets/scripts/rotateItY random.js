var minY : int = 0; 
var maxY : int = 0; 
private var rotationSpeedY : int; 
private var rotationy : float;
function Start()
{
	rotationSpeedY = Random.Range(minY, maxY);
	
}

function Update () 

{ 	
 	rotationy = rotationSpeedY; 
 	rotationy *= Time.deltaTime;  
 	transform.Rotate (0, rotationy,0); 
} 
