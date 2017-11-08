using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float playerSpeed;
	public float jumpHeight;

	bool canJump;

	void Update ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");

		if (Input.GetButtonDown ("Jump") && canJump) {
			canJump = false;
			GetComponent<Rigidbody> ().velocity = Vector3.up * jumpHeight;
		}

		Vector3 movement = new Vector3 (moveHorizontal, 0f, 0f);

		transform.position += movement / 10 * playerSpeed;

		// restricting player movement to be bounded within screen
		transform.position = new Vector3 (
			Mathf.Clamp (transform.position.x, -30, 30),
			transform.position.y,
			transform.position.z);
	}

	void OnCollisionStay()
	{
		canJump = true;
	}

}
