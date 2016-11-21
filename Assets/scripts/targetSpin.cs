using UnityEngine;


public class targetSpin : MonoBehaviour
{
	public ColoredCubeMazeFromImage MyCube;
	public GameObject MyCubeGameobject;
	public string mazeImage = null;
	public string colorImage = null;
	public GameObject[] GameObjectToHideWhenZoomed;

	private float lerpTime = 1.0f;
	private Coroutine c0 = null;
	private Coroutine c1 = null;

	public void Start ()
	{

		if (MyCube && MyCubeGameobject) {

				MyCube.SetImages (mazeImage,colorImage);
				MyCubeGameobject.SetActive (false);

		}
	}

	public void activateZoomed (bool _active)
	{

	}

	public void activateZoomIn (bool active)
	{

		//if (c0)
		//StopCoroutine (c0);
		//if (c1)
		//StopCoroutine (c1);

		Vector3 scale0 = new Vector3 (0.1f, 0.1f, 0.1f);
		Vector3 scale1 = new Vector3 (1.0f, 1.0f, 1.0f);
		MyCubeGameobject.SetActive (true);

		if (active) {


			MyCube.Load ();

			MyCubeGameobject.transform.localScale = scale0;
			c0 = StartCoroutine (scale (scale0, scale1, lerpTime, MyCubeGameobject,false));

			for (int i = 0; i < GameObjectToHideWhenZoomed.Length; i++) {
				GameObjectToHideWhenZoomed[i].SetActive(true);
				GameObjectToHideWhenZoomed[i].transform.localScale = scale1;
				c1 = StartCoroutine (scale (scale1, scale0, lerpTime, GameObjectToHideWhenZoomed [i],true));
			}

		} else {


			MyCubeGameobject.transform.localScale = scale1;
			c0 = StartCoroutine (scale (scale1, scale0, lerpTime, MyCubeGameobject,true));

			for (int i = 0; i < GameObjectToHideWhenZoomed.Length; i++) {
				GameObjectToHideWhenZoomed[i].SetActive(true);
				GameObjectToHideWhenZoomed[i].transform.localScale = scale0;
				c1 = StartCoroutine (scale (scale0, scale1, lerpTime, GameObjectToHideWhenZoomed [i],false));
			}
		}
	}



	private System.Collections.IEnumerator scale (Vector3 start, Vector3 end, float time, GameObject obj, bool hide)
	{
		float elapsedTime = 0;

		while (elapsedTime < time) {
			obj.transform.localScale = Vector3.Lerp (start, end, (elapsedTime / time));

			elapsedTime += Time.deltaTime;

			yield return new WaitForEndOfFrame ();


		}


			if(hide)
			obj.SetActive(false);
	}




}