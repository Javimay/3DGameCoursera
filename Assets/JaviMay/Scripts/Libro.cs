using UnityEngine;
using System.Collections;

public class Libro : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collisionInfo) {
		
		if (collisionInfo.gameObject.name == "Olla") {
			this.GetComponent<Animation> ().Play ("Libro");
		}
		if(collisionInfo.gameObject.name != "Mesa"){
			GetComponent<AudioSource> ().Play ();
		}

	}
}
