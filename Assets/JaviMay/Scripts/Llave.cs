using UnityEngine;
using System.Collections;

public class Llave : MonoBehaviour {

	public GameObject llave;
	public int i;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collisionInfo) {
		
		if (collisionInfo.gameObject.name == "Piso") {
			GetComponent<AudioSource> ().Play ();
			GetComponent<MeshRenderer> ().enabled = false;
			StartCoroutine (Pause (0.5f));

		}
	}

	IEnumerator Pause(float seg){
		yield return new WaitForSeconds (seg);
		llave.SetActive (true);
		llave.GetComponent<Animation> ().Play ("Llave");
		print (Time.time);
		yield return new WaitForSeconds (1.2f);
		llave.GetComponent<AudioSource> ().Play ();
		this.gameObject.SetActive (false);
		print (Time.time);
	}
}
