using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour {
	float fps=0;
	public Pause p;
	public float deltaT, deltaT2;
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
			if (p.ispause == true)
			{
				deltaT2 = Time.realtimeSinceStartup - s.Starttime;
				deltaT += Time.deltaTime;
			}
			else
			{
				deltaT = Time.realtimeSinceStartup - s.Starttime - p.pauseend + p.pausestart;
			}
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
