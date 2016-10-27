using UnityEngine;
using System.Collections;

public class simulationAnalyzer : MonoBehaviour {
	public int totalTurns;
	private GameObject[] getCount;
	public int count;
	public int turnsWith0;
	public int turnsWith1;
	public int turnsWith2;
	public int turnsWith3;
	public int turnsWith4;
	public int turnsWith5;
	public int turnsWith6;
	public int turnsWith7;
	public int turnsWith8;
	public int turnsWith9;
	public int turnsWith10;
	public float averagePop;

	void OnEnable()
	{
		EventManager.OnClicked += Analyze;
	}

	void OnDisable()
	{
		EventManager.OnClicked -= Analyze;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Analyze() {
		totalTurns++;
		getCount = GameObject.FindGameObjectsWithTag ("Deer");
		count = getCount.Length;
		if (count == 0)
			turnsWith0++;
		if (count == 1)
			turnsWith1++;
		if (count == 2)
			turnsWith2++;
		if (count == 3)
			turnsWith3++;
		if (count == 4)
			turnsWith4++;
		if (count == 5)
			turnsWith5++;
		if (count == 6)
			turnsWith6++;
		if (count == 7)
			turnsWith7++;
		if (count == 8)
			turnsWith8++;
		if (count == 9)
			turnsWith9++;
		if (count == 10)
			turnsWith10++;
		averagePop = (turnsWith1 + turnsWith2 * 2 + turnsWith3 * 3 + turnsWith4 * 4 + turnsWith5 * 5 + turnsWith6 * 6 + turnsWith7 * 7 + turnsWith8 * 8 + turnsWith9 * 9 + turnsWith10 * 10) / (totalTurns * 1.0f);
	}
}
