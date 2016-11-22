using UnityEngine;
using UnityEngine.UI;
using VR = UnityEngine.VR;
using UnityStandardAssets.ImageEffects;
using VacuumShaders.CurvedWorld;
using System.Collections;


// make planet maps

// look at ord -- doing something to make it more like a sphere
// maybe turn of depth of field?
// align all mazes for other objects
// make other maps

public class GalaxyManager : MonoBehaviour
{
	public static GalaxyManager instance;
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
	public MovementController activateOnTouch;
	public GameObject TutorialOverlay;
	public GameObject Loading;
	public GameObject Cursors;
	public bool holding = false;
	public bool zoomed = false;
	public bool animating = false;
	public CurvedWorld_Controller curvedWorld_Controller;

	private GameObject currentHitObject = null;
	private Renderer controllerCursorRenderer;

	// Currently selected GameObject.
	private GameObject selectedObject;
	private GameObject selectedZoomObject;
	// True if we are dragging the currently selected GameObject.
	private bool dragging;
	private GameObject heldObject;
	private Vector3 heldOrigPosition;
	private float screenHeightCheck;
	private int randomGenerationDiamater = 90;
	private bool booTutorialOpen = true;
	private bool booIntroClosed = false;

	private Vector3[] location;

	void Start ()
	{
		instance = this;
		screenHeightCheck = (Screen.currentResolution.height * 0.4f);

		// disable for tutorial to finish
		Cursors.SetActive (false);

		location = new Vector3[16];

		// Alderaan 
		location [0] = new Vector3 (-56.3f, 26.5f, -40.4f);
		// Balmorra 
		location [1] = new Vector3 (-11.3f, 31.7f, -37.3f);
		// Belsavis 
		location [2] = new Vector3 (25.3f, -4.0f, 71.9f);
		// Corellia 
		location [3] = new Vector3 (-3.7f, 35.0f, -79.8f);
		// Coruscant 
		location [4] = new Vector3 (24.7f, 39.6f, 28.3f);
		// Dromund_Kaas 
		location [5] = new Vector3 (-60.4f, 52.0f, 34.0f);
		// Hoth 
		location [6] = new Vector3 (53.9f, 45.2f, -48.0f);
		// Hutta 
		location [7] = new Vector3 (-13.8f, -64.1f, -35.3f);
		// Ilum 
		location [8] = new Vector3 (-2.5f, 57.6f, -43.8f);
		// Korriban 
		location [9] = new Vector3 (9.6f, 46.2f, -12.1f);
		// Nar_Shaddaa 
		location [10] = new Vector3 (10.1f, 46.0f, -63.6f);
		// Ord_Mantell 
		location [11] = new Vector3 (-16.9f, -50.7f, 30.4f);
		// Quesh 
		location [12] = new Vector3 (53.0f, -49.9f, -16.7f);
		// Taris 
		location [13] = new Vector3 (19.9f, -16.7f, 52.4f);
		// Tatooine 
		location [14] = new Vector3 (-37.0f, 15.0f, -35.6f);
		// Tython 
		location [15] = new Vector3 (25.5f, 16.7f, -6.9f);

	}


	public void CreatePlanets (int _count)
	{
		
		//string temp = "";

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

			instance.transform.position = location[i];
			//instance.transform.position = Random.insideUnitSphere * randomGenerationDiamater;

			_planetSpin.Init ();


			//temp = temp + "// " + _video + " \n location[" + i + "] = new Vector3" + instance.transform.position + ";\n ";
		}

		//print (temp);



		targetSpin[] targets = theUniverse.GetComponentsInChildren<targetSpin> ();

		for (int j = 0; j < targets.Length; ++j) {

				
			targets [j].Init ();

		}


		theUniverse.gameObject.SetActive (false);
	
		Loading.SetActive (false);

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

		UpdatePointer ();

		if ((Input.GetButtonDown ("Fire1") || Input.GetMouseButtonDown (0)) && !animating) {

			inputTrue = true;
		}


		if (booTutorialOpen && inputTrue && !booIntroClosed) {
			closeIntro ();
			UpdatePointer ();
			return;
		}


		if (inputTrue && currentHitObject && !holding) {

			hold (currentHitObject);
			UpdatePointer ();
			return;

		}


		// zoom further
		if (inputTrue && holding && !zoomed) {

			zoom ();
			UpdatePointer ();
			return;
		}

		if (inputTrue) {

			release ();
			UpdatePointer ();
			return;
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

		print ("release called zoomed  = " + zoomed);
		print ("release called animating  = " + animating);
		print ("release called holding  = " + holding);

		if (heldObject) {
			activateOnTouch.Release (GvrMain, heldOrigPosition, heldObject);
			heldObject.SendMessage ("activateZoomed", false);

			if (zoomed)
				heldObject.SendMessage ("activateZoomIn", false);

		}


		holding = false;
		zoomed = false;
	}

	private	 void zoom ()
	{
		print ("heldObject = " + heldObject);
	
		zoomed = true;

		curvedWorld_Controller.pivotPoint = heldObject.transform;

		heldObject.SendMessage ("activateZoomIn", true);

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

		if (currentHitObject) {

			SetSelectedObject (currentHitObject);

		}

		UpdateCursors (currentHitObject);
	}

	private void SetSelectedObject (GameObject obj)
	{
		
		selectedObject = obj;
	}

	private void UpdateCursors (GameObject obj)
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

	}


}
