using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
//public var _localized_strings : localized_strings;
using System.Collections;

public class data_en : MonoBehaviour
{

	public GalaxyManager _galaxyManager;

	public float[] dataOtherX;
	public float[] dataOtherY;
	public float[] dataOtherZ;


	//public Array dataOtherSector = new Array();


	//public Array dataOtherName = new Array();
	public int[] dataOtherType;
	public int[] dataOtherRegion;
	public string[] dataOtherVideo;
	/*
	public var dataOtherDesc = new Array();
	public var dataOtherVideo = new Array();
	public var dataOtherHeader = new Array();
	public var dataOtherASTROGRAPHICALREGION = new Array();
	public var dataOtherALLEGIANCE = new Array();
	public var dataOtherSTATUS = new Array();
	public var dataOtherTERRAIN = new Array();
	public var dataOtherKEYFACTS = new Array();

	*/

	public float[] dataOtherBloomIntensity;

	/*
public List<Color> dataOtherBloomColorA;
public  List<Color> dataOtherBloomColorB;
public  List<Color> dataOtherBloomColorC;
public  List<Color> dataOtherBloomColorD;
*/
	public  bool[] dataOtherRing;

	private int count;

	void Start ()
	{

//yield _localized_strings._www;

		generateData ();	
		_galaxyManager.CreatePlanets (count);

	}


