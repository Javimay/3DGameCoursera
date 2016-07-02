using UnityEngine;
using System.Collections;

public class Columna : MonoBehaviour {

	public GameObject saco;

	void Start () {
		

	}

	void OnCollisionEnter(Collision collisionInfo) {
		//print("No longer in contact with " + collisionInfo.gameObject.name);
		if (collisionInfo.gameObject.name == "Bola 8") {
			saco.GetComponent<Animation> ().Play ("CaerCol");
			GetComponent<AudioSource> ().Play ();
		}
	}




}
