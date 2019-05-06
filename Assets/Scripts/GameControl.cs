using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour 
{
	public static GameControl instance;
	public float scrollSpeed = -3.5f;


	void Awake()
	{
		if (instance == null)
			instance = this;
		else if(instance != this)
			Destroy (gameObject);
	}

	void Update()
	{
        
	}
}
