using UnityEngine;
using System.Collections;

public class CountScript : MonoBehaviour {

	public int timer = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer++;
		Debug.Log (timer);
	
	}
}
