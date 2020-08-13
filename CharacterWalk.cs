using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof (CharacterController))]
public class CharacterWalk : MonoBehaviour {

    public float moveSpeed;
    private Rigidbody theRB;
    private CharacterController characterController;

    private Vector3 moveDirection;
    public float gravityScale;

    // Use this for initialization
    void Start () {

        theRB = GetComponent<Rigidbody> ();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update () {

        moveDirection = new Vector3 (Input.GetAxis ("Horizontal") * moveSpeed, 0f, Input.GetAxis ("Vertical") * moveSpeed);

        //moveDirection.y += (Physics.gravity.y * gravityScale);
        characterController.Move(moveDirection * Time.deltaTime);
    }
}