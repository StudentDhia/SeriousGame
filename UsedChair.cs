using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsedChair : MonoBehaviour
{
    public bool used = false;
    public GameObject PlayerSitting;

    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Meeting")
        {
            used = true;
            PlayerSitting = other.gameObject;
            //Debug.Log("Owner ID is " + PlayerSitting.GetComponent<PhotonView>().Owner.ActorNumber);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Meeting")
        {
            used = false;
            PlayerSitting = null;
        }
    }

}
