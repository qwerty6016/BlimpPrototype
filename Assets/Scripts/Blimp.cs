using UnityEngine;
using System.Collections;

public class Blimp : MonoBehaviour 
{
	public static Blimp instance;

	public GameObject Bomb;
	Vector2 bombPos;
	public float fireRate = 0.5f;
	float nextFire = 0.0f;

	public float speed = 2.5f;
	private Vector3 target;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if(instance != this)
			Destroy (gameObject);
	}

	void Start()
	{
		target = transform.position;
	}

	void Update()
	{
	    transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}

	void fire()
	{
		bombPos = transform.position;
		Instantiate (Bomb, bombPos, Quaternion.identity);
	}

	public void move()
	{
		target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		target.z = transform.position.z;
	}

	void OnMouseDown()
	{
		if (Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			fire ();
		}
	}
}
