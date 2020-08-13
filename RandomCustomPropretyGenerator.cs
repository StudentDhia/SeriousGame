using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomCustomPropretyGenerator : MonoBehaviour
{

    [SerializeField]
    private Text _text;

    private ExitGames.Client.Photon.Hashtable _myCustomPropreties = new ExitGames.Client.Photon.Hashtable();
    private void SetCustomNumber()
    {
        System.Random rnd= new System.Random();
        int result = rnd.Next(0, 99);

        _text.text = result.ToString();

        _myCustomPropreties["RandomNumber"] = result;
        PhotonNetwork.SetPlayerCustomProperties(_myCustomPropreties);
        //_myCustomPropreties.Remove("RandomNumber");
        PhotonNetwork.LocalPlayer.CustomProperties = _myCustomPropreties;
    }
    
    public void OnClick_Button()
    {
        SetCustomNumber();
    }
}
