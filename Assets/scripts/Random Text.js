public var object:GameObject;
public var speed:float;

function LateUpdate () 
{

if( Time.frameCount % speed == 0)
{

var currentText = "" + Random.Range(0, 10) + "" + Random.Range(0, 10) +"" + Random.Range(0, 10) + "" + Random.Range(0, 10) + "" + Random.Range(0, 10) + "" + Random.Range(0, 10) +"" + Random.Range(0, 10) + "" + Random.Range(0, 10);

//object.GetComponent (TextMesh).text = currentText + currentText + currentText;

}


}