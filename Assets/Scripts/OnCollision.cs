using UnityEngine;
using UnityEngine.UI;

public class OnCollision : MonoBehaviour {

	public Movement movement;
	public Text scoreText;

	// Update is called once per frame
	void OnCollisionEnter (Collision colInfo) {
		if (colInfo.collider.tag == "Obstacle") {
			movement.enabled = false;
			scoreText.text = "game over";
			Debug.Log ("", scoreText);
		}
	}
}
