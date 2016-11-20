@MenuItem("Assets/Build AssetBundle From Selection - No dependency tracking")
static function ExportResourceNoTrack () {

    var path = Application.dataPath;
    
    
    if (path.Length != 0)
    {
 
//        BuildPipeline.BuildAssetBundle(Selection.activeObject, Selection.objects, path);
    }
}