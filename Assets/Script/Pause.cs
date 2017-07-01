using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pause : MonoBehaviour {
	
	public DeathandOver s;
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
			pauseend = Time.realtimeSinceStartup;
			pausedelt = pauseend - pausestart + pausedelt;
		}
		if (s.isStart == true && Input.GetKeyUp(KeyCode.Escape) && ispause == false)
		{
			ispause = true;
			this.GetComponent<RawImage>().color = new Color(1, 1, 1, 1);
			Time.timeScale = 0;
			pausestart = Time.realtimeSinceStartup;
			
		}
		
	}
}
