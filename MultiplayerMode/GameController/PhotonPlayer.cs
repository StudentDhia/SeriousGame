using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PhotonPlayer : MonoBehaviour
{

    private PhotonView PV;
    private Vector3 chair_pos;
    //public GameObject myAvatar;
    // Start is called before the first frame update
    void Start()
    {
        PV = GetComponent<PhotonView>();

        if (PV.IsMine)
        {
            transform.position = Sit_chair();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 Sit_chair()
    {
        int i = 0;

        if(GameSetup.GS.spawnPoints[i].GetComponent<UsedChair>().used == true)
        {
            i++;
        }
        else
        {
            return GameSetup.GS.spawnPoints[i].transform.position;
        }

        return chair_pos;
    }
}
