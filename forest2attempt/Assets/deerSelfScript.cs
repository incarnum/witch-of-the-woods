using UnityEngine;
using System.Collections;

public class deerSelfScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Grass") {
			GetComponentInParent<deerScript> ().deerLevel += col.GetComponent<grassScript> ().level;
			col.GetComponent<grassScript> ().level = 0;
		}
	}
}
