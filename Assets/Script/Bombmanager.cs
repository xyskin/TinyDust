using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bombmanager : MonoBehaviour {
	public GameObject bomb,bombprefb;
	public Startbutton a;
	public Explosion exp;
	public Text text;
	public Pause p;
	public GameObject explosion, explosionprefeb;

	Vector3 v;
	int index=0;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		//if(bomb==null&&10f-a.deltaT==0)
			//Invoke ("create",5f);
		if(bomb!=null)
			v=bomb.gameObject.transform.position;
		//if(d.isStart==true&&bomb==null)
		//	create();

	}
	public void create(){
	//TODO-create a bomb
		bomb=GameObject.Instantiate(bombprefb);
		bomb.name = "bomb" + index;
		index++;
		exp.Sphere = bomb;
		a.Starttime = Time.realtimeSinceStartup;
		bomb.transform.position =new Vector3 (Random.Range(-3000,3000),250,Random.Range(-3000,3000));
		//p.pauseend = 0;
		//p.pausestart = 0;
		p.pausedelt = 0;
		//Destroy(bomb.gameObject, 10f);
		destroy();
	}
	void destroy(){
	//TODO- destroy
		Debug.Log("Des "+bomb.name);


		Destroy(bomb.gameObject,8f);
		StartCoroutine(ShowB());
		a.Starttime = Time.realtimeSinceStartup;
		StartCoroutine(ShowA());
	}
	private IEnumerator ShowA()
	{
		yield return new WaitForSeconds(11);
		create();
	}

	private IEnumerator ShowB()
	{
		yield return new WaitForSeconds (8);
		b();
	}

	private void b(){
		
		explosion = GameObject.Instantiate(explosionprefeb);
		explosion.transform.position = new Vector3 (v.x,v.y,v.z);
	}
}
