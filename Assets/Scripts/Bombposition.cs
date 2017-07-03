using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombposition : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider o){
		Vector3 pos= this.transform.position;
		if (o.name == "CubeU"||o.name=="CubeD") {
			this.transform.position = new Vector3 (-pos.x*0.95f, pos.y, -pos.z*0.95f);
		}
		if (o.name == "CubeL" || o.name == "CubeR") {
			this.transform.position = new Vector3 (-pos.x*0.95f, pos.y, -pos.z*0.95f);
		}
	}
}
