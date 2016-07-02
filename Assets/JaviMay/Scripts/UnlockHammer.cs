using UnityEngine;
using System.Collections;

public class UnlockHammer : MonoBehaviour {

	//private Animation anim;
	//public GameObject martillo;
	// Use this for initialization
	void Start () {
		//anim = new Animation ();
		//martillo = GameObject.Find("Martillo");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			
			GetComponent<Animation> ().Play ("PlayHammer");


		}
	}
}
