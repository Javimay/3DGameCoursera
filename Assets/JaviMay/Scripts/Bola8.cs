using UnityEngine;
using System.Collections;

public class Bola8 : MonoBehaviour {

	void OnCollisionEnter(Collision coll){
	
		if(coll.gameObject.name == "ClawHammer"){

			GetComponent<AudioSource> ().Play();
		}
	}
}
