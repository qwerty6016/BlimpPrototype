using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

	public float velocityX;
	public float velocityY = 5f;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D>();
		velocityX = GameControl.instance.scrollSpeed;
	}
	
	// Update is called once per frame
	void Update ()
	{
		rb2d.velocity = new Vector2(velocityX, -velocityY);
		Destroy (gameObject, 4f);
	}
}
