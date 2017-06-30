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
		if (bomb!=null&&10-a.deltaT<=0) {
			Debug.Log("Times up!");
			destroy ();

			Invoke ("create",5f);
		}

	}
	void create(){
	//TODO-create a bomb
		bomb=GameObject.Instantiate(bombprefb);
		bomb.name = "bomb" + index;
		index++;
		exp.Sphere = bomb;
		a.startTime = Time.realtimeSinceStartup;
		bomb.transform.position =new Vector3 (Random.Range(-3000,3000),250,Random.Range(-3000,3000));
	}
	void destroy(){
	//TODO- destroy
		Debug.Log("Des "+bomb.name);
		DestroyImmediate(bomb);
	}

}
