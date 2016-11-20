using UnityEngine;
using UnityEngine.UI;

public class rotateItZ : MonoBehaviour {

	public float rotationSpeedZ = 0.0f; 
	public bool decay = false;
	public float decayRate = 0.0f; 

	void Update () 
	{ 
		if(decay)
		{
			rotationSpeedZ *= decayRate;
		}

		var rotationz = rotationSpeedZ; 
		rotationz *= Time.deltaTime; 


		transform.localEulerAngles = new Vector3(0,0,transform.localEulerAngles.z + rotationz);
	}

	void setRate(float _rate )
	{
		rotationSpeedZ = _rate;
	}

	void setRotation(float rotationz )
	{
		
		transform.localEulerAngles = new Vector3(0,0,transform.localEulerAngles.z + rotationz);
	}

}