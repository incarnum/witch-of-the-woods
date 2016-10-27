using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {
	public delegate void ClickAction();
	public static event ClickAction OnClicked;
	public delegate void ClickAction2();
	public static event ClickAction2 OnClicked2;
	public float timePassDelay;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.N)) {
			//playing = !playing;
			InvokeRepeating ("TimePass", 0f, timePassDelay);
			InvokeRepeating ("TimePass2", timePassDelay * 0.5f, timePassDelay);

		}
	}

		public void TimePass(){
			if (OnClicked != null) {
				OnClicked ();
			};
		}

	public void TimePass2(){
		if (OnClicked2 != null) {
			OnClicked2 ();
		};
	}
}
