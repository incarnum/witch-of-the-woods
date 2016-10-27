using UnityEngine;
using System.Collections;

public class colliderScript : MonoBehaviour {

	public string overlap;
	// Use this for initialization
	void Start () {
		overlap = "none";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.tag == "Deer") {
			overlap = "Deer";
		} else if (col.tag == "Wolf") {
			overlap = "Wolf";
		} else if (col.tag == "Wall") {
			overlap = "Wall";
		} else if (col.tag == "Grass") {
			overlap = col.GetComponent<grassScript> ().level.ToString ();
		} else
			overlap = "none";
	}
//	void OnTriggerExit2D(){
//		overlap = "none";
//	}
}
