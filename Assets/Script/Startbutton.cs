using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Startbutton : MonoBehaviour {
	public Slider cha1, cha2, cha3, cha4;
	public RawImage ci1, ci2, ci3, ci4, sbtn, qbtn;
	public Image mmbg;
	public DeathandOver d;
	
	public float Starttime;
	// Use this for initialization
	void Start () {
		d.isStart = false;
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(OnClick);
		cha1.GetComponentsInChildren<Image>()[1].color = new Color(1, 1, 1, 0);
		cha2.GetComponentsInChildren<Image>()[1].color = new Color(1, 1, 1, 0);
		cha3.GetComponentsInChildren<Image>()[1].color = new Color(1, 1, 1, 0);
		cha4.GetComponentsInChildren<Image>()[1].color = new Color(1, 1, 1, 0);
		ci1.GetComponent<RawImage>().color = new Color(1, 1, 1, 0);
		ci2.GetComponent<RawImage>().color = new Color(1, 1, 1, 0);
		ci3.GetComponent<RawImage>().color = new Color(1, 1, 1, 0);
		ci4.GetComponent<RawImage>().color = new Color(1, 1, 1, 0);
		
	}
	
	// Update is called once per frame
	void Update () {	
		
	}

	void OnMouseEnter()
	{
		
	}

	private void OnClick()
	{
		//Debug.Log("111");
		Time.timeScale = 1;
		cha1.value = 100;
		cha2.value = 100;
		cha3.value = 100;
		cha4.value = 100;
		sbtn.GetComponent<RawImage>().color = new Color(0,0,0,0);
		qbtn.GetComponent<RawImage>().color = new Color(0, 0, 0, 0);
		cha1.GetComponentsInChildren<Image>()[1].color = new Color(0, 1, 0, 1);
		cha2.GetComponentsInChildren<Image>()[1].color = new Color(0, 1, 0, 1);
		cha3.GetComponentsInChildren<Image>()[1].color = new Color(0, 1, 0, 1);
		cha4.GetComponentsInChildren<Image>()[1].color = new Color(0, 1, 0, 1);
		ci1.GetComponent<RawImage>().color = new Color(1, 1, 1, 1);
		ci2.GetComponent<RawImage>().color = new Color(1, 1, 1, 1);
		ci3.GetComponent<RawImage>().color = new Color(1, 1, 1, 1);
		ci4.GetComponent<RawImage>().color = new Color(1, 1, 1, 1);
		mmbg.GetComponent<Image>().color = new Color(1, 1, 1, 0);
		this.GetComponent<RawImage>().color = new Color(1, 1, 1, 0);
		d.isStart = true;
		Destroy(this,0);
		Starttime = Time.realtimeSinceStartup;
	}
}
