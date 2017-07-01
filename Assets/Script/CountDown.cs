using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour {
	float fps=0;
	
	public float deltaT;
	public Text text;
	public DeathandOver isStart;
	public Startbutton s;
	// Use this for initialization
	void Start () {
		text.text = "";
	
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isStart.isStart == true)
		{
			deltaT = Time.realtimeSinceStartup - s.Starttime;
			//Debug.Log (deltaT.ToString ("f2"));

			if (10 - deltaT < 5 && 10 - deltaT > 0)
			{
				text.color = Color.red;
				text.text = (10 - deltaT).ToString("f1");
			}
			else if (10 - deltaT > 5)
			{
				text.color = Color.black;
				text.text = (10 - deltaT).ToString("f1");
			}
			else
			{
				text.text = "";
				text.color = Color.black;
			}
		}
	}
}
