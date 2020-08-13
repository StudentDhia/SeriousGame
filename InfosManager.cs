using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfosManager : MonoBehaviour {

    public Text dialogueText;
    public Text ISOtext;
    public Animator animator;
    public static bool InfosAppear = false;
    public static string InfosText = "";
    public static string InfosISOText = "";

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        dialogueText.text = InfosText;
        ISOtext.text = InfosISOText;
        animator.SetBool ("Open", InfosAppear);

        if(Input.GetKeyDown ("space") && (InfosAppear == true)) {

            InfosAppear = false;
        }
    }

}