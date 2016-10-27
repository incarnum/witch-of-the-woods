using UnityEngine;
using System.Collections;

public class gameControllerScript : MonoBehaviour {
	public delegate void ClickAction();
	public static event ClickAction OnClicked;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.N)) {
			//playing = !playing;
			InvokeRepeating("TimePass", 1.0f, 1.0f);
		}
	}

	public void TimePass () {
		if (OnClicked != null)
			OnClicked ();
	}


}
