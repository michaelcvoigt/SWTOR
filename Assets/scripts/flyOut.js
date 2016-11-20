public var _gameObject : GameObject;

//public var _galaxy_engine: galaxy_engine;
public var callBackObject : GameObject;

public var solarStyle : GUISkin;
public var info_texture : Texture;

private var selectedObject : Transform;
private var objectClicked : boolean = false;
private var infoPanelRect : Rect;
private var selectedName : String;
public var _active : boolean = false;
private var windowIndex : int;
private var index : int;

function setCallBackObject(_callBackObject : GameObject )
{
	callBackObject = _callBackObject;
	
}

//function setGalaxyEngine(_engine : galaxy_engine)
//{
//	_galaxy_engine = _engine;
//}

function destroy()
{	

	Destroy(_gameObject);
}

function LateUpdate()
{	
	if(_active)
	{	 
		
		var viewPos : Vector3 = Camera.main.WorldToScreenPoint (selectedObject.position);
//		infoPanelRect = Rect( viewPos.x - 23 , _galaxy_engine.ScreenHeight  - viewPos.y - 55 , 0 , 0 );	
		
	}	  
}


function awake(_index : int ,  _selectedObject : Transform , _selectedName : String, _windowIndex : int )
{
	index = _index;
	windowIndex = _windowIndex;
	selectedObject = _selectedObject;
	selectedName = _selectedName;
	_active = true;
}

function sleep()
{
	selectedName = "";
	_active = false;
}


function OnGUI () 
{

	if(_active)
	{
		GUI.skin = solarStyle;
		infoPanelRect = GUILayout.Window ( windowIndex , infoPanelRect, infoPanelGUI, "" );	
		
				
	}
	
}

function fireEvent () 
{
	if(callBackObject)
	{
		callBackObject.BroadcastMessage("attemptClickFromIndex", index);
	}
}

function infoPanelGUI(windowID : int)
{
	
	GUILayout.BeginHorizontal();

	if (GUILayout.Button (selectedName, GUILayout.Height (32) ) )
	fireEvent();
	
	GUILayout.EndHorizontal();
}






