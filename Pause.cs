using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	private bool paused = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// To pause
		if (Input.GetKeyDown ("p") && !paused) {
			paused = true;
			Time.timeScale = 0;
		}

		// To unpause
		if (Input.GetKeyDown ("p") && paused) {
			paused = false;
			Time.timeScale = 1;
		}
	}
}
