public var _lineRenderer : LineRenderer;
public var _scale : float = 0.25;
public var _amp : float = 0.0125;

function Update()
{
	var _vector = Vector3(0,  Random.Range( -_amp  , _amp )  ,0);
	_lineRenderer.SetPosition (0,_vector);
	
	_vector = Vector3(_scale,Random.Range( -_amp  , _amp ),0);
	_lineRenderer.SetPosition (1,_vector);
	
	_vector = Vector3(_scale*2,Random.Range( -_amp  , _amp ),0);
	_lineRenderer.SetPosition (2,_vector);
	
	_vector = Vector3(_scale*3,Random.Range( -_amp  , _amp ),0);
	_lineRenderer.SetPosition (3,_vector);
	
	_vector = Vector3(_scale*4,Random.Range( -_amp  , _amp ),0);
	_lineRenderer.SetPosition (4,_vector);
	
	_vector = Vector3(_scale*5,Random.Range( -_amp  , _amp ),0);
	_lineRenderer.SetPosition (5,_vector);
	
	_vector = Vector3(_scale*6,Random.Range( -_amp  , _amp ),0);
	_lineRenderer.SetPosition (6,_vector);
	
	_vector = Vector3(_scale*7,Random.Range( -_amp  , _amp ),0);
	_lineRenderer.SetPosition (7,_vector);
	
	_vector = Vector3(_scale*8,Random.Range( -_amp  , _amp ),0);
	_lineRenderer.SetPosition (8,_vector);
	
	_vector = Vector3(_scale*9,Random.Range( -_amp  , _amp ),0);
	_lineRenderer.SetPosition (9,_vector);
}

