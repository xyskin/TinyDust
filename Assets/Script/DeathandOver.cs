using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathandOver : MonoBehaviour {
	public bool isStart;
	public Startbutton s;
	public Slider ChaH1, ChaH2, ChaH3, ChaH4;
	public GameObject cha1, cha2, cha3, cha4;
	int deaths;
	int score1, score2, score3, score4;
	// Use this for initialization
	void Start () {
		isStart = false;
		score1 = 4;
		score2 = 4;
		score3 = 4;
		score4 = 4;
		deaths = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (ChaH1.value <= 0 && cha1 != null)
		{
			deaths++;
			score1 = deaths;
			Destroy(cha1.gameObject, 0);
		}
		if (ChaH2.value <= 0 && cha2 != null)
		{
			deaths++;
			score2 = deaths;
			Destroy(cha2.gameObject, 0);
		}
		if (ChaH3.value <= 0 && cha3 != null)
		{
			deaths++;
			score3 = deaths;
			Destroy(cha3.gameObject, 0);
		}
		if (ChaH4.value <= 0 && cha4 != null)
		{
			deaths++;
			score4 = deaths;
			Destroy(cha4.gameObject, 0);
		}
		if (deaths >= 3)
		{
			isStart = false;
		}
	}
}
