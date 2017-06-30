using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour {
	float fps=0;
	public float startTime=0;
	public float deltaT;
	public Text text;
	// Use this for initialization
	void Start () {
		startTime = Time.realtimeSinceStartup;
	}
	
	// Update is called once per frame
	void Update () {
		deltaT = Time.realtimeSinceStartup - startTime;
		//Debug.Log (deltaT.ToString ("f2"));

		if (10 - deltaT < 5 && 10 - deltaT > 0) {
			text.color = Color.red;
			text.text = (10 - deltaT).ToString ("f1");
		} else if (10 - deltaT > 5) {
			text.color = Color.black;
			text.text = (10 - deltaT).ToString ("f1");
		} else {
			text.text = "";
			text.color = Color.black;
		}
	}
}
