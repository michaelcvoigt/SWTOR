public var nav_texture : Texture;
public var nav_ship_texture : Texture;
public var invisible_texture : Texture;
public var drag_knob : Texture;

public var navStyle : GUISkin;
//public var _galaxy_engine: galaxy_engine;
public var _xOffset : int;
public var _yOffset : int;

private var _active = false;
private var _zoomLevel : float;
private var navWindowRect : Rect;
private var dragWindowRect : Rect;
private var dragAreaRect : Rect;
private var hovered : boolean = false;
private var mdown : boolean = false;


function Start()
{
	resetWindowRects();
}

//function setEngine(_engine : galaxy_engine)
//{
//	_galaxy_engine = _engine;
//}

function activate()
{
	_active = true;
}

function deactivate()
{
	_active = false;
}

function OnGUI () 
{ 		
	if(_active)
	{
      		//var _window : windowObject = _galaxy_engine.getCurrentWindowsOpen();
      		
      		//if(!_window)
      		//{
      		
       		GUI.skin = navStyle;	
       		
/*       		if(_galaxy_engine.currentMode == 5 )
       		{
       			GUI.Box ( navWindowRect, nav_ship_texture );		
       		}
       		else
       		{
       			GUI.Box ( navWindowRect, nav_texture );	
       		}
  */     				
			checkHovered();		
			
			//zoom out
			if ( GUI.Button( Rect(48,131,36,25), invisible_texture) )
			{
				zoomOut();
			};
			
			//zoom in
			if ( GUI.Button( Rect(48,258,36,25), invisible_texture) )
			{
				zoomIn();	
			};
			
//			_zoomLevel = GUI.VerticalSlider (Rect(48,151,32,112),_zoomLevel, _galaxy_engine.getMinDistance() , _galaxy_engine.getMaxDistance());
			
	
	 	  if (dragAreaRect.Contains(Event.current.mousePosition))
          {
          	
           	 if (Event.current.type == EventType.MouseDown )
           	 {
                mdown=true; 
               
             }
             
             if (Event.current.type == EventType.MouseUp )
           	 {
                mdown=false; 
               
             }
                      
          }
          else
          {
          	mdown=false; 
          }
          
          if(mdown)
          {
          	 dragWindowRect = Rect(Event.current.mousePosition.x-13, Event.current.mousePosition.y-12.5, 26, 25);
              
          }
          //	GUI.Button (dragAreaRect,nav_texture);
          
        
        	GUI.Button (dragWindowRect,drag_knob);
        	
      		//}
	}
	
}

function zoomIn()
{
//	if( _zoomLevel <  _galaxy_engine.getMaxDistance() )
//	{
//		_zoomLevel++;
//	};
};

function zoomOut()
{
//	if( _zoomLevel >  _galaxy_engine.getMinDistance() )
//	{
//		_zoomLevel--;
//	};
};

function checkHovered()
{
	if( navWindowRect.Contains(Event.current.mousePosition )  ) 
    {
//    	_galaxy_engine.objectClicked = true;
    	hovered = true;
    }
    else
    {
    	mdown = false;
    	if(!Input.GetMouseButton(0))
    	{
   // 		_galaxy_engine.objectClicked = false;
    	}
    	hovered = false;
    }
}

function getHovered(): boolean
{
	return hovered;	
}

function Update()
{
	
	if(hovered)
	{
		dragDependingOnMode();
	}
	else
	{
		mountDependingOnMode();
		
	}
}

function resetWindowRects()
{
	dragAreaRect = Rect (  14, 25, 100 , 100);
	dragWindowRect = Rect (  0, 0, 26 , 25);
//	navWindowRect = Rect (  _galaxy_engine.guiXBuffer, _galaxy_engine.guiYBuffer, 128 , 300);
}

function setDragger(_x : float , _y : float)
{
	dragWindowRect = Rect (  _x + _xOffset, _y + _yOffset, 26 , 25);
		
}

function mountDependingOnMode()
{
/*
	var _adjX : float; 
	var _adjY : float;
	
	if(_galaxy_engine.currentMode == 5)
    {
    	var vector : Vector3 = _galaxy_engine._ships.getLastRotation();
    	
		_adjX =  - ((   (vector.y)   /4 ) - _xOffset)   ;
		_adjY =  - ((  (vector.x)   /4 ) - _yOffset)     ;
		
		dragWindowRect = Rect (  _adjX, _adjY, 26 , 25);
		
		
    }
    else
    {
    	_adjX =  _xOffset + ((	_galaxy_engine.getTargetX() * 50 ) / _galaxy_engine.worldLimit );
		_adjY =  _yOffset + ((	-_galaxy_engine.getTargetY() * 50 ) / _galaxy_engine.worldLimit );
			
			//print(_adjX);
			
		dragWindowRect = Rect (  _adjX, _adjY, 26 , 25);
		
    }
    
    _zoomLevel = _galaxy_engine.getDistance();

    */
}

function dragDependingOnMode()
{
/*
	var adjX : float; 
	var adjY : float;
	
	if(_galaxy_engine.currentMode == 5)
    {
    	adjX = Mathf.Clamp (  ((_xOffset - dragWindowRect.x) *4 )   ,-180,180) ;
		adjY = Mathf.Clamp (  ((_yOffset - dragWindowRect.y) *4 )   ,-180,180) ;	
		
		var _vector : Vector3 = Vector3(adjY,adjX,0);
		
		_galaxy_engine._ships.rotateShip(_vector);
		
    }
    else
    {	
    	if(mdown)
		{
    		adjX =  ((_xOffset - dragWindowRect.x) * _galaxy_engine.worldLimit ) / 62;
			adjY =  ((_yOffset - dragWindowRect.y) * _galaxy_engine.worldLimit ) / 62;
		
			//print(adjX);
		
			_galaxy_engine.targetUpdate( -adjX , adjY );
			
			
		}
		
	
		_galaxy_engine.setDistance(_zoomLevel);
		
    }
    
    */
}

