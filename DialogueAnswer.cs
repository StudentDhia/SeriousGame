using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueAnswer : MonoBehaviour {

    public GameObject canvas_object;
    private bool dialogue_answer;
    public GameObject Button_Yes;
    public GameObject Button_No;
    private bool score_once = false;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    public void answer_yes () {

        canvas_object.SetActive (false);
        dialogue_answer = true;
        Button_Yes.GetComponent<DialogueTrigger> ().TriggerDialogue ();
    }

    public void answer_false () {

        canvas_object.SetActive (false);
        dialogue_answer = false;
        Button_No.GetComponent<DialogueTrigger> ().TriggerDialogue ();

        if (score_once == false) {

            Score.score += 25;
            score_once = true;
        }

    }

}