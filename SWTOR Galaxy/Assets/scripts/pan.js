
public var start:Vector3;
public var end:Vector3;
public var Rate:float;
private var yPos:float;

function LateUpdate () 
{
	yPos = yPos + (Time.deltaTime*Rate);

	transform.localPosition.y = start.y + yPos ;
	
	if(yPos >= end.y )
	{
		yPos = start.y;
	}
}