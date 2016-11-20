public var jitterAmount = .25;
public var jitterAmountZ = 1.00;
public var object:GameObject;

private var origX = 0.0;
private var origY = 0.0;
private var origZ = 0.0;

function Start()
{
	origX = object.transform.localPosition.x;
	origY = object.transform.localPosition.y;
	origZ = object.transform.localPosition.z;
}

function LateUpdate () 
{

object.transform.localPosition = Vector3( origX + Random.Range(- jitterAmount, jitterAmount )  , origY +   Random.Range(- jitterAmount, jitterAmount)   ,  origZ +  Random.Range(- jitterAmountZ , jitterAmountZ )   );
	
}