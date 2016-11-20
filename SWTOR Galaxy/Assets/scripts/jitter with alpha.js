

public var object:GameObject;

public var alphaStart:float;
public var alphaEnd :float;

function LateUpdate () {

	object.transform.localPosition = Vector3(      Random.Range(-0.25, .25)  ,   Random.Range(-0.25, .25)   ,   Random.Range(-1, 1)   );
	object.GetComponent.<Renderer>().material.color.a = Random.Range(alphaStart, alphaEnd) ;

}
