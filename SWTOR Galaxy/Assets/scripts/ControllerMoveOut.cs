using UnityEngine;
using UnityEngine.UI;


public class ControllerMoveOut : MonoBehaviour {

	public Transform universe;
	public GameObject galaxy;
	public GameObject cameras;
	public GvrHead _GvrHead;


	float planetLerpTime = 1.5f;


	Vector3 startPos;
	Vector3 endPos;

	Coroutine co;
	Coroutine coGalaxy;


	void Start ()
	{
		/*
		Vector3 startPosGalaxy = new Vector3(100.0f, 100.0f, 100.0f);
		Vector3 endPosGalaxy = new Vector3(1f, 1f, 1f);
		coGalaxy = StartCoroutine(scale (  startPosGalaxy, endPosGalaxy , galaxyLerpTime, galaxy )    );

		Vector3 objStartPos = new Vector3(0f, 100.0f, 0f);
		Vector3 objEndPos = new Vector3(0f, 0f, 0f);
		*/

		//StartCoroutine(move (  objStartPos, objEndPos , galaxyLerpTime, cameras, 0f )    );


	}


	/*
	public void resolveIn( GameObject obj)
	{
		Vector3 objStartPos = obj.transform.position;
		Vector3 objEndPos = obj.transform.position * 0.01f;    //+ Vector3.ClampMagnitude(Vector3.zero, 100.0f);

		StartCoroutine(move (  objStartPos, objEndPos , galaxyLerpTime, obj )    );
	}
	*/

	public void Release( GameObject obj, Vector3 origPosition, GameObject target)
	{

		target.transform.parent.parent.parent = null;
		target.transform.parent.parent.SetParent (universe, true);

		StopCoroutine ( co   );
		_GvrHead.SetTargetNull ( );


			//StopCoroutine ( coGalaxy );
			startPos = obj.transform.localPosition;
			StartCoroutine (move (startPos, origPosition, planetLerpTime, obj, false,null));


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


  private System.Collections.IEnumerator move(Vector3 start, Vector3 end, float time, GameObject obj, bool setTarget, GameObject target)
	{

		float elapsedTime = 0;

		while (elapsedTime < time)
		{


					obj.transform.position = Vector3.Lerp(start, end, (elapsedTime / time));

			elapsedTime += Time.deltaTime;

			yield return new WaitForEndOfFrame();



			if (setTarget &&  elapsedTime >= time ) {
              
          target.transform.parent.parent.parent = null;
				//target.transform.parent.parent.SetParent ( obj.transform ,true);
		      target.transform.parent.parent.parent = obj.transform;

				
				_GvrHead.SetTarget (obj.transform, target.transform.parent.parent.transform );

			}
		}

	}


	private System.Collections.IEnumerator scale(Vector3 start, Vector3 end, float time, GameObject obj)
	{

		float elapsedTime = 0;

		while (elapsedTime < time)
		{
			obj.transform.localScale = Vector3.Lerp(start, end, (elapsedTime / time));

			elapsedTime += Time.deltaTime;

			yield return new WaitForEndOfFrame();

		}
	}



}
