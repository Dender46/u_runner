using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody player;

	public float forwardForce = 2000f;
	public float sideForce = 500f;

	// Update is called once per frame
	void FixedUpdate () {
		player.AddForce (0, 0, forwardForce * Time.deltaTime);
		if (Input.GetKey ("a"))
			player.AddForce (-sideForce * Time.deltaTime, 0, 0);
		if (Input.GetKey("d"))
			player.AddForce(sideForce * Time.deltaTime, 0, 0);
	}
}
