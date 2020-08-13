using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SeatManager : MonoBehaviourPun
{

    public GameObject[] AllPlayers;
    private Vector3[] chairs_pos = new[] { new Vector3(13.5f, -1.5f, -4f), new Vector3(4f, -1.5f, -4f), new Vector3(4.73f, -1.5f, 5.45f), new Vector3(13.48f, -1.5f, 5.45f) };
    private PhotonView PV;

    // Start is called before the first frame update
    void Start()
    {
        PV = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {

        PV.RPC("RPC_SeatPositions", RpcTarget.AllBuffered);
    }

    [PunRPC]
    private void RPC_SeatPositions()
    {
        AllPlayers = GameObject.FindGameObjectsWithTag("Meeting");

        for (int i = 0; i < AllPlayers.Length; i++)
        {
            AllPlayers[i].transform.position = chairs_pos[i];
        }
    }
}
