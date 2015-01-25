using UnityEngine;
using System.Collections;

public class PlayerHandler : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey (KeyCode.W)){
			rigidbody.AddForce(Vector3.forward * speed , ForceMode.Impulse);
			//transform.position += Vector3.forward * Time.deltaTime * speed;
		} 
		if(Input.GetKey (KeyCode.S)){
			rigidbody.AddForce(Vector3.back * speed, ForceMode.Impulse);
			//transform.position += Vector3.back * Time.deltaTime * speed;
		} 
		if(Input.GetKey (KeyCode.A)){
			rigidbody.AddForce(Vector3.left * speed, ForceMode.Impulse);
			//transform.position += Vector3.left * Time.deltaTime * speed;
		} 
		if(Input.GetKey (KeyCode.D)){
			rigidbody.AddForce(Vector3.right * speed, ForceMode.Impulse);
			//transform.position += Vector3.right * Time.deltaTime * speed;
		}
	}
}
