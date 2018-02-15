using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampahHilang : MonoBehaviour {
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		switch(other.gameObject.tag)
		{
		case "tongSampah":
			Destroy (this.gameObject);
			Debug.Log ("Masuk");
			break;
		case "Plan":
			Destroy (this.gameObject);
			Debug.Log ("Tidak Masuk");
			break;
		}
}
}
