﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen2 : MonoBehaviour {

    public GameObject Bubble;
    private Animator animator;

    // Start is called before the first frame update
    void Start () {

        animator = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update () {

    }

    

    private void OnTriggerEnter (Collider other) {

        if (other.tag == "Player") {

            Bubble.SetActive (true);
        }
    }

}