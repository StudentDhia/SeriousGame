using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairManagement : MonoBehaviourPunCallbacks, IPunObservable
{

    private Vector3[] chairs_pos = new[] { new Vector3(13.5f, 1.45f, -4f), new Vector3(4f, 1.45f, -4f), new Vector3(4.73f, -1.44f, 5.45f), new Vector3(13.48f, -1.45f, 5.45f) };
    private int chairs_index = 0;
    Vector3 latestPos;
    Quaternion latestRot;


    // Start is called before the first frame update
    void Awake()
    {
        chairs_transform();
    }

    // Update is called once per frame
    void Update()
    {
        if (!photonView.IsMine)
        {
            //Update remote player (smooth this, this looks good, at the cost of some accuracy)
            transform.position = Vector3.Lerp(transform.position, latestPos, Time.deltaTime * 5);
            transform.rotation = Quaternion.Lerp(transform.rotation, latestRot, Time.deltaTime * 5);
        }
    }


    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            //We own this player: send the others our data
            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);
        }
        else
        {
            //Network player, receive data
            latestPos = (Vector3)stream.ReceiveNext();
            latestRot = (Quaternion)stream.ReceiveNext();
        }
    }

    private void chairs_transform()
    {
        if (photonView.Owner.UserId == "1")
        {
            transform.position = chairs_pos[0];
        }

        if (photonView.Owner.UserId == "2")
        {
            transform.position = chairs_pos[1];
        }

        if (photonView.Owner.UserId == "3")
        {
            transform.position = chairs_pos[2];
        }

        if (photonView.Owner.UserId == "4")
        {
            transform.position = chairs_pos[3];
        }
    }
}
