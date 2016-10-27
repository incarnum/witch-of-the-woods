using UnityEngine;
using System.Collections;

public class wolfColliderScript : MonoBehaviour {

	public string overlap;
	// Use this for initialization
	void Start () {
		overlap = "none";
		Physics.IgnoreLayerCollision (8, 9, false);
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
		}
	}
	//	void OnTriggerExit2D(){
	//		overlap = "none";
	//	}
}
