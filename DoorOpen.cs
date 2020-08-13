using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Quaternion target = Quaternion.Euler(transform.rotation.x, -180, transform.rotation.z);
        //transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
    }

    private void OnTriggerEnter(Collider other) {
        
        
        
    }

    private void OnTriggerExit(Collider other) {
        
        if((other.tag == "Player")){

            animator.SetBool("IsOpen", false);
        }
        
    }

    private void OnTriggerStay(Collider other) {
        
        if((other.tag == "Player") && (Input.GetKeyDown("space"))){

            animator.SetBool("IsOpen", true);
            
        }
    }
}
