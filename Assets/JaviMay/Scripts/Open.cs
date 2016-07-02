using UnityEngine;
using System.Collections;

public class Open : MonoBehaviour {

	//private Animation anim;

	// Use this for initialization
	void Start () {
		//anim = new Animation ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Accion")) {
			//anim.Play ("CofreAbierto");
			GetComponent<Animation> ().Play ("CofreAbierto");
			//print ("Una espada!");
		}
	}
}
