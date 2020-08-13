using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShredderEvent : MonoBehaviour {

    public static bool Shred = false;
    public GameObject ShredderCamera;
    public GameObject ShredderBubble;
    public GameObject Player;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        if (Shred == true) {
            ShredderCamera.SetActive (true);
            ShredderBubble.SetActive (false);
            Player.SetActive (false);
            StartCoroutine (RemoveCamera ());
        }
    }

    IEnumerator RemoveCamera () {

        yield return new WaitForSeconds (2);
        ShredderCamera.SetActive (false);
        ShredderBubble.SetActive (true);
        Player.SetActive (true);
        Shred = false;
        InfosManager.InfosText = "Well done ! If you found a document that contains sensible, please take the right procedures to discard it just how you just did !";
        InfosManager.InfosAppear = true;
    }

}