using UnityEngine;
using System.Collections;

public class Cofre : MonoBehaviour {

	public GameObject escudo;
	public GameObject cofre;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collisionInfo) {
		
		if (collisionInfo.gameObject.name == "Cofre") {
			cofre.GetComponent<Animation> ().Play ("CofreAbierto");
			this.gameObject.SetActive (false);
			cofre.GetComponent<AudioSource> ().Play ();
			escudo.SetActive (true);
		}
	}
}
