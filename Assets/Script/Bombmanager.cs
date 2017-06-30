using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bombmanager : MonoBehaviour {
	public GameObject bomb,bombprefb;
	public CountDown a;
	public Explosion exp;
	public Text text;
	int index=0;
	// Use this for initialization
	void Start () {
		create ();
	}
	
	// Update is called once per frame
	void Update () {
		if (bomb!=null&&text.text == "0.0") {
			Debug.Log("Times up!");
			a.startTime = Time.realtimeSinceStartup;
			destroy ();
		}
		if (bomb==null&&5 - a.deltaT <= 0) {
			Debug.Log("T");
			a.startTime = Time.realtimeSinceStartup;
			create ();
		}
	}
	void create(){
	//TODO-create a bomb
		bomb=GameObject.Instantiate(bombprefb);
		bomb.name = "bomb" + index;
		index++;
		exp.Sphere = bomb;

		bomb.transform.position =new Vector3 (Random.Range(-3000,3000),250,Random.Range(-3000,3000));
	}
	void destroy(){
	//TODO- destroy
		Debug.Log("Des "+bomb.name);
		DestroyImmediate(bomb);
	}

}
