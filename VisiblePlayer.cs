using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisiblePlayer : MonoBehaviour {

    public Transform Player;
    private Camera cam;

    // Start is called before the first frame update
    void Start () {

        cam = GetComponent<Camera> ();
    }

    // Update is called once per frame
    void Update () {

        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay (Player.position);

        if (Physics.Raycast (ray, out hit)) {

            if (hit.collider.tag.Equals("Wall")) {
                Debug.DrawRay (cam.transform.position, Player.transform.position - cam.transform.position, Color.green);
                hit.collider.gameObject.GetComponent<Renderer> ().material.SetFloat ("_Transparency", 0.2f);
            }
        }
        
    }
}