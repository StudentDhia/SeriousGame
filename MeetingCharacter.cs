using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetingCharacter : MonoBehaviourPun
{

    private Animator anim;

    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (base.photonView.IsMine)
        {
            if (Input.GetKey("space"))
            {
                anim.SetBool("Hand", true);
            }
            else
            {
                anim.SetBool("Hand", false);
            }
        }
    }
}
