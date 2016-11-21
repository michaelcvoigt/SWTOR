using UnityEngine;
using System.Collections;

using Cubiquity;

//[ExecuteInEditMode]
public class ColoredCubeMazeFromImage : MonoBehaviour
{

	private string mazeImage = null;
	private string colorImage = null;

	// Use this for initialization

	public void SetImages (string maze, string color)
	{
		mazeImage = maze;
		colorImage = color;
	}

	void Awake ()
	{
		if (mazeImage != null) {
			Load ();
		}
	}

	public void Load ()
	{

		Texture2D mazeTexture2D = Resources.Load("Images/"+mazeImage) as Texture2D;
		Texture2D colorTexture2D = Resources.Load("Images/"+colorImage) as Texture2D;

		// The size of the volume we will generate. Note that our source image cn be considered
		// to have x and y axes,  but we map these to x and z because in Unity3D the y axis is up.
		int width = mazeTexture2D.width;
		int height = 100;
		int depth = mazeTexture2D.height;
		
		// Start with some empty volume data and we'll write our maze into this.
		/// [DoxygenSnippet-CreateEmptyColoredCubesVolumeData]
		// Create an empty ColoredCubesVolumeData with dimensions width * height * depth
		ColoredCubesVolumeData data = VolumeData.CreateEmptyVolumeData<ColoredCubesVolumeData> (new Region (0, 0, 0, width - 1, height - 1, depth - 1));
		/// [DoxygenSnippet-CreateEmptyColoredCubesVolumeData]
		
		//Get the main volume component
		ColoredCubesVolume coloredCubesVolume = gameObject.GetComponent<ColoredCubesVolume> ();
		
		// Attactch the empty data we created previously
		coloredCubesVolume.data = data;		
		
		// At this point we have a volume created and can now start writting our maze data into it.
		
		// It's best to create these outside of the loop.
		//QuantizedColor red = new QuantizedColor(255, 0, 0, 255);
		//QuantizedColor blue = new QuantizedColor(0, 0, 255, 255);
		//QuantizedColor gray = new QuantizedColor(127, 127, 127, 255);
		//QuantizedColor white = new QuantizedColor(255, 255, 255, 255);
		
		// Iterate over every pixel of our maze image.
		for (int z = 0; z < depth; z++) {
			for (int x = 0; x < width; x++) {
				// The exact logic here isn't important for the purpose of the example, but basically we decide which
				// tile a voxel is part of based on it's position. You can tweak the values to get an dea of what they do.
				//QuantizedColor tileColor;
				int tileSize = 4;
				int tileXOffset = 2;
				int tileZOffset = 2;
				int tileXPos = (x + tileXOffset) / tileSize;
				int tileZPos = (z + tileZOffset) / tileSize;

				// For each pixel of the maze image determine whether it is a wall or empty space.
				//bool isWall = mazeImage.GetPixel(x, z).r < 0.5; // A black pixel represents a wall	

	
				QuantizedColor voxColor = new QuantizedColor ((byte)(colorTexture2D.GetPixel (x, z).r * 255), (byte)(colorTexture2D.GetPixel (x, z).g * 255), (byte)(colorTexture2D.GetPixel (x, z).b * 255), 255);

				int currentHeight = (byte)(mazeTexture2D.GetPixel (x, z).r * 100);

				// Iterate over every voxel in the current column.
				for (int y = currentHeight - 1; y > 0; y--) {
					
					data.SetVoxel (x, y, z, voxColor);
						
				}
			}
		}
	}
	

}
