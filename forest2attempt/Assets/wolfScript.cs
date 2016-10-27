using UnityEngine;
using System.Collections;

public class wolfScript : MonoBehaviour {
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
	public GameObject wolfPrefab;
	private int direction;
	private bool play;
	public int wolfLevel;
	public int wolfLevelDeterioration;
	public int deathNumber;
	public int reproductionNumber;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			//Debug.Log ("WOLF");
			TimePass ();
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			//Debug.Log ("WOLF");
			TimePass ();
		}

		if (Input.GetKeyDown (KeyCode.M)) {
			//Debug.Log ("M Down");
			CheckSurroundings ();
		}
	}


	void OnEnable()
	{
		EventManager.OnClicked += TimePass;
		EventManager.OnClicked2 += TimePass;
	}

	void OnDisable()
	{
		EventManager.OnClicked -= TimePass;
		EventManager.OnClicked2 -= TimePass;
	}
		

	public void TimePass () {
		gameObject.transform.position += new Vector3 (0, .01f, 0);
		gameObject.transform.position += new Vector3 (0, -.01f, 0);
		CheckSurroundings ();
		if (Mathf.Max(northFavor,eastFavor,southFavor,westFavor) == northFavor) {
			gameObject.transform.position += new Vector3 (0, 1, 0);
			direction = 0;
		} else if (Mathf.Max(northFavor,eastFavor,southFavor,westFavor) == eastFavor) {
			gameObject.transform.position += new Vector3 (1, 0, 0);
			direction = 1;
		} else if (Mathf.Max(northFavor,eastFavor,southFavor,westFavor) == southFavor) {
			gameObject.transform.position += new Vector3 (0, -1, 0);
			direction = 2;
		} else if (Mathf.Max(northFavor,eastFavor,southFavor,westFavor) == westFavor) {
			gameObject.transform.position += new Vector3 (-1, 0, 0);
			direction = 3;
		}

		wolfLevel -= wolfLevelDeterioration;
		if (wolfLevel <= deathNumber) {
			Destroy (gameObject);
		}
		if (wolfLevel >= reproductionNumber) {
			GameObject newwolf;
			newwolf = Instantiate (wolfPrefab);
			newwolf.GetComponent <wolfScript> ().wolfLevel = 5;
			wolfLevel -= 50;
		}

		gameObject.GetComponentsInChildren<wolfColliderScript> () [0].overlap = "none";
		gameObject.GetComponentsInChildren<wolfColliderScript> () [1].overlap = "none";
		gameObject.GetComponentsInChildren<wolfColliderScript> () [2].overlap = "none";
		gameObject.GetComponentsInChildren<wolfColliderScript> () [3].overlap = "none";
		gameObject.GetComponentsInChildren<colliderScript> () [0].overlap = "none";

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
		north = gameObject.GetComponentsInChildren<wolfColliderScript>()[0].overlap;
		if (north == "Deer")
			northFavor = Random.Range(1,10);
		else if (north == "Wolf")
			northFavor = -2;
		else if (north == "Wall")
			northFavor = -40 + Random.Range(1,10);
		else
			northFavor = -30 + Random.Range(1,10);
		if (direction == 2)
			northFavor -= 5;

		east = gameObject.GetComponentsInChildren<wolfColliderScript>()[1].overlap;
		if (east == "Deer")
			eastFavor = Random.Range(1,10);
		else if (east == "Wolf")
			eastFavor = -2;
		else if (east == "Wall")
			eastFavor = -40 + Random.Range(1,10);
		else
			eastFavor = -30 + Random.Range(1,10);
		if (direction == 3)
			eastFavor -= 5;
		
		south = gameObject.GetComponentsInChildren<wolfColliderScript>()[2].overlap;
		if (south == "Deer")
			southFavor = Random.Range(1,10);
		else if (south == "Wolf")
			southFavor = -2;
		else if (south == "Wall")
			southFavor = -40 + Random.Range(1,10);
		else
			southFavor = -30 + Random.Range(1,10);
		if (direction == 0)
			southFavor -= 5;

		west = gameObject.GetComponentsInChildren<wolfColliderScript>()[3].overlap;
		if (west == "Deer")
			westFavor = Random.Range(1,10);
		else if (west == "Wolf")
			westFavor = -2;
		else if (west == "Wall")
			westFavor = -40 + Random.Range(1,10);
		else
			westFavor = -30 + Random.Range(1,10);
		if (direction == 1)
			westFavor -= 5;
		
		self = gameObject.GetComponentsInChildren<colliderScript>()[0].overlap;
	}


}
