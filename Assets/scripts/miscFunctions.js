//var _galaxy_engine: galaxy_engine;


//function setGalaxyEngine(_engine : galaxy_engine)
//{
//	_galaxy_engine = _engine;
//}


function SmoothScale ( object : Transform , startFadeTime : float , fadeTime : float , startPosition : Vector3 , endPosition : Vector3 ) 
{ 
   var t = 0.0; 

   while (t <= 1.0) 
   { 
   	
   	
      t += Time.deltaTime/fadeTime; 
      object.localScale = Vector3.Lerp(startPosition, endPosition, Mathf.SmoothStep(0.0, 1.0, t)); 
    
     if( t >= 1 )
   	 {
   		object.localScale = endPosition;
   		break;
 
   	 }
     
    yield; 
     
   }
   
  
}

function SmoothMoveLocal ( object : Transform , startFadeTime : float , fadeTime : float , startPosition : Vector3 , endPosition : Vector3 ) 
{ 
   var t = 0.0; 

   while (t <= 1.0) 
   { 
      t += Time.deltaTime/fadeTime; 
      object.localPosition = Vector3.Lerp(startPosition, endPosition, Mathf.SmoothStep(0.0, 1.0, t)); 
    
     if( t >= 1 )
   	 {
   		object.localPosition = endPosition;
   		break;
   	 }
     
     yield; 
     
   }  
}

function SmoothRotate ( object : Transform , startFadeTime : float , fadeTime : float , startPosition : Vector3 , endPosition : Vector3 ) 
{ 
   var t = 0.0; 

   while (t <= 1.0) 
   { 
   	
   	
   	
      t += Time.deltaTime/fadeTime; 
      object.localEulerAngles = Vector3.Lerp(startPosition, endPosition, Mathf.SmoothStep(0.0, 1.0, t)); 
    
     if( t >= 1 )
   	 {
   		object.localEulerAngles = endPosition;
   		break;
 
   	 }
     
     yield; 
     
   }
   
}

function SmoothMove ( object : Transform , startFadeTime : float , fadeTime : float , startPosition : Vector3 , endPosition : Vector3 ) 
{ 
   var t = 0.0; 

   while (t <= 1.0) 
   { 
   	
   	
   	
      t += Time.deltaTime/fadeTime; 
      object.position = Vector3.Lerp(startPosition, endPosition, Mathf.SmoothStep(0.0, 1.0, t)); 
    
     if( t >= 1 )
   	 {
   		object.position = endPosition;
   		break;
 
   	 }
     
     yield; 
     
   }
   
}

function SmoothLerp ( object : Object  , startFadeTime : float, fadeTime : float , startValue : float , endValue : float, updateFunction : String ) 
{ 
   var t = 0.0; 

   while (t <= 1.0) 
   { 	
      t += Time.deltaTime/fadeTime; 
      object = Mathf.Lerp(startValue, endValue, Mathf.SmoothStep(0.0, 1.0, t)); 
	
   	if(updateFunction)
   	{
//   		_galaxy_engine.SendMessage(updateFunction,object);	
   	}
      
    
     if( t >= 1 )
   	 {
   		object = endValue;
   		break;
 
   	 }
     
     yield;  
   } 
}

function magicTrigFunctionX (pointRatio) : float
{
//    return Mathf.Cos(pointRatio*2*Mathf.PI);
}

function magicTrigFunctionY (pointRatio) : float
{
//    return Mathf.Sin(pointRatio*2*Mathf.PI);
}

function drawCircle(_lineRenderer : LineRenderer, radius : float , segments : float) 
{

	_lineRenderer.SetVertexCount(segments+2);

     var _vector = Vector3(radius,0,0);
    _lineRenderer.SetPosition (0,_vector);
    
    
   for (var i=0; i <= segments; i++) 
   {
      	var pointRatio : float = i / segments;
        var xSteps = magicTrigFunctionX(pointRatio);
        var ySteps = magicTrigFunctionY(pointRatio);
        var pointX =  xSteps * radius;
        var pointY =  ySteps * radius;
 
 		
  	 _vector = Vector3(pointX,0,pointY);
   	_lineRenderer.SetPosition (i+ 1,_vector);
 
   }
   
   
}

function drawGrid(_lineRenderer : LineRenderer, gridSize : float , _segmentsX : int, _segmentsY : int, _x : float , _y : float, _parent : Transform ) : LineRenderer
{
	var pos = Vector3 (0  , 0 , 0 ); 
	
	
	
	var lineRenderer : LineRenderer = Instantiate ( _lineRenderer, pos, Quaternion.identity);
	lineRenderer.transform.parent = _parent; 
	var totalLines : int = (_segmentsX * _segmentsY) * 3;
	lineRenderer.SetVertexCount( totalLines+1);
	
			
	var offset : int = 0;
	for(var i = 0; i < _segmentsX; ++i)
	{
		
		for(var j = 0 ; j < _segmentsY; ++j)
		{
			
			drawBox(lineRenderer, gridSize , (i* gridSize) + _x, (j* gridSize) + _y, offset  );	
			offset = offset +3;
		}
		
	}
	
	var maxX : float = _x + (_segmentsX*gridSize);
	var maxY : float = _y + (_segmentsY*gridSize);
	
var	_vector = Vector3(maxX,0,maxY);
	lineRenderer.SetPosition (totalLines-2,_vector);	

	_vector = Vector3(_x,0,maxY);
	lineRenderer.SetPosition (totalLines-1,_vector);

	_vector = Vector3(_x,0,_y);
	lineRenderer.SetPosition (totalLines,_vector);	
	
	return lineRenderer;
}

function drawBox(_lineRenderer : LineRenderer, boxSize : float , _X : float, _Y : float, offset : int) 
{

  	var _vector = Vector3(_X,0,_Y);
  	
   	_lineRenderer.SetPosition (offset,_vector);
   	
   	_vector = Vector3(_X+ boxSize,0,_Y);
   	_lineRenderer.SetPosition (offset+1,_vector);
 	
 	_vector = Vector3(_X+ boxSize,0,_Y+boxSize);
   	_lineRenderer.SetPosition (offset+2,_vector);
   	
}



