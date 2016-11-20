public var _textMesh : TextMesh;
public var speed:float;

private var textArray  = new Array();

function Start()
{
	textArray[0] = "12343232 43 24 23 4234" + "\n" ;
	textArray[1] = "5678" + "\n" ;
	textArray[2] = "789100023012301" + "\n" ;
	textArray[3] = ".........." + "\n" ;
	textArray[4] = "12312321" + "\n" ;
	textArray[5] = "0129320320320203023..." + "\n" ;
	textArray[6] = "..010100101" + "\n" ;	
	textArray[7] = "12 43 " + "\n" ;
	textArray[8] = "5678" + "\n" ;
	textArray[9] = "789100023012301" + "\n" ;
	textArray[10] = "000" + "\n" ;
	textArray[11] = "11256..." + "\n" ;
	textArray[12] = "011..." + "\n" ;
	textArray[13] = "3833034.34234.2234" + "\n" ;


}

function Update () 
{
		
	if( Time.frameCount % speed == 0 )
	{
	
		var lastElement : String = textArray.Shift();
		textArray.Push(lastElement);
	
		var currentText : String;
	
		for(var i = 0 ; i < textArray.length ; ++i)
		{
			
	  		currentText = textArray.join("");
			
		}
		
		_textMesh.text = currentText;
	
	}

}
