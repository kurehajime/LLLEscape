using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {
	GameObject player;
	PlayerController playerController;
	// Use this for initialization
	void Start () {
		this.player = GameObject.Find ("player");
		this.playerController = this.player.GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, -0.1f, 0);

		if (transform.position.y < -4.2f) {
			Destroy(gameObject);
		}
		if (hitTest()) {
			Destroy(gameObject);
			GameObject director=GameObject.Find("GameDirector");
			director.GetComponent<GameDirector> ().DecreaseHp();
		}
	}
	bool hitTest(){
		Vector2 p1 = transform.position;
		Vector2 p2 = this.player.transform.position;
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.5f;//矢の半径
		float r2 = 1.0f*this.playerController.size;//プレイヤーの半径
		return (d<r1+r2);
	}
}
