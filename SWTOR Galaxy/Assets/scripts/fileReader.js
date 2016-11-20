import System.Text.RegularExpressions; 
import System.IO;

private var currentPlanet;
private var resx;
private var resy;

private var location: String;

function Awake() 
{
 	
	//var line = fileParse();
	//var parts:String[] = line.Split(":"[0]); 
	
    currentPlanet = 1; //parseInt(parts[0]);
    resx = 1024; //parseInt(parts[1]);
    resy = 768; //parseInt(parts[2]);
	
}



function getCurrentPlanet()
{
	return currentPlanet;	
}

function getResx()
{
	return resx;	
}

function getResy()
{
	return resy;	
}

function fileParse()
{
	
   var line : String = ""; 
	 
   try { 
   	
   	var directoryInfo = new DirectoryInfo(Application.dataPath + "/" );
   	
   	directoryInfo = directoryInfo.Parent;
   	directoryInfo = directoryInfo.Parent;
    location = directoryInfo.FullName;
   	
      var sr : StreamReader = new StreamReader ( location + "/input.txt"  );
       
      line = sr.ReadLine(); 
      
         while (line != null) { 
         	
        	
         		var curLine: String = line;
         	
      		   line = sr.ReadLine(); 
        
         } 
         
         
      sr.Close(); 
     
   } 
   catch (e) { 
      print ( "Error: " + e  ); 
   } 
   
   
  return curLine; 
		
};
