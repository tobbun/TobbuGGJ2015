using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	public float sideSpeed;
	public float jumpspeed = 400;
	public bool isJumping = false;
	

	// Update is called once per frame
	void FixedUpdate () {
		Move (KeyCode.D, new Vector2 (1, 0), sideSpeed);

		Move (KeyCode.A, new Vector2 (-1, 0), sideSpeed);
	}

	private void Move(KeyCode code, Vector3 movement, float moveSpeed){
		if (Input.GetKey(code)) {
			rigidbody2D.AddForce (movement * moveSpeed);
		}
	}
}
