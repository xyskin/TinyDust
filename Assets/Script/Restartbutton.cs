using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restartbutton : MonoBehaviour {
	public DeathandOver d;
	public Slider cha1, cha2, cha3, cha4;
	public RawImage w1, w2, w3, w4, w5;
	// Use this for initialization
	void Start () {
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(OnClick);
	}
	
	// Update is called once per frame
	void Update () {
		if (d.isStart == false && cha1.value + cha2.value + cha3.value + cha4.value <= 100f)
		{
			this.GetComponent<RawImage>().color = new Color(1, 1, 1, 1);
			if (d.deaths == 3 && d.score1 == 4)
			{
				w1.GetComponent<RawImage>().color = new Color(1, 1, 1, 1);
			}
			else if (d.deaths == 3 && d.score2 == 4)
			{
				w2.GetComponent<RawImage>().color = new Color(1, 1, 1, 1);
			}
			else if (d.deaths == 3 && d.score3 == 4)
			{
				w3.GetComponent<RawImage>().color = new Color(1, 1, 1, 1);
			}
			else if (d.deaths == 3 && d.score4 == 4)
			{
				w4.GetComponent<RawImage>().color = new Color(1, 1, 1, 1);
			}
			else if (d.deaths == 4)
			{
				w5.GetComponent<RawImage>().color = new Color(1, 1, 1, 1);
			}
		}
	}

	void OnClick()
	{
		SceneManager.LoadScene("Fatal Bomb",LoadSceneMode.Single);
	}
}
