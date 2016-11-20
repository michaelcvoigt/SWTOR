public var renderDepth = 0;

private var originalDepth;

function Start()
{
	doDepth();
}

function doDepth()
{	
	GetComponent.<Renderer>().material.renderQueue = renderDepth;
}

function resetDepth()
{
	if(originalDepth)
	{
		renderDepth = originalDepth;
	}
	doDepth();

}

function setDepth(_depth)
{
	originalDepth = renderDepth;
	renderDepth = _depth;
	doDepth();
}