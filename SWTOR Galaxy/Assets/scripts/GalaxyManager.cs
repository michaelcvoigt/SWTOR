using UnityEngine;
using UnityEngine.UI;
using VR = UnityEngine.VR;
using UnityStandardAssets.ImageEffects;

public class GalaxyManager : MonoBehaviour
{


	public Camera MainCamera;

	public Bloom myBloom;
	public DepthOfField myDepthOfField;

	public AudioListener MainAudioListener;

	public GameObject GvrMain;
	public ShootSpawner myShootSpawner;
	public data_en _data_en;
	public GameObject controllerPivot;

	public Transform theUniverse;

	public GameObject cursorOn;
	public GameObject uiOn;

	public GameObject cursorOff;
	public GameObject messageCanvas;


	public ControllerMoveOut activateOnTouch;

	public GameObject TutorialOverlay;
	public GameObject Cursors;

	private GameObject currentHitObject = null;

	private Renderer controllerCursorRenderer;

	// Currently selected GameObject.
	private GameObject selectedObject;

	// True if we are dragging the currently selected GameObject.
	private bool dragging;
	private bool holding = false;
	private GameObject heldObject;
	private Vector3 heldOrigPosition;
	private float screenHeightCheck;


	private int randomGenerationDiamater = 90;


	private bool booTutorialOpen = true;
	private bool booIntroClosed = false;


	void Start ()
	{

		screenHeightCheck = (Screen.currentResolution.height * 0.4f);


		// disable for tutorial to finish
		Cursors.SetActive (false);


	}


	public void CreatePlanets (int _count)
	{

		for (var i = 0; i < _count; ++i) {

		

			#if  UNITY_STANDALONE_WIN

			GameObject instance = Instantiate (Resources.Load ("PlanetOculus", typeof(GameObject))) as GameObject;
			#endif
			#if  UNITY_ANDROID  

				GameObject instance = Instantiate(Resources.Load("Planet", typeof(GameObject))) as GameObject;

			#endif

			planetSpin _planetSpin = instance.GetComponentInChildren<planetSpin> ();

			instance.transform.SetParent (theUniverse);
		
			string _video = _data_en.dataOtherVideo [i];

			_planetSpin.setTextures (_video, false);	
			_planetSpin.setName (_video);	


			instance.transform.position = Random.insideUnitSphere * randomGenerationDiamater;

			//activateOnTouch.resolveIn (instance);

		}
		theUniverse.gameObject.SetActive (false);


	}

	void closeIntro ()
	{

		booIntroClosed = true;
		TutorialOverlay.SetActive (false);

		myBloom.enabled = true;
		myDepthOfField.enabled = true;

		Cursors.SetActive (true);
		booTutorialOpen = false;
		theUniverse.gameObject.SetActive (true);
	}

	void Update ()
	{


		#if  UNITY_EDITOR

		if (Input.GetButton ("Left")) {

			GvrMain.transform.Rotate (0, -0.5f, 0);


		}

		if (Input.GetButton ("Right")) {

			GvrMain.transform.Rotate (0, 0.5f, 0);


		}

		if (Input.GetButton ("Up")) {

			GvrMain.transform.Rotate (0.5f, 0, 0);


		}

		if (Input.GetButton ("Down")) {

			GvrMain.transform.Rotate (-0.5f, 0, 0);


		}

		#endif

		#if  UNITY_STANDALONE_WIN

		bool inputTrue = false;

		//	print ( OVRInput.Get( OVRInput.Axis2D.Any  ) ) ;
		//	|| OVRInput.Get( OVRInput.Axis2D.Any  ) != Vector2.zero

		if (Input.GetButton ("Fire1") || Input.GetMouseButtonDown (0)) {

			inputTrue = true;
		}


		if (booTutorialOpen && inputTrue && !booIntroClosed) {
			closeIntro ();
			return;
		}


		if (inputTrue && currentHitObject && !holding) {

				
			hold (currentHitObject);
		

		}

		if (!inputTrue && holding) {

			release ();
		}





		#endif
		#if UNITY_IOS

		if (booTutorialOpen &&  Input.GetMouseButtonDown(0))
		{
			closeIntro();
			return;
		}

			if (Input.touchCount == 1 && currentHitObject && !holding ) {


				if (Input.touches[0].position.y < screenHeightCheck) {


						hold (currentHitObject);

				}



			}

			if ( Input.GetMouseButtonUp(0) && holding ) {

				Debug.Log( "released" );
				release ();

			}



		#endif
		#if UNITY_ANDROID

			if (booTutorialOpen) {

			if ( Input.GetButton ("Fire1")   ) {
					closeIntro ();
					return;
				}
				;
			}


			// for old cardboard 
			/*
			if (Input.touchCount == 1 && currentHitObject && !holding) {

				if (Input.touches [0].position.y < screenHeightCheck) {

					hold (currentHitObject);

				}
				;

			}
			;
			*/


			if (Input.GetButton ("Fire1") && currentHitObject && !holding) {

				hold (currentHitObject);
			}

			if (  !Input.GetButton ("Fire1")  && holding) {

				release ();

			}

		#endif

		/*
		if (heldObject) {

		
			//Quaternion headRotation = InputTracking.GetLocalRotation (VRNode.Head);

			Quaternion headRotation = Input.gyro.attitude;

			float x = Input.acceleration.x;
			float y = Input.acceleration.y;

			if(heldObject){


				heldObject.SendMessage("rotate", x  );

			}

		

			//MainAudioListener.enabled = true;

		} else {

			//MainAudioListener.enabled = false;

		}
		
        */

		UpdatePointer ();
	}


	//rotate the camera up and down(x rotation)
	private void RotateUpDown (float  axis)
	{
		transform.RotateAround (transform.position, transform.right, -axis * Time.deltaTime);
	}

	//rotate the camera rigt and left (y rotation)
	private void RotateRightLeft (float axis)
	{
		transform.RotateAround (transform.position, Vector3.up, -axis * Time.deltaTime);
	}

	private void release ()
	{

		holding = false;
		activateOnTouch.Release (GvrMain, heldOrigPosition, heldObject);

		if (heldObject) {
			heldObject.SendMessage ("activateZoomed", false);
		}
	}

	private	 void hold (GameObject holdObj)
	{

		holding = true;
		heldObject = holdObj;
		heldOrigPosition = Vector3.zero;  //holdObj.transform.position;
		activateOnTouch.Hold (GvrMain, holdObj);

	
		heldObject.SendMessage ("activateZoomed", true);


	}


	private void UpdatePointer ()
	{
	

		currentHitObject = myShootSpawner.GetCurrentGameObject ();
		SetSelectedObject (currentHitObject);

		

	}

	private void SetSelectedObject (GameObject obj)
	{


		if (holding) {
			Cursors.SetActive (false);
		} else {
			Cursors.SetActive (true);
		}
	
   
		if (obj) {

			cursorOn.SetActive (true);
			uiOn.SetActive (true);
			cursorOff.SetActive (false);  
		} else {

			cursorOn.SetActive (false);
			cursorOff.SetActive (true);
			uiOn.SetActive (false);
		}

		selectedObject = obj;


	}


}
