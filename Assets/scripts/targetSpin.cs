using UnityEngine;
using System.Collections;


public class targetSpin : MonoBehaviour
{
	public ColoredCubeMazeFromImage MyCube;
	public GameObject MyCubeGameobject;
	public string nameString = null;

	public GameObject[] GameObjectToHideWhenZoomed;
	private Vector3[] GameObjectToHideOrigScale;
	private Vector3 CubeOrigScale;
	private float lerpTime = 1.0f;
	private Coroutine c0;
	private Coroutine c1;

	public void Init ()
	{
		c0 = StartCoroutine(nothing());
		c1 = StartCoroutine(nothing());

		if (MyCube && MyCubeGameobject) {

			MyCube.SetImages (nameString);
			MyCubeGameobject.SetActive (false);
			CubeOrigScale = MyCube.transform.localScale;
			MyCube.Load ();

			if (GameObjectToHideWhenZoomed.Length > 0) {

				GameObjectToHideOrigScale = new Vector3[GameObjectToHideWhenZoomed.Length];
				for (int i = 0; i < GameObjectToHideWhenZoomed.Length; i++) {
					
					GameObjectToHideOrigScale [i] = GameObjectToHideWhenZoomed [i].transform.localScale;
				}
			}
		}

	}
	private System.Collections.IEnumerator nothing ()
	{
		yield return new WaitForEndOfFrame ();
	}

	public void activateZoomed (bool _active)
	{

	}

	public void activateZoomIn (bool active)
	{

			GalaxyManager.instance.animating = false;
			StopCoroutine (c0);
			StopCoroutine (c1);

			Vector3 scale0 = new Vector3 (0.1f, 0.1f, 0.1f);
			//Vector3 scale1 = new Vector3 (1.0f, 1.0f, 1.0f);
			MyCubeGameobject.SetActive (true);

			if (active) {

				//MyCube.Load ();

				MyCubeGameobject.transform.localScale = scale0;
				c0 = StartCoroutine (scale (scale0, CubeOrigScale, lerpTime, MyCubeGameobject, false));

				for (int i = 0; i < GameObjectToHideWhenZoomed.Length; i++) {
					GameObjectToHideWhenZoomed [i].SetActive (true);
					GameObjectToHideWhenZoomed [i].transform.localScale = GameObjectToHideOrigScale [i];
					c1 = StartCoroutine (scale (GameObjectToHideOrigScale [i], scale0, lerpTime, GameObjectToHideWhenZoomed [i], true));
				}

			} else {

		
				MyCubeGameobject.transform.localScale = CubeOrigScale;
				c0 = StartCoroutine (scale (CubeOrigScale, scale0, lerpTime, MyCubeGameobject, true));

				for (int i = 0; i < GameObjectToHideWhenZoomed.Length; i++) {
					GameObjectToHideWhenZoomed [i].SetActive (true);
					GameObjectToHideWhenZoomed [i].transform.localScale = scale0;
					c1 = StartCoroutine (scale (scale0, GameObjectToHideOrigScale [i], lerpTime, GameObjectToHideWhenZoomed [i], false));
				}
			}

	}



	private System.Collections.IEnumerator scale (Vector3 start, Vector3 end, float time, GameObject obj, bool hide)
	{
		GalaxyManager.instance.animating = true;
		float elapsedTime = 0;

		while (elapsedTime < time) {
			obj.transform.localScale = Vector3.Lerp (start, end, (elapsedTime / time));

			elapsedTime += Time.deltaTime;

			yield return new WaitForEndOfFrame ();


		}
	
		GalaxyManager.instance.animating = false;
		if (hide)
			obj.SetActive (false);
	}




}