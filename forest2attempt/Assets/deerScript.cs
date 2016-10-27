using UnityEngine;
using System.Collections;

public class deerScript : MonoBehaviour {
	//public GameObject controller;
	public string north;
	public string east;
	public string south;
	public string west;
	public string self;
	public int northFavor;
	public int eastFavor;
	public int southFavor;
	public int westFavor;
	public GameObject deerPrefab;
	private int direction;
	private bool play;
	public int deerLevel;
	public int deerLevelDeterioration;
	public int deathNumber;
	public int reproductionNumber;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			Debug.Log ("Space Down");
			TimePass ();
		}

		if (Input.GetKeyDown (KeyCode.M)) {
			Debug.Log ("M Down");
			CheckSurroundings ();
		}
	}
		

//		if(Input.GetKeyDown(KeyCode.P)) {
//			//play = !play;
//			//InvokeRepeating("TimePass", 1.0f, 0.2f);
//		}

//		if (GameObject.Find("GameController").GetComponent<gameControllerScript>().playing) {
//			TimePass ();
//		}
//	}
//
	void OnEnable()
	{
		EventManager.OnClicked += TimePass;
	}

	void OnDisable()
	{
		EventManager.OnClicked -= TimePass;
	}



	public void TimePass () {
		gameObject.transform.position += new Vector3 (0, .01f, 0);
		gameObject.transform.position += new Vector3 (0, -.01f, 0);
		CheckSurroundings ();
		direction = Random.Range (1, 5);
		if (Mathf.Max(northFavor,eastFavor,southFavor,westFavor) == northFavor) {
			gameObject.transform.position += new Vector3 (0, 1, 0);
		} else if (Mathf.Max(northFavor,eastFavor,southFavor,westFavor) == eastFavor) {
			gameObject.transform.position += new Vector3 (1, 0, 0);
		} else if (Mathf.Max(northFavor,eastFavor,southFavor,westFavor) == southFavor) {
			gameObject.transform.position += new Vector3 (0, -1, 0);
		} else if (Mathf.Max(northFavor,eastFavor,southFavor,westFavor) == westFavor) {
			gameObject.transform.position += new Vector3 (-1, 0, 0);
		}

		deerLevel -= deerLevelDeterioration;
		if (deerLevel <= deathNumber) {
			Destroy (gameObject);
		}
		if (deerLevel >= reproductionNumber) {
			GameObject newDeer;
			newDeer = Instantiate (deerPrefab);
			newDeer.GetComponent<deerScript> ().deerLevel = 5;
			deerLevel -= reproductionNumber;
		}

		CheckSurroundings ();

//		if (direction == 1 && east == "none") {
//			gameObject.transform.position += new Vector3 (1, 0, 0);
//		} else if (direction == 2 && north == "none") {
//			gameObject.transform.position += new Vector3 (0, 1, 0);
//		} else if (direction == 3 && west == "none") {
//			gameObject.transform.position += new Vector3 (-1, 0, 0);
//		} else if (direction == 4 && south == "none") {
//			gameObject.transform.position += new Vector3 (0, -1, 0);
//		}

	}

	public void CheckSurroundings() {
		north = gameObject.GetComponentsInChildren<colliderScript>()[0].overlap;
		if (north == "1")
			northFavor = 1;
		else if (north == "2")
			northFavor = 2;
		else if (north == "3")
			northFavor = 3;
		else if (north == "4")
			northFavor = 4;
		else if (north == "5")
			northFavor = 5;
		else if (north == "6")
			northFavor = 6;
		else if (north == "7")
			northFavor = 7;
		else if (north == "8")
			northFavor = 8;
		else if (north == "9")
			northFavor = 9;
		else if (north == "10")
			northFavor = 10;
		else if (north == "0")
			northFavor = 0;
		else if (north == "Deer")
			northFavor = -1;
		else if (north == "Wolf")
			northFavor = -2;
		else
			northFavor = -3;
		
		east = gameObject.GetComponentsInChildren<colliderScript>()[1].overlap;
		if (east == "1")
			eastFavor = 1;
		else if (east == "2")
			eastFavor = 2;
		else if (east == "3")
			eastFavor = 3;
		else if (east == "4")
			eastFavor = 4;
		else if (east == "5")
			eastFavor = 5;
		else if (east == "6")
			eastFavor = 6;
		else if (east == "7")
			eastFavor = 7;
		else if (east == "8")
			eastFavor = 8;
		else if (east == "9")
			eastFavor = 9;
		else if (east == "10")
			eastFavor = 10;
		else if (east == "0")
			eastFavor = 0;
		else if (east == "Deer")
			eastFavor = -1;
		else if (east == "Wolf")
			eastFavor = -2;
		else
			eastFavor = -3;
		south = gameObject.GetComponentsInChildren<colliderScript>()[2].overlap;
		if (south == "1")
			southFavor = 1;
		else if (south == "2")
			southFavor = 2;
		else if (south == "3")
			southFavor = 3;
		else if (south == "4")
			southFavor = 4;
		else if (south == "5")
			southFavor = 5;
		else if (south == "6")
			southFavor = 6;
		else if (south == "7")
			southFavor = 7;
		else if (south == "8")
			southFavor = 8;
		else if (south == "9")
			southFavor = 9;
		else if (south == "10")
			southFavor = 10;
		else if (south == "0")
			southFavor = 0;
		else if (south == "Deer")
			southFavor = -1;
		else if (south == "Wolf")
			southFavor = -2;
		else
			southFavor = -3;
		
		west = gameObject.GetComponentsInChildren<colliderScript>()[3].overlap;
		if (west == "1")
			westFavor = 1;
		else if (west == "2")
			westFavor = 2;
		else if (west == "3")
			westFavor = 3;
		else if (west == "4")
			westFavor = 4;
		else if (west == "5")
			westFavor = 5;
		else if (west == "6")
			westFavor = 6;
		else if (west == "7")
			westFavor = 7;
		else if (west == "8")
			westFavor = 8;
		else if (west == "9")
			westFavor = 9;
		else if (west == "10")
			westFavor = 10;
		else if (west == "0")
			westFavor = 0;
		else if (west == "Deer")
			westFavor = -1;
		else if (west == "Wolf")
			westFavor = -2;
		else
			westFavor = -3;
		self = gameObject.GetComponentsInChildren<colliderScript>()[4].overlap;
	}


}
