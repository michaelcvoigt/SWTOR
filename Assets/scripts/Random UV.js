public var object:GameObject;
public var speed:float;

function LateUpdate () 
{

if( Time.frameCount % speed == 0)
{

	var randomU =  Random.Range(-50, 50);
	var randomV =  Random.Range(-50, 50);

	var scaleX = Mathf.Cos( Time.time ) * -0.5 +1;
	var scaleY = Mathf.Sin( Time.time ) * -0.5 +1;

 	//Debug.Log( randomU );

	//object.renderer.material.mainTextureOffset = Vector2 (randomU,randomV);
	object.GetComponent.<Renderer>().material.mainTextureScale = Vector2 (randomU,randomV);

}


}