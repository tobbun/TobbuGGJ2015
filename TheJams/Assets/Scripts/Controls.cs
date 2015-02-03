using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	public float maxSpeed = 10f;
	public float sideSpeed;
	public float jumpspeed = 400;
	public bool isJumping = false;
	bool facingRight = true;
	bool isWalking = false;

	Animator anim;

	bool mainMusicPlaying = false;


	void Awake () {
		// Load the Fabric manager by loading up the Audio scene!
		AudioManager.LoadFabric();
	}
	
	void Start (){
		anim = GetComponent<Animator> ();
	
	
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
		float move = Input.GetAxis ("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs (move));

		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);

		if (move > 0 && !facingRight) {
			Flip ();
		} else if (move < 0 && facingRight) {
			Flip ();
		}

		/*Move (KeyCode.D, new Vector2 (1, 0), sideSpeed);
		Move (KeyCode.A, new Vector2 (-1, 0), sideSpeed);*/
	}

	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	/*private void Move(KeyCode code, Vector3 movement, float moveSpeed){
		if (Input.GetKey(code)) {
			rigidbody2D.AddForce (movement * moveSpeed);
			isWalking = true;
		} else {
			isWalking = false;
		}
	}*/
}
