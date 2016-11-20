using UnityEngine;
using UnityEngine.UI;

public class rotateItX : MonoBehaviour {

public float rotationSpeedX = 0.0f; 
public bool decay = false;
public float decayRate = 0.0f; 

void Update () 
{ 
	if(decay)
	{
		rotationSpeedX *= decayRate;
	}
	
	var rotationx = rotationSpeedX; 
	rotationx *= Time.deltaTime; 

		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + rotationx,0,0);
}

void setRate(float _rate )
{
	rotationSpeedX = _rate;
}

	void setRotation(float rotationx )
{


		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + rotationx,0,0);
}

}