using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTrigger : MonoBehaviour {

    public GameObject Bubble2;

    // Start is called before the first frame update
    void Awake () {
        Bubble2.GetComponent<Renderer> ().enabled = false;
    }

    // Update is called once per frame
    void Update () {

    }

    private void OnTriggerEnter (Collider other) {

        if (other.tag == "Player") {

            Bubble2.GetComponent<Renderer> ().enabled = true;
        }

    }

    private void OnTriggerStay (Collider other) {

        if (Input.GetKeyDown ("space")) {

        }
    }

    private void OnTriggerExit (Collider other) {

        if (other.tag == "Player") {

            Bubble2.GetComponent<Renderer> ().enabled = false;
        }
    }
}