private var nameText : String;
public var textMesh : TextMesh;

public function setName ( _name: String )
{	
	nameText = _name;
	textMesh.text  = nameText ;
	
}

public function UpdateScale( _scale : float)
{
	var scaleFactor =  0.1 + (_scale * 0.1);
	textMesh.transform.localScale = Vector3( scaleFactor, scaleFactor, scaleFactor);
}

