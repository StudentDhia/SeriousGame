using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetingCanvas : MonoBehaviourPun, IPunObservable
{
    private bool activate_canvas = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activate_canvas == true)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsReading)
        {
            activate_canvas = (bool)stream.ReceiveNext();
        }
        
        
    }
}
