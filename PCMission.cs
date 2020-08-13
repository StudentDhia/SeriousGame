using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCMission : MonoBehaviour {

    private bool once = false;
    private Renderer PC_renderer;
    public Material Black;
    private bool launchInfos = false;

    // Start is called before the first frame update
    void Start () {

        PC_renderer = GetComponent<Renderer> ();
    }

    // Update is called once per frame
    void Update () {

        if (launchInfos) {

            InfosManager.InfosText = "Defined physical perimeters and barriers, with physical entry controls and working procedures, should protect the premises, offices, rooms, delivery/loading areas etc. against unauthorized access. Specialist advice should be sought regarding protection against fires, floods, earthquakes, bombs etc.";
            InfosManager.InfosAppear = true;
            launchInfos = false;
        }
    }

    private void OnTriggerStay (Collider other) {

        if ((other.tag == "Player") && (Input.GetKeyDown ("space")) && (!once)) {

            PC_renderer.material = Black;
            Score.score += 25;
            once = true;
            launchInfos = true;
        }
    }

}