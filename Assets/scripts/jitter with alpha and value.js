public var object:GameObject;
public var alphaStart:float;
public var alphaEnd :float;
public var amt:float;

function LateUpdate () {

	object.transform.localPosition = Vector3(      Random.Range(-  amt,  amt)  ,   Random.Range(- amt,  amt)   ,   Random.Range(- amt,  amt)   );
	object.GetComponent.<Renderer>().material.color.a = Random.Range(alphaStart, alphaEnd) ;

}
