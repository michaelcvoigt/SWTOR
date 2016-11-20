using UnityEngine;
using UnityEngine.UI;

public class rotateItY : MonoBehaviour {

	public float rotationSpeedY = 0.0f; 
	public bool decay = false;
	public float decayRate = 0.0f; 

	void Update () 
	{ 
		if(decay)
		{
			rotationSpeedY *= decayRate;
		}

		var rotationy = rotationSpeedY; 
		rotationy *= Time.deltaTime; 

		transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + rotationy,0);
	}

	void setRate(float _rate )
	{
		rotationSpeedY = _rate;
	}

	void setRotation(float rotationy )
	{

		transform.localEulerAngles = new Vector3(0,transform.localEulerAngles.y + rotationy,0);
	}

}