using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Win_lose : MonoBehaviour {

	public GameObject winscreen;
	public GameObject loosescreen;
	public GameObject button;

	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		button.SetActive (true);
		if (other.gameObject.tag == "P1") {
			loosescreen.SetActive (true);
			Debug.Log ("loose");
		}
		if (other.gameObject.tag == "P2") {
			winscreen.SetActive (true);
			Debug.Log ("Win");
		}
		Destroy (other.gameObject);
	}

	public void reset(){ 
			SceneManager.LoadScene ("test_level_PvsCPU");
}
}