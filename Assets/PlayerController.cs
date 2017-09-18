using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private float speed = 0;
	const  float SPEED = 0.2f;
	public float size=1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float dx = Input.GetAxis ("Horizontal");

		if (dx<0) {
			this.speed = -1*SPEED;
		}
		if (dx>0) {
			this.speed = SPEED;
		}

		transform.Translate (this.speed, 0, 0);

		this.speed *= 0.92f;
	}
	public void oneUP(){
		size += 0.3f;
		this.transform.localScale = new Vector3(size, size, 1);
	}
	public void oneDown(){
		size -= 0.3f;
		this.transform.localScale = new Vector3(size, size, 1);
	}

}
