using UnityEngine;
using System.Collections;

public class SelfRotation : MonoBehaviour {

	public int speed = 1;

	void Update () {
		transform.Rotate(Vector3.forward * Time.deltaTime * speed, Space.World);
	}
}