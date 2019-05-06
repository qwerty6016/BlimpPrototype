using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour 
{

	private BoxCollider2D groundCollider;       //This stores a reference to the collider attached to the Ground.
	private float groundHorizontalLength;       //A float to store the x-axis length of the collider2D attached to the Ground GameObject.

	//Awake is called before Start.
	private void Awake ()
	{
		//Get and store a reference to the collider2D attached to Ground.
		groundCollider = GetComponent<BoxCollider2D> ();
		//Store the size of the collider along the x axis (its length in units).
		groundHorizontalLength = groundCollider.size.x;
	}

	//Update runs once per frame
	private void Update()
	{
		//Check if the difference along the x axis between the main Camera and the position of the object this is attached to is greater than groundHorizontalLength.
		if (transform.position.x < (-groundHorizontalLength * 2))
		{
			//If true, this means this object is no longer visible and we can safely move it forward to be re-used.
			RepositionBackground ();
		}
	}

	private void RepositionBackground()
	{
		Vector3 groundOffSet = new Vector3(groundHorizontalLength * 4f, 0, 1);

		transform.position = (Vector3) transform.position + groundOffSet;
	}
}
