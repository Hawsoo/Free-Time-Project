using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
	public float maxSpeed;
	public float jumpHeight;

	public float gravity;

	// Update
	void FixedUpdate()
	{
		Vector3 velocity = GetComponent<Rigidbody> ().velocity;

		// Move
		velocity.x = Input.GetAxis ("Horizontal") * maxSpeed;
		velocity.z = Input.GetAxis("Vertical") * maxSpeed;

		// Jump
		if (Input.GetKey(KeyCode.Space))
			velocity.y = jumpHeight;

		// Apply gravity
		velocity.y -= gravity;

		// Apply movement
		GetComponent<Rigidbody> ().velocity = velocity;
	}
}
