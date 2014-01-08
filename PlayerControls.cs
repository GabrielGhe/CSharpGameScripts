using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	public KeyCode moveUp;
	public KeyCode moveDown;
	public float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(moveUp)) {
			//pressing the moveUp key
			rigidbody2D.velocity = new Vector3(0,speed,0);
			
		} else if (Input.GetKey(moveDown)) {
			//pressing the moveDown key
			rigidbody2D.velocity = new Vector3(0,speed * -1,0);

		} else {
			//pressing another key
			rigidbody2D.velocity = new Vector3(0,0,0);
		}
	
	}
}
