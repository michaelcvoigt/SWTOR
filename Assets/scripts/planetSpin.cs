using UnityEngine;
using UnityEngine.UI;

public class planetSpin : MonoBehaviour
{

	public GameObject parent;
	public Renderer diffuse;
	public Renderer clouds;
	public GameObject corona;
	public GameObject ring;
	public GameObject nameTextGameObject;
	public GameObject spinner;

	private string nameText;
	private float offset;
	private float offset2;
	private Texture diffuseTexture;
	private Texture cloudTexture;
	private Texture coronaTexture;
	private Texture ringTexture;


	public void setTextures (string _name, bool _ring)
	{


		string strImage = _name + "_diffuse";	

		//diffuseTexture = Resources.Load(strImage) as Texture;	

		diffuse.materials [0].mainTexture = Resources.Load (strImage) as Texture;

		string strEmmissiveImage = _name + "_emmissive";	

		//Texture emmissiveImage = Resources.Load(strEmmissiveImage);

		diffuse.materials [0].SetTexture ("_EmissionMap", Resources.Load (strEmmissiveImage) as Texture);

		string cloudImage = _name + "_cloud";
		clouds.materials [0].mainTexture = Resources.Load (cloudImage) as Texture;

		clouds.materials [0].SetTexture ("_EmissionMap", Resources.Load (cloudImage) as Texture);


		string coronaFile = _name + "_corona";

		Renderer _1 = corona.GetComponent<Renderer> ();
		_1.materials [0].mainTexture = Resources.Load (coronaFile) as Texture;

	
		ring.SetActive (_ring);
	
		Resources.UnloadUnusedAssets ();	
	}

	public void setName (string _name)
	{
		nameText = _name;

	}

	public string getName ()
	{
		return nameText;

	}

	public void activateZoomed (bool _active)
	{
		nameTextGameObject.SetActive (_active);

		TextMesh textMesh = nameTextGameObject.GetComponentInChildren<TextMesh> ();

		textMesh.text = getName ();

		spinner.SetActive (!_active);
	}

	public void activateZoomIn (bool active)
	{

	}


	public void rotate (float _rotationX)
	{
		parent.transform.localRotation = new Quaternion (_rotationX * 10f, 0, 0, 0); //Random.rotation;  //

	}


	void Update ()
	{ 

		offset = offset + (Time.deltaTime * .008f);
		offset2 = offset2 + (Time.deltaTime * .01f);

		diffuse.materials [0].mainTextureOffset = new Vector2 (offset, 0.0f);
		clouds.materials [0].mainTextureOffset = new Vector2 (offset2, 0.0f);

	}

}