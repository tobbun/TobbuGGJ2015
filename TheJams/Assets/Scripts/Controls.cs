using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	public float sideSpeed;
	public float jumpspeed = 400;
	public bool isJumping = false;
	bool isWalking = false;

	bool mainMusicPlaying = false;

	void Awake () {
		// Load the Fabric manager by loading up the Audio scene!
		AudioManager.LoadFabric();
	}
	
	
	void Update () {
		if (!mainMusicPlaying) {
			if (AudioManager.FabricLoaded) {
				mainMusicPlaying = true;
				AudioManager.PlaySound("MX/Jazzcave_lp");
				Debug.Log("play the music!");
//				AudioManager.PlaySound("FX/Amb/Waves-Light");
			}
		}
	}

	// Update is called once per frame
	void FixedUpdate () {

		Move (KeyCode.D, new Vector2 (1, 0), sideSpeed);
		Move (KeyCode.A, new Vector2 (-1, 0), sideSpeed);
	}

	private void Move(KeyCode code, Vector3 movement, float moveSpeed){
		if (Input.GetKey(code)) {
			rigidbody2D.AddForce (movement * moveSpeed);
			isWalking = true;
		} else {
			isWalking = false;
		}
	}
}
