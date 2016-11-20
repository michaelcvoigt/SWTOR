public var object: GameObject;
public var amt: float;
var scrollSpeed = .01;
var color : Color;
var _material : Material;

function Start()
{	
	_material = object.GetComponent.<Renderer>().material;
	color.r = 1;
	color.b = 1;
	color.g = 1;	
}

function LateUpdate () 
{

	object.transform.localPosition = Vector3(      Random.Range(-amt, amt)  ,   Random.Range(-amt, amt)   ,   Random.Range(-amt, amt)   );

	var _alpha = Random.Range( 0,0.25);	
	_material.color.a = _alpha;
	
	var offset = Time.time * scrollSpeed;
	_material.mainTextureOffset = Vector2 (0,offset);
	
}