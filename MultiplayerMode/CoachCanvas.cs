using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoachCanvas : MonoBehaviourPun, IPunObservable
{

    //public GameObject canvas_quiz;
    public static bool activate_canvas = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (base.photonView.IsMine)
        {
            //photonView.RPC("RPC_Init_Quiz", RpcTarget.AllBuffered);
            if (Input.GetKeyDown("space"))
            {
                activate_canvas = !activate_canvas;
            }
            
        }
       // photonView.RPC("RPC_Show_Quiz", RpcTarget.AllBuffered);

    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            //We own this player: send the others our data
            stream.SendNext(activate_canvas);
        }
        else
        {
            activate_canvas = (bool)stream.ReceiveNext();
        }
        
    }

  //  [PunRPC]
   // private void RPC_Show_Quiz()
   // {
   //     canvas_quiz.SetActive(activate_canvas);
    //}

  //  [PunRPC]
  //  private void RPC_Init_Quiz()
  //  {
  //      if(canvas_quiz == null)
  //      {
  //          canvas_quiz = GameObject.Find("MeetingCanvas");
   //     }
    //}
}
