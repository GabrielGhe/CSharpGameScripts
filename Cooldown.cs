using UnityEngine;
using System.Collections;

public class Cooldown : MonoBehaviour {

	private bool onCooldown = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if a gets pressed, key was used... can also be
		//called in as method
		if(Input.GetKeyDown("a")){
			onCooldown = true;
			this.wait(2); // waits 2 seconds
		}
	}

	/// <summary>
	/// Wait the specified time.
	/// </summary>
	/// <param name="time">Time.</param>
	private IEnumerator wait(int time){
		yield return new WaitForSeconds (time * 1.0f);
		onCooldown = false;
	}
}
