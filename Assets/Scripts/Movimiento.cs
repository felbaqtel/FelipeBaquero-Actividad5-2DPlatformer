using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {


	public float velX = 0.1f
	public float movX;
	public float inputX;

	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float inputX = Input.GetAxis ("Horizontal"); // Almacena movimiento en eje x

		if (inputX > 0)
			movX = transform.position.x + (inputX * velx);

	}

if (inputX < 0) 
}

