var target: GameObject; 

function Update () 
{
	
	var targetDist = transform.position - target.transform.position;
				
				
					
	GetComponent.<Renderer>().materials[0].color.a = 1 - (targetDist.magnitude-1.5);
	
}