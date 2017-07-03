using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pause : MonoBehaviour {
	public Text text;
	public DeathandOver s;
	public RawImage restart;
	public bool ispause;
	public float pausestart = 0, pauseend = 0, pausedelt = 0;
	// Use this for initialization
	void Start () {
		ispause = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (s.isStart == true && Input.GetMouseButtonUp(0) && ispause == true)
		{
			ispause = false;
			this.GetComponent<RawImage>().color = new Color(1, 1, 1, 0);
			Time.timeScale = 1;
			text.color = new Color(0, 0, 0, 0);
			pauseend = Time.realtimeSinceStartup;
			restart.GetComponent<RawImage> ().color = new Color (1,1,1,0);
			pausedelt += pauseend - pausestart;
		}
		if (s.isStart == true && Input.GetKeyUp(KeyCode.Escape) && ispause == false)
		{
			ispause = true;
			this.GetComponent<RawImage>().color = new Color(1, 1, 1, 0.5f);
			text.color = new Color(0, 0, 0, 1);
			Time.timeScale = 0;
			pausestart = Time.realtimeSinceStartup;
			restart.GetComponent<RawImage> ().color = new Color (1,1,1,1);
		}
		
	}
}
