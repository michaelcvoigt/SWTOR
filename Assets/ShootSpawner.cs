using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class ShootSpawner : MonoBehaviour {


	RaycastHit hit;
	GameObject hitObject;


	// Use this for initialization
	void Start () {
	
	}
	
	void Update()
	{

	  hitObject = null;

		var rot = InputTracking.GetLocalPosition (VRNode.Head);

		if (Physics.Raycast( rot , transform.forward, out hit, 10000))
		{
			hitObject = hit.collider.gameObject;

		}

	} 


	public GameObject GetCurrentGameObject() {


		if (hitObject != null ) {
			
			return hitObject;
		}

		return null;
	}


}
