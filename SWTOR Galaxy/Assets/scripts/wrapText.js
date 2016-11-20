// Word Wrap v1.0 for Unity 3D Text Objects
// 
// Author: Michael Colin Voigt
// http://3037.com
// Free for all purposes, if you use it, just email me at info@3037.com

public var textObject: TextMesh;
public var wrapPoint = 0;
private var currentText:String;
public var hyphen = true;
private var numberOfLines : int = 0;

function setText(_currentText:String)
{
	
	numberOfLines = 0;
	currentText = _currentText;
	render();
};

function getNumberOfLines(): int
{
	return numberOfLines;	
}

function render () 
{

	currentText = " " + currentText;
	
	var finalString:String ="";

	var currentWrap = wrapPoint;
	var count = 0;
	var startPoint = 0;
	var lastBlankSpace = 0;
	var currentLength = 0;
	var appendText:String = "";

	while( count <= currentText.Length  )
	{

		count++;
	
		if( count   >= currentText.Length)
		{
				var finalLength = currentText.Length - startPoint;
				finalString +=  currentText.Substring( startPoint+1 , finalLength-1 );
				break;
		}
	
		if( currentText[count] == " " )
		{
			lastBlankSpace = count;
		}
	
		if( currentText[count] == " " && count >= currentWrap )
		{
	
			currentLength = count - startPoint;
		
			appendText = currentText.Substring( startPoint+1 , currentLength ) + "\n" ;
			numberOfLines++;
			finalString += appendText;
		
			currentWrap = count + wrapPoint;
			startPoint = count;
	
		}
		
		if( currentText[count] != " " && count >= currentWrap )
		{
			
			for(var i = count; i > startPoint;i--)
			{
				
				
				if( currentText[i] == " " ) 
				{
					

					currentLength = i - startPoint;
		
					appendText = currentText.Substring( startPoint+1 , currentLength ) + "\n" ;
					numberOfLines++;
					finalString += appendText;
		
					currentWrap = i + wrapPoint;
					startPoint = i;
	
				}
				
			}
		}
		
		
		if(hyphen)
		{
			var worldLength = (count - lastBlankSpace);
	
			if(  worldLength  >    wrapPoint )
			{
				currentLength = count - startPoint;
		
				appendText = currentText.Substring( startPoint+1 , currentLength ) + "-\n" ;
				numberOfLines++;
				finalString += appendText;
		
				currentWrap = count + wrapPoint;
				startPoint = count;	
				lastBlankSpace = count;	
			}
		}
	}



textObject.text = finalString;

}