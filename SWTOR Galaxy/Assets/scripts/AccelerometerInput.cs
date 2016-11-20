using UnityEngine;
using System.Collections;


public class AccelerometerInput : MonoBehaviour 
{
	public GameObject cameraObject;

	void Update () 
	{
		

		if ( Input.GetButton("Fire1")  ) 
		{

			// tilt head up and down is Z
			// move camera X is towards and away
			//cameraObject.transform.Translate(Input.acceleration.z * 5.0f,0f,0f);

			// spin head right and left is x
			// move camera z is left and right

			// y didn't see to do anything
			// move camera y moves it up and down


			//cameraObject.transform.Translate(  Input.acceleration.z  * 2.0f  , 0f, -Input.acceleration.y * 2.0f );


			transform.Rotate( - Input.acceleration.z * 1.5f  , 0f, 0f );

			//Input.acceleration.x * 5.0f



		}


		//transform.Rotate(  0.2f  , -2.0f, 0f );



		//transform.Rotate(-Input.acceleration.z, Input.acceleration.y, 0f );
	}
}