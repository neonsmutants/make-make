using UnityEngine;
using System.Collections;

public class MapWaves : MonoBehaviour {
	public Renderer rend;
	void Start() {
		rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find("Standard");
	}
	void Update() {
		float pp = Mathf.PingPong(Time.time, 1.0F);
		rend.material.SetFloat("_Glossiness", pp);
	}
}