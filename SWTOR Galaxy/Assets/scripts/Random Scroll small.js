public var _textMesh : TextMesh;
public var speed:float;

private var textArray  = new Array();

function Start()
{
	textArray[0] = "0" + "\n" ;
	textArray[1] = "1" + "\n" ;
	textArray[2] = "1" + "\n" ;
	textArray[3] = "0" + "\n" ;
	textArray[4] = "1" + "\n" ;
	textArray[5] = "1" + "\n" ;
	textArray[6] = "1" + "\n" ;	
	textArray[7] = "0" + "\n" ;
	textArray[8] = "0" + "\n" ;
	textArray[9] = "01" + "\n" ;
	textArray[10] = "000" + "\n" ;
	textArray[11] = "1" + "\n" ;
	textArray[12] = "1" + "\n" ;
	textArray[13] = " " + "\n" ;


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
