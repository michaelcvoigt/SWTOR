using UnityEngine;


public class TapToZoom : MonoBehaviour
{
	public ColoredCubeMazeFromImage MyCube;

	public void activateZoomed (bool _active)
	{

		if (MyCube) {


			MyCube.Load ();

		}
	}

}