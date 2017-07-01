using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
	bool isExplosion;
	public Slider chahealth1, chahealth2, chahealth3, chahealth4;
	public GameObject cha1, cha2, cha3, cha4, Sphere;
	public Text text;
	private float dis1, dis2, dis3, dis4;
	private Color green;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (text.text == "0.1") {
			//Time.timeScale = 0;
			dis1 = Vector3.Distance (cha1.transform.position, Sphere.transform.position);
			dis2 = Vector3.Distance (cha2.transform.position, Sphere.transform.position);
			dis3 = Vector3.Distance (cha3.transform.position, Sphere.transform.position);
			dis4 = Vector3.Distance (cha4.transform.position, Sphere.transform.position);
			if (dis1 <= 6133){
				chahealth1.value -= (40 - 0.0065f * dis1);
				chahealth1.GetComponentsInChildren<Image> () [1].color = new Color(1-chahealth1.value/100,chahealth1.value/100,0,1);
			}
			if (dis2 <= 6133){
				chahealth2.value -= (40 - 0.0065f * dis2);
				chahealth2.GetComponentsInChildren<Image> () [1].color = new Color(1-chahealth2.value/100,chahealth2.value/100,0,1);
			}
			if (dis3 <= 6133) {
				chahealth3.value -= (40 - 0.0065f * dis3);
				chahealth3.GetComponentsInChildren<Image> () [1].color = new Color (1 - chahealth3.value / 100, chahealth3.value / 100, 0, 1);
			}
			if (dis4 <= 6133)
				chahealth4.value -= (40 - 0.0065f * dis4);{
				chahealth4.GetComponentsInChildren<Image> () [1].color = new Color (1 - chahealth4.value / 100, chahealth4.value / 100, 0, 1);}
		}
	}
}
