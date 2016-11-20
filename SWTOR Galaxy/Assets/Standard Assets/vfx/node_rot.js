public var _speed : float = 0.25;
public var _amp : float = 0;

private var _startPos : Vector3;
private var _endPos : Vector3;
private var _animating : boolean = false;

function OnEnable()
{	
	_animating =false;
	_startPos = transform.localEulerAngles ;
}

function Update () 
{
		if( ! _animating)
		{
			_animating =true;
			_endPos = Vector3( Random.Range( -_amp  , _amp ),Random.Range( -_amp  , _amp ) , Random.Range( -_amp  , _amp ) );
			
			
			SmoothMove( _startPos , _endPos  , _speed );
		}
		else
		{
			_startPos = _endPos;
		}
}


function SmoothMove ( startpos , endpos , seconds : float) 
{ 
   var t = 0.0; 
   
   
   while (t <= 1.0) 
   { 
   	
     t += Time.deltaTime/seconds; 
     transform.localEulerAngles = Vector3.Lerp(startpos, endpos, Mathf.SmoothStep(0.0, 1.0, t)); 
     yield; 
       
   }
   
   	_animating =false;
   
}