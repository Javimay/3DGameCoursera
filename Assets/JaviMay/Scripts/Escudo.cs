using UnityEngine;
using System.Collections;

public class Escudo : MonoBehaviour {

	public GameObject anim;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (anim.GetComponent<Animation> ().IsPlaying ("CofreAbierto") != true) {
			GetComponent<Animation> ().Play ("Escudo");
		} else {

		//GetComponent<AudioSource> ().Play ();
			StartCoroutine (Pause (2f));
		}
	}

	IEnumerator Pause(float seg){
		yield return new WaitForSeconds (seg);
		GetComponent<AudioSource> ().Play ();
	}

}
