using UnityEngine;
using System.Collections;

public class grassScript : MonoBehaviour {
	public int level;
	public int startingLevel;
	public int maxLevel;
	public int minLevel;
	public int growRate;
	public bool randomStart;
	public int randomLowest;
	public int randomHighest;
	//public GameObject controller;
	private TextMesh txt;
	public int likelyGrow;
	private int randomGrow;
	// Use this for initialization
	void Start () {
		txt = GetComponent<TextMesh> ();
		if (randomStart) {
			level = Random.Range (randomLowest, randomHighest + 1);
		} else
			level = startingLevel;
	}

	void OnEnable()
	{
		EventManager.OnClicked += GrassTimePass;
	}

	void OnDisable()
	{
		EventManager.OnClicked -= GrassTimePass;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			GrassTimePass ();
		}

//		if(Input.GetKeyDown(KeyCode.P)) {
//			//play = !play;
//			InvokeRepeating("GrassTimePass", 1.0f, 0.2f);
//		}

	}
	void GrassTimePass(){
		randomGrow = Random.Range (1, likelyGrow + 1);
		if (randomGrow == 1) {
			level += growRate;
			if (level > maxLevel) {
				level = maxLevel;
			}
			if (level < minLevel) {
				level = minLevel;
			}

		}
			txt.text = level.ToString ();
		
	}
}
