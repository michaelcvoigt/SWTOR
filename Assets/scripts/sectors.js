public var sectorGrid_lineRenderer : LineRenderer;
public var _miscFunctions : miscFunctions; 
public var _transform : Transform;

private var _lineRenderer : LineRenderer;

function Start()
{
	_lineRenderer = _miscFunctions.drawGrid(sectorGrid_lineRenderer , .39	, 23, 23, -4.3,-4.925 + 0.05, _transform);	
	
var 	_width = 0.0055;
	_lineRenderer.SetWidth(_width,_width);
}

function UpdateScale(_percent : float)
{
	var _width : float =    0.005 + (_percent * .05 );
	_width = 0.0055;

	_lineRenderer.SetWidth(_width,_width);
		
}