	void generateData ()
	{
//var _loc_count_index_start = 55f;

		count = 0;


		dataOtherX [count] = 0.4f; //0.5955093f;
		dataOtherZ [count] = 0.45f;  //0.6025576f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 1;	

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;

		dataOtherVideo [count] = "Alderaan";
		dataOtherBloomIntensity [count] = 0.4f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector5(5f;0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = 0.7451411f;	
		dataOtherZ [count] = 0.4529259f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 1;	

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;


		dataOtherVideo [count] = "Balmorra";
		dataOtherBloomIntensity [count] = 0.4f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = 0.1511494f;
		dataOtherY [count] = 0.07299006f;
		dataOtherZ [count] = -2.630395f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 4;

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;

		dataOtherVideo [count] = "Belsavis";
		dataOtherBloomIntensity [count] = 0.15f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = 0.6136465f;	
		dataOtherZ [count] = -0.1637385f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 1;

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;

		dataOtherVideo [count] = "Corellia";
		dataOtherBloomIntensity [count] = 0.4f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = 0.12f; // -0.003017966f;
		dataOtherZ [count] = 0.6342976f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 1;

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;

		dataOtherVideo [count] = "Coruscant";
		dataOtherBloomIntensity [count] = 0.4f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = 2.676752f;
		dataOtherY [count] = 0.09827447f;
		dataOtherZ [count] = 2.48429f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 3;

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;

		dataOtherVideo [count] = "Dromund Kaas";
		dataOtherBloomIntensity [count] = 0.1f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = -0.33f;
		dataOtherY [count] = -0.7748308f;
		dataOtherZ [count] = -2.739218f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 4;

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;

		dataOtherVideo [count] = "Hoth";
		dataOtherBloomIntensity [count] = 0.2f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = 2.749301f;
		dataOtherY [count] = -0.2063827f;
		dataOtherZ [count] = -0.2181502f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 2;

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;

		dataOtherVideo [count] = "Hutta";
		dataOtherBloomIntensity [count] = 2f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = -1.762849f;
		dataOtherZ [count] = 1.554413f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 0;	

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;

		dataOtherVideo [count] = "Ilum";
		dataOtherBloomIntensity [count] = 0.05f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = true;


		count++;

		dataOtherX [count] = 2.4319f;
		dataOtherY [count] = -0.2331543f;
		dataOtherZ [count] = 2.42081f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 3;

/*
dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
*/

		dataOtherVideo [count] = "Korriban";
		dataOtherBloomIntensity [count] = 0.4f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

/*
count++;
dataOtherName[count] = "Clouds of VonDoru";
dataOtherX[count] = -1.65165f;
dataOtherZ[count] = 2.262699f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 0f;

count++;
dataOtherName[count] = "The Impossible Sector";
dataOtherX[count] = -2.152044f;	
dataOtherZ[count] = 2.412576f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 0f;

count++;
dataOtherName[count] = "Zosha Advance";
dataOtherX[count] = -2.002167f;	
dataOtherZ[count] = 1.854166f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 0f;

  count++;
dataOtherName[count] = "Ascendancy Barrier";
dataOtherX[count] = -2.3457f;
dataOtherY[count] = -0.1750057f;
dataOtherZ[count] = 1.727746f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 0f;

count++;
dataOtherName[count] = "Bounty Hunter - The Madalorian Killer";
dataOtherX[count] = -2.659085f;
dataOtherY[count] =0.2062867f;
dataOtherZ[count] = 0.8576416f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 0f;

count++;
dataOtherName[count] = "Trooper - Inconspicuous Valor";
dataOtherX[count] = -2.507923f;
dataOtherY[count] =-0.4582596f;
dataOtherZ[count] = -0.008775592f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 0f;

count++;
dataOtherName[count] = "Skaross Fortification";
dataOtherX[count] = 1.361806f;
dataOtherY[count] =0.7046515f;
dataOtherZ[count] = 2.588579f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 3f;

count++;
dataOtherName[count] = "Agent - A New Epoch of Fear";
dataOtherX[count] = 2.132637f;
dataOtherY[count] =-0.880149f;
dataOtherZ[count] = 2.670196f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 3f;

count++;
dataOtherName[count] = "Makem Te Assault";
dataOtherX[count] = 2.971482f;
dataOtherY[count] =0.543966f;
dataOtherZ[count] = 2.380001f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 3f;

count++;
dataOtherName[count] = "Pakuuni Defense";
dataOtherX[count] = 3.193662f;
dataOtherY[count] =-0.945245f;
dataOtherZ[count] = 1.912969f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 2f;

*/

		count++;

		dataOtherX [count] = 2.8f;
		dataOtherY [count] = -0.2063829f;
		dataOtherZ [count] = -0.1637385f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 2;

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;

		dataOtherVideo [count] = "Nar Shaddaa";
		dataOtherBloomIntensity [count] = 2.0f;
//dataOtherBloomColorA[count]  = Vector4(0.9,0.4f,0.2f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.5,0.2f,0.2f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.2f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = 0.1511482f;
		dataOtherZ [count] = 1.459539f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 1;

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;

		dataOtherVideo [count] = "Ord Mantell";
		dataOtherBloomIntensity [count] = 0.4f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;
	
		count++;

		dataOtherX [count] = 2.776507f;
		dataOtherY [count] = 0.8717999f;
		dataOtherZ [count] = 0.534543f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 2;

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;

		dataOtherVideo [count] = "Quesh";
		dataOtherBloomIntensity [count] = 2.5f;
//dataOtherBloomColorA[count]  = Vector4(0.8f,0.4f,0.2f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.8f,0.8f,0.2f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.2f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = 0.9219794f;
		dataOtherY [count] = -0.4746087f;
		dataOtherZ [count] = 1.699858f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 3;	

/*
dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
*/

		dataOtherVideo [count] = "Taris";
		dataOtherBloomIntensity [count] = 0.4f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = 2.558859f;
		dataOtherY [count] = -0.821951f;
		dataOtherZ [count] = -2.081746f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 4;

/*
dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
*/

		dataOtherVideo [count] = "Tatooine";
		dataOtherBloomIntensity [count] = 2.0f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = 0.0241878f;	
		dataOtherZ [count] = 0.3304999f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 1;	

/*
dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
*/

		dataOtherVideo [count] = "Tython";
		dataOtherBloomIntensity [count] = 0.4f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

		count++;

		dataOtherX [count] = 2.971482f;
		dataOtherY [count] = -0.9843758f;
		dataOtherZ [count] = 2.03086f;
		dataOtherType [count] = 1;
		dataOtherRegion [count] = 2;	

//dataOtherName[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherHeader[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherDesc[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherASTROGRAPHICALREGION[count] =_localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherALLEGIANCE[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherSTATUS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherTERRAIN[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;
//dataOtherKEYFACTS[count] = _localized_strings.getKey(_loc_count_index_start);_loc_count_index_start++;

		dataOtherVideo [count] = "Voss";
		dataOtherBloomIntensity [count] = 1.0f;
//dataOtherBloomColorA[count]  = Vector4(0.4f,0.4f,0.8f,0.75f);
//dataOtherBloomColorB[count]  = Vector4(0.4f,0.8f,0.8f,0.75f);
//dataOtherBloomColorC[count]  = Vector4(0.8f,0.4f,0.8f,0.75f);
//dataOtherBloomColorD[count]  = Vector4(0.8f,0.4f,0.0F,0.75f);
		dataOtherRing [count] = false;

/*
count++;
dataOtherName[count] = "Jabiim Escort";
dataOtherX[count] = 3.04403f;
dataOtherY[count] =-0.8678101f;
dataOtherZ[count] = 1.482211f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 2f;

count++;
dataOtherName[count] = "Saleucami Fleet Action";
dataOtherX[count] = 2.953344f;
dataOtherY[count] =0.3583769f;
dataOtherZ[count] = 1.10133f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 2f;

count++;
dataOtherName[count] = "Warrior - A Treat Leveleds";
dataOtherX[count] = 2.404695f;
dataOtherY[count] =0.812331f;
dataOtherZ[count] = 2.035394f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 2f;	

count++;
dataOtherName[count] = "Nez Peron Sweep";
dataOtherX[count] = 1.330066f;
dataOtherY[count] =-0.4861919f;
dataOtherZ[count] = 2.157821f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 3f;	

count++;
dataOtherName[count] = "Hydian Way Blockade";
dataOtherX[count] = 0.7814162f;
dataOtherY[count] =0.7839898f;
dataOtherZ[count] = 1.935641f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 3f;	

count++;
dataOtherName[count] = "Archenar Interception";
dataOtherX[count] = 2.563395f;
dataOtherY[count] =-0.732724f;
dataOtherZ[count] = 0.4755971f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 2f;

count++;
dataOtherName[count] = "Smuggler - The Endless Abyss";
dataOtherX[count] = 3.393171f;
dataOtherY[count] =0.6803343f;
dataOtherZ[count] = 0.4030485f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 2f;

count++;
dataOtherName[count] = "Balosar Outpost";
dataOtherX[count] = 2.622341f;
dataOtherY[count] =0.1117305f;
dataOtherZ[count] = -0.3179045f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 2f;


count++;
dataOtherName[count] = "Trooper - Public Relations";
dataOtherX[count] = 2.255063f;
dataOtherY[count] =0.1998744f;
dataOtherZ[count] = -1.043392f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 2f;

count++;
dataOtherName[count] = "Syvris Evacuation";
dataOtherX[count] = 3.361431f;
dataOtherY[count] =0.6858242f;
dataOtherZ[count] = -0.707854f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 2f;

count++;
dataOtherName[count] = "Warrior - The Plan is Working";
dataOtherX[count] = 3.016824f;
dataOtherY[count] =-0.7003418f;
dataOtherZ[count] = -0.9028286f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 4f;

count++;
dataOtherName[count] = "Ezran Outpost";
dataOtherX[count] = 2.490845f;
dataOtherY[count] =0.6748769f;
dataOtherZ[count] = -1.596576f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 4f;

count++;
dataOtherName[count] = "Trooper - The Shadow Fist";
dataOtherX[count] = 1.656535f;
dataOtherY[count] = 0.8264155f;
dataOtherZ[count] = -1.288244f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 4f;

count++;
dataOtherName[count] = "Llanic Station Strike";
dataOtherX[count] = 2.096361f;
dataOtherY[count] =0.6343718f;
dataOtherZ[count] = -2.090815f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 4f;

count++;
dataOtherName[count] = "Drexel Fortification";
dataOtherX[count] = 1.475163f;
dataOtherY[count] =-0.9662575f;
dataOtherZ[count] = -2.707479f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 4f;

count++;
dataOtherName[count] = "Sullust Defense";
dataOtherX[count] = 0.6725924f;
dataOtherY[count] =-0.3227423f;
dataOtherZ[count] = -2.249515f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 4f;

count++;
dataOtherName[count] = "Smuggler - Distressed";
dataOtherX[count] = -0.3975004f;
dataOtherY[count] =-0.3216469f;
dataOtherZ[count] = -2.176966f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 4f;


count++;
dataOtherName[count] = "Mugaar Ice Field";
dataOtherX[count] = -0.2478686f;
dataOtherY[count] =-0.1163532f;
dataOtherZ[count] = -2.784561f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 4f;

count++;
dataOtherName[count] = "Kovor Ice Field";
dataOtherX[count] = -1.018699f;
dataOtherY[count] =0.1183084f;
dataOtherZ[count] = -2.607723f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 4f;

count++;
dataOtherName[count] = "Consular - Vivicar Awaits";
dataOtherX[count] = -1.998107f;
dataOtherY[count] =-0.3988019f;
dataOtherZ[count] = -2.104416f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 4f;

count++;
dataOtherName[count] = "Consular - Distress Call";
dataOtherX[count] = -2.669183f;
dataOtherY[count] =0.8287032f;
dataOtherZ[count] = -1.592041f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 4f;

count++;
dataOtherName[count] = "Polith Minefield";
dataOtherX[count] = 0.2645057f;
dataOtherY[count] =0.5821393f;
dataOtherZ[count] = -1.143147f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 1f;


count++;
dataOtherName[count] = "Fondor Escort";
dataOtherX[count] = 0.1511483f;
dataOtherY[count] =0.860095f;
dataOtherZ[count] = -0.8982944f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 1f;


count++;
dataOtherName[count] = "Cartell Listening Station";
dataOtherX[count] = 0.3914659f;
dataOtherY[count] =-0.5015831f;
dataOtherZ[count] = -0.417659f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 1f;

count++;
dataOtherName[count] = "Sarapin Assault";
dataOtherX[count] = 0.4458775f;
dataOtherZ[count] = 0.2307453f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 1f;

count++;
dataOtherName[count] = "Javaal Fleet Action";
dataOtherX[count] = 0.05592787f;	
dataOtherZ[count] = 0.7793949f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 1f;

count++;
dataOtherName[count] = "Taspan Ambush";
dataOtherX[count] = 0.4640146f;	
dataOtherZ[count] = 1.151207f;
dataOtherType[count] = 2f;
dataOtherRegion[count] = 1f;

count++;
dataOtherName[count] = "Kinght - Uphrades";
dataOtherX[count] = 0.6227149f;	
dataOtherZ[count] = 1.19655f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 1f;

count++;
dataOtherName[count] = "Knight - New Intelligence";
dataOtherX[count] = 0.1964912f;
dataOtherZ[count] = 1.477676f;
dataOtherType[count] = 3f;
dataOtherRegion[count] = 1f;
dataOtherHeader[count] = "";
dataOtherDesc[count] = "";
dataOtherASTROGRAPHICALREGION[count] = "";
dataOtherALLEGIANCE[count] = "";
dataOtherSTATUS[count] = "";
dataOtherTERRAIN[count] = "";
dataOtherKEYFACTS[count] = "";
dataOtherVideo[count] = "";

*/

//dataOtherY[0] =-0.004358977f;dataOtherY[1] =-0.01157945f;dataOtherY[2] =0.04307613f;dataOtherY[3] =-0.0382501f;dataOtherY[4] =0.0297983f;dataOtherY[5] =0.03554294f;dataOtherY[6] =0.04907966f;dataOtherY[7] =-0.04050002f;dataOtherY[8] =-0.02208433f;dataOtherY[9] =0.02337619f;dataOtherY[10] =-0.007329684f;dataOtherY[11] =0.0002430975f;dataOtherY[12] =-0.03571353f;dataOtherY[13] =-0.01376912f;dataOtherY[14] =-0.04177586f;dataOtherY[15] =0.02441372f;dataOtherY[16] =0.0157021f;dataOtherY[17] =0.04246518f;dataOtherY[18] =-0.04773932f;dataOtherY[19] =-0.01372239f;dataOtherY[20] =-0.00633008f;dataOtherY[21] =-0.03829474f;dataOtherY[22] =0.02416363f;dataOtherY[23] =-0.03139651f;dataOtherY[24] =0.02004639f;dataOtherY[25] =-0.04010937f;dataOtherY[26] =0.01136964f;dataOtherY[27] =-0.04934934f;dataOtherY[28] =-0.02692387f;dataOtherY[29] =-0.02692386f;dataOtherY[30] =-0.03266579f;dataOtherY[31] =-0.02117922f;dataOtherY[32] =-0.04521615f;dataOtherY[33] =-0.03026247f;dataOtherY[34] =0.002717681f;dataOtherY[35] =-0.005186968f;dataOtherY[36] =0.03022262f;dataOtherY[37] =0.01575919f;dataOtherY[38] =0.03240472f;dataOtherY[39] =-0.04314944f;dataOtherY[40] =0.04072794f;dataOtherY[41] =-0.00289344f;dataOtherY[42] =-0.04567325f;dataOtherY[43] =-0.0256047f;dataOtherY[44] =0.01695964f;dataOtherY[45] =-0.04599816f;dataOtherY[46] =-0.0120801f;dataOtherY[47] =0.04895828f;dataOtherY[48] =0.04477565f;dataOtherY[49] =0.006833382f;dataOtherY[50] =-0.01797884f;dataOtherY[51] =0.03889224f;dataOtherY[52] =-0.001726717f;dataOtherY[53] =0.04382838f;dataOtherY[54] =0.02474274f;dataOtherY[55] =-0.0008136332f;dataOtherY[56] =0.01787026f;dataOtherY[57] =-0.001857717f;dataOtherY[58] =-0.00724731f;dataOtherY[59] =0.03893868f;dataOtherY[60] =-0.01157945f;


	}
}