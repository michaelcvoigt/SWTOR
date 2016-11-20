public var jitterAmount = .25;
public var jitterAmountZ = 1.00;
public var alphaLow = .5;
public var alphaHigh = 1.0;
private var origX = 0.0;
private var origY = 0.0;
private var origZ = 0.0;

function Start()
{
	origX = transform.localPosition.x;
	origY = transform.localPosition.y;
	origZ = transform.localPosition.z;
}

function LateUpdate () 
{

	transform.localPosition = Vector3( origX + Random.Range(- jitterAmount, jitterAmount )  , origY +   Random.Range(- jitterAmount, jitterAmount)   ,  origZ +  Random.Range(- jitterAmountZ , jitterAmountZ )   );
	GetComponent.<Renderer>().material.color.a = Random.Range(alphaLow, alphaHigh) ;

}