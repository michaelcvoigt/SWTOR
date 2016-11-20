import System.Text.RegularExpressions;

public var _www : WWW;
public var _wwwLang : WWW;


private var _keys = new Array();  
private var _currentLang : int = 0;
private var _ready : boolean = false;

function Start()
{
	Debug.Log("start " );

	if(_currentLang == 0)
	{
		doEn();
	}
}

function doEn()
{
	var _lang : String;
	
	#if UNITY_EDITOR
		_wwwLang  = WWW("http://localhost/lang.txt");
	#else
		_wwwLang = WWW("lang.txt");
	#endif
	
	yield _wwwLang;
	_lang = _wwwLang.text;
	var langLine : Array = Regex.Split(_lang,"\\n");
	
	var levelText : String;
	
	#if UNITY_EDITOR
		_www = WWW("http://localhost/" + langLine[0] + ".txt");
	#else
		_www = WWW(langLine[0] + ".txt");
	#endif
	
    // Wait for download to complete
    yield _www;
    
   levelText = _www.text;
   
    
	var keyLines : Array = Regex.Split(levelText,"\\n");
	
   _ready = true;
	

	for(var i = 0 ; i < keyLines.length ; ++i)
	{
		
		keyLines[i] = Regex.Replace(keyLines[i],"<br/>","\n");		
		_keys[ i ] = keyLines[i]; 
		
	}
		
};

function getKey(_index : int) : String
{
	if(!_ready)
	{
		return "";
	}
	
	var _string  = _keys[ _index ];	

	return _string;	
};