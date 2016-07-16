using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Cancel")) {
			Cursor.visible = true;
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Respawn") {
			SceneManager.LoadScene (0, LoadSceneMode.Single);
		}
	}
}
