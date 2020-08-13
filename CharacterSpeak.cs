using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpeak : MonoBehaviour {

    public bool speaking = false;
    private Animator anim;
    private string _characterTalking;

        // Start is called before the first frame update
        void Start () {

        anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update () {

            if(speaking == true){

            anim.SetBool("Talk", true);
            }
            else
            {
            anim.SetBool("Talk", false);
            }

        }

        private void OnTriggerStay (Collider other) {

            if ((other.tag == "Player") && (Input.GetKeyDown ("space")) && (InfosManager.InfosAppear == false)) {
                
                gameObject.GetComponent<DialogueTrigger> ().TriggerDialogue ();
                _characterTalking = gameObject.GetComponent<DialogueTrigger>().dialogue.name;
                speaking = true;    
            }
        }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            speaking = false;
        }
    }

}