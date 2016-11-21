using UnityEngine;
using UnityEngine.UI;


public class MovementController : MonoBehaviour
{

	public Transform universe;
	public GameObject galaxy;
	public GameObject cameras;
	public GvrHead _GvrHead;

	private float planetLerpTime = 1.5f;
	private Vector3 startPos;
	private Vector3 endPos;
	private Coroutine co;

	/*
	public void resolveIn( GameObject obj)
	{
		Vector3 objStartPos = obj.transform.position;
		Vector3 objEndPos = obj.transform.position * 0.01f;    //+ Vector3.ClampMagnitude(Vector3.zero, 100.0f);

		StartCoroutine(move (  objStartPos, objEndPos , galaxyLerpTime, obj )    );
	}
	*/

	public void Release (GameObject obj, Vector3 origPosition, GameObject target)
	{

		target.transform.parent.parent.parent = null;
		target.transform.parent.parent.SetParent (universe, true);

		GalaxyManager.instance.animating = false;
		StopCoroutine (co);
		_GvrHead.SetTargetNull ();

		startPos = obj.transform.localPosition;
		StartCoroutine (move (startPos, origPosition, planetLerpTime, obj, false, null));


		planetSpin _planetSpin = obj.GetComponent<planetSpin> ();

		if (_planetSpin != null) {

			_planetSpin.activateZoomed (false);

		}

	}

	public void Hold (GameObject obj, GameObject target)
	{


		startPos = obj.transform.localPosition;
		endPos = target.transform.position; //( startPos + target.transform.localPosition ) / 3.5f;

		co = StartCoroutine (move (startPos, endPos, planetLerpTime, obj, true, target));
	       
		planetSpin _planetSpin = target.GetComponent<planetSpin> ();

		if (_planetSpin != null) {

			_planetSpin.activateZoomed (true);


		} 

	}


	private System.Collections.IEnumerator move (Vector3 start, Vector3 end, float time, GameObject obj, bool setTarget, GameObject target)
	{
		GalaxyManager.instance.animating = true;
		float elapsedTime = 0;

		while (elapsedTime < time) {


			obj.transform.position = Vector3.Lerp (start, end, (elapsedTime / time));

			elapsedTime += Time.deltaTime;

			yield return new WaitForEndOfFrame ();


			if (setTarget && elapsedTime >= time) {
              
				target.transform.parent.parent.parent = null;
				//target.transform.parent.parent.SetParent ( obj.transform ,true);
				target.transform.parent.parent.parent = obj.transform;

				_GvrHead.SetTarget (obj.transform, target.transform.parent.parent.transform);
				GalaxyManager.instance.animating = false;
			}
		}
		GalaxyManager.instance.animating = false;

	}


	private System.Collections.IEnumerator scale (Vector3 start, Vector3 end, float time, GameObject obj)
	{
		GalaxyManager.instance.animating = true;
		float elapsedTime = 0;

		while (elapsedTime < time) {
			obj.transform.localScale = Vector3.Lerp (start, end, (elapsedTime / time));

			elapsedTime += Time.deltaTime;

			yield return new WaitForEndOfFrame ();

		}
		GalaxyManager.instance.animating = false;
	}



}
