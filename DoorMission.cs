using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMission : MonoBehaviour {

    private Animator animator;
    private bool once = false;
    public GameObject DoorLight;
    private bool launchInfos = false;
    public GameObject camDoor;
    public GameObject player;

    void Awake () {
        animator = GetComponent<Animator> ();
        animator.SetBool ("IsOpen", true);

    }

    // Update is called once per frame
    void Update () {

        if (launchInfos) {

            InfosManager.InfosISOText = "11.1 Secure areas. Defined physical perimeters and barriers, with physical entry controls and working procedures, should protect the premises," +
                " offices, rooms, delivery/ loading areas etc. against unauthorized access.Specialist advice should be sought regarding protection against fires, floods, earthquakes, bombs etc.";
            launchInfos = false;
        }
    }

    private void OnTriggerStay (Collider other) {

        if ((other.tag == "Player") && (Input.GetKeyDown ("space")) && (!once)) {

            StartCoroutine(DoorCoroutine());
            animator.SetBool ("IsOpen", false);
            Score.score += 25;
            once = true;
            DoorLight.GetComponent<Renderer>().material.SetColor ("_Color", Color.red);
            InfosManager.InfosText = "Well done ! Please remember to close the access to an unauthorized area !";
            launchInfos = true;
        }
    }

    IEnumerator DoorCoroutine()
    {

        camDoor.SetActive(true);
        player.SetActive(false);
        yield return new WaitForSeconds(2);
        camDoor.SetActive(false);
        player.SetActive(true);
        InfosManager.InfosAppear = true;
    }
}