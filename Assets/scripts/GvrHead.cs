using UnityEngine;
using VR = UnityEngine.VR;
using System.Collections;
using UnityEngine.VR;
using UnityEngine.SceneManagement;



public class GvrHead : MonoBehaviour
{
 

	public Transform targetPoint;
	public Transform target;
	//public OVRCameraRig rig;

	private Transform objectToRotate;
	private Vector3 startPos0;
	private Vector3 endPos1;
	private Vector3 startPos1;
	private Vector3 endPos0;
	private Quaternion startRot0;
	private Quaternion endRot0;
	private Quaternion startRot1;
	private Quaternion endRot1;
	private Coroutine cr0;
	private Coroutine cr1;
	private float lerpTime = 0.15f;

	private bool updated;
	public bool updateEarly = false;

	private Vector3 objectToRotateOrigPosition = new Vector3 (0, 0, 0);
	private Quaternion objectToRotateOrigRot = new Quaternion (0, 0, 0, 0);
	private Transform lastObjectToRotate = null;

	private bool headCentered = false;
	private bool isPaused = false;

	void Update ()
	{

	  /*
		if (!headCentered && OVRPlugin.userPresent) {

			VR.InputTracking.Recenter ();
			headCentered = true;
		}
		*/

		if (Input.GetKey (KeyCode.Escape)) {

			Application.Quit ();
		}


		/*
		if (!OVRPlugin.userPresent) {

			Time.timeScale = 0.0f;
			VR.InputTracking.Recenter ();

		} else {

			Time.timeScale = 1.0f;

		}
		*/

		updated = false;  // OK to recompute head pose.
		if (updateEarly) {
			UpdateHead ();
		}
	}

	// Normally, update head pose now.
	void LateUpdate ()
	{
		UpdateHead ();
	}

	void OnApplicationFocus( bool hasFocus )
	{
		isPaused = !hasFocus;
	}

	void OnApplicationPause( bool pauseStatus )
	{
		isPaused = pauseStatus;
	}

	// Compute new head pose.
	private void UpdateHead ()
	{

		if (updated  || isPaused ) {  // Only one update per frame, please.
			return;
		}

		Quaternion q = InputTracking.GetLocalRotation (VRNode.Head);

		//float rotX = (q.eulerAngles.x * 3.5f);
		//float rotY = (q.eulerAngles.y * 3.5f);
		//float rotZ = (q.eulerAngles.z * 3.5f);

		//float posX = (q.x *30.0f);
		//float posY = 0; //(q.y * 10.0f);				
		//float posZ = 0; //(q.z * 10.0f);			

		/*
								Vector3 headPosition = InputTracking.GetLocalPosition (VRNode.Head);

		float headX = headPosition.x / 100;
		float headY = headPosition.y / 100;
		float headZ = headPosition.z / 100;

								transform.position = new Vector3 ( transform.position.x +  headX,transform.position.y + headY, transform.position.z + headZ );
*/
							
	
		if (target == null) {


			if (cr0 != null) {
				StopCoroutine (cr0);
			}
			if (cr1 != null) {
				StopCoroutine (cr1);
			}

			if (lastObjectToRotate) {


				//Vector3 newPos = new Vector3( objectToRotateOrigPosition.x +  posX, objectToRotateOrigPosition.y + posY , objectToRotateOrigPosition.z + posZ );

				//startPos0 = newPos;
				//endPos0 = objectToRotateOrigPosition;

				//cr1 = StartCoroutine (move (startPos0, endPos0, lerpTime, target));


				//Quaternion newRot = new Quaternion (0, 0, 0, 0); //Quaternion newRot = transform.localRotation;
				//newRot.eulerAngles = new Vector3 (objectToRotateOrigRot.x + rotX, objectToRotateOrigRot.y + rotY, objectToRotateOrigRot.z + rotZ);

				startRot0 = lastObjectToRotate.transform.rotation; //newRot;
				endRot0 = objectToRotateOrigRot;

				cr1 = StartCoroutine (rotate (startRot0, endRot0, lerpTime, lastObjectToRotate));

				lastObjectToRotate = null;

			}

		} else {

			if (objectToRotate != lastObjectToRotate) {


				objectToRotateOrigRot = objectToRotate.transform.rotation;
				//objectToRotateOrigPosition  = target.transform.localPosition;
			}

			if (cr0 != null) {
				StopCoroutine (cr0);
			}
			if (cr1 != null) {
				StopCoroutine (cr1);
			}
					

			lastObjectToRotate = objectToRotate;

			//Vector3 newPos = new Vector3( objectToRotateOrigPosition.x +  posX, objectToRotateOrigPosition.y + posY , objectToRotateOrigPosition.z + posZ );

			//startPos1 = target.transform.position;
			//endPos1 = newPos; 

			//cr0 = StartCoroutine (move (startPos1, endPos1, lerpTime, target));


			//Quaternion newRot = new Quaternion (0, 0, 0, 0);   //objectToRotate.transform.localRotation;
			Vector3 origEulerRotation = new Vector3 (objectToRotateOrigRot.eulerAngles.x, objectToRotateOrigRot.eulerAngles.y, objectToRotateOrigRot.eulerAngles.z);
			//newRot.eulerAngles = new Vector3 (origEulerRotation.x + rotX, origEulerRotation.y + rotY, origEulerRotation.z + rotZ);

			startRot1 = objectToRotate.transform.localRotation;
			endRot1 = Quaternion.Inverse( q );  //newRot

			cr1 = StartCoroutine (rotate (startRot1, endRot1, lerpTime, objectToRotate.transform));


		}
	

	}


	public void SetTarget (Transform _target, Transform _objectToRotate)
	{

		objectToRotate = _objectToRotate;
		target = _target;


			
	}

	public void SetTargetNull ()
	{
				
		objectToRotate = null;
		target = null;
	}

	private System.Collections.IEnumerator rotate (Quaternion start, Quaternion end, float time, Transform obj)
	{

		float elapsedTime = 0;

		while (elapsedTime < time) {
			obj.rotation = Quaternion.Lerp (start, end, (elapsedTime / time));

			elapsedTime += Time.deltaTime;

			yield return new WaitForEndOfFrame ();


		}

	}


	private System.Collections.IEnumerator move (Vector3 start, Vector3 end, float time, Transform obj)
	{

		float elapsedTime = 0;

		while (elapsedTime < time) {
			obj.localPosition = Vector3.Lerp (start, end, (elapsedTime / time));

			elapsedTime += Time.deltaTime;

			yield return new WaitForEndOfFrame ();


		}

	}

}


