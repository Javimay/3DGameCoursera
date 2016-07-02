using UnityEngine;
using System.Collections;

public class Huevo : MonoBehaviour {

	public GameObject ollaAnim;
	public GameObject huevo;
	public GameObject olla;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collisionInfo) {
		//print("No longer in contact with " + collisionInfo.gameObject.name);
		if (collisionInfo.gameObject.name == "Huevo") {
			ollaAnim.GetComponent<Animation> ().Play ("Olla");
			GetComponent<AudioSource> ().Play ();
			huevo.SetActive (false);
			olla.GetComponent<MeshCollider> ().convex = true; 
		}
	}
}
