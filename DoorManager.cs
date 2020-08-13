using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
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
        
    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.tag == "Player"){

            animator.SetBool("IsOpen", true);
        }
        
    }

    private void OnTriggerExit(Collider other) {
        
        if(other.tag == "Player"){

            animator.SetBool("IsOpen", false);
        }
    }

    private void OnTriggerStay(Collider other) {
        
       
    }

}
