using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickInstantiate : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject _prefab;

    private GameObject[] chairTable = new GameObject[3];

    public GameObject chair1;
    public GameObject chair2;
    public GameObject chair3;

    private void Awake()
    {
        /*chairTable[0] = chair1;
        chairTable[1] = chair2;
        chairTable[2] = chair3;

        int i = 0;
        

        if (chairTable[i].GetComponent<UsedChair>().used == true)
        {
            i++;
        }
        else
        {
            Vector3 pos = new Vector3(chairTable[i].transform.position.x, chairTable[i].transform.position.y - 3, chairTable[i].transform.position.z + 1);

            MasterManager.NetworkInstantiate(_prefab, pos, Quaternion.identity);

            chairTable[i].GetComponent<UsedChair>().used = true;

            
        }*/

        Vector3 pos = new Vector3(_prefab.transform.position.x + Random.Range(-5, 5), _prefab.transform.position.y, _prefab.transform.position.z + Random.Range(-5,5));

        MasterManager.NetworkInstantiate(_prefab, pos, Quaternion.identity);


            
        //base.photonView.RPC("RPC_quickTest", RpcTarget.All);            
        


        //PhotonNetwork.IsMessageQueueRunning = true;
    }


    [PunRPC]
    private void RPC_quickTest()
    {
        Vector3 pos = new Vector3(_prefab.transform.position.x + Random.Range(-5, 5), _prefab.transform.position.y, _prefab.transform.position.z + Random.Range(-5, 5));
        MasterManager.NetworkInstantiate(_prefab, pos, Quaternion.identity);
    }

   
}
