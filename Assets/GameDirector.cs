using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameDirector : MonoBehaviour {
	GameObject hpGage;
	GameObject point;
	float hit=1;
	float score=0;

	// Use this for initialization
	void Start () {
		this.hpGage = GameObject.Find ("hpGage");
		this.point = GameObject.Find ("point");
		Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Reset(){
		this.hit = 1;
		this.score = 0;
		this.hpGage.GetComponent<Image> ().fillAmount =1f;
		this.point.GetComponent<Text> ().text = this.score.ToString ();
	}
	public void DecreaseHp(){
		this.hpGage.GetComponent<Image> ().fillAmount -= 0.1f;	
		this.hit -= 0.1f;
		if (this.hit < 0) {
			this.Reset ();
		}
		GameObject player= GameObject.Find ("player") ;
		player.GetComponent<PlayerController> ().oneDown();

	}
	public void AddPoint(){
		this.score+= 1f;
		this.point.GetComponent<Text> ().text = this.score.ToString ();
		GameObject player= GameObject.Find ("player") ;
		player.GetComponent<PlayerController> ().oneUP();
	}
}
