using UnityEngine;
using System.Collections;

public class wolfSelfScript : MonoBehaviour {
	public int wolfLevelGain;
	public int deerDamage;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Deer") {
			//GetComponentInParent<wolfScript> ().wolfLevel += wolfLevelGain;
			GetComponentInParent<wolfScript> ().wolfLevel += Mathf.Abs(col.GetComponentInParent<deerScript>().deerLevel/2);
			Debug.Log (col.name);
			col.GetComponentInParent<deerScript> ().deerLevel -= deerDamage;
		}
	}
}
