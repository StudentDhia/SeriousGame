using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    private Queue<string> sentences;
    public Text nameText;
    public Text dialogueText;
    public Image dialogueImage;
    public Animator animator;
    public GameObject _Inventory;
    public GameObject Answer_Canvas;
    private bool _answer;
    private bool _showISO;

    [Space (20)]
    [Header ("Sound Settings")]
    public AudioClip[] letterSounds;
    private AudioSource audioSource;

    [Space (20)]
    [Range (0, 10f)]
    public float basePitch = 1.5f;
    [Range (0f, 3f)]
    public float pitchShift = 0.5f;
    public bool useLetterSounds = true;
    public bool useRandomPitch = false;

    // Start is called before the first frame update
    void Start () {
        sentences = new Queue<string> ();
        audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update () {

    }

    public void StartDialogue (Dialogue dialogue) {

        _Inventory.SetActive (false);
        animator.SetBool ("IsOpen", true);
        nameText.text = dialogue.name;
        dialogueImage.material = dialogue.diagCam;
        _answer = dialogue.answer;
        _showISO = dialogue.showInfos;

        sentences.Clear ();

        foreach (string sentence in dialogue.sentences) {
            sentences.Enqueue (sentence);
        }

        DisplayNextSentence ();
    }

    public void DisplayNextSentence () {

        if (sentences.Count == 0) {
            EndDialogue ();
            return;
        }

        string sentence = sentences.Dequeue ();
        StopAllCoroutines ();
        StartCoroutine (TypeSentence (sentence));
    }

    IEnumerator TypeSentence (string sentence) {


        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray ()) {
            dialogueText.text += letter;

            if (useRandomPitch)
                audioSource.pitch = Random.Range (basePitch - (pitchShift / 2), basePitch + (pitchShift / 2));
            else
                audioSource.pitch = basePitch;

            if (useLetterSounds && letterSounds != null) {

                // If all letter sounds excists
                if (letterSounds.Length >= 26) {
                    int audioID = GetLetterSound (letter);

                    audioSource.clip = (audioID <= 25) ? letterSounds[audioID] : letterSounds[0];

                } else
                    Debug.LogError ("In order to use letter sounds, you need 26 sounds, one sound for each letter of the alphabet.");

            } else { // If unique letter sounds aren't used

                if (letterSounds[0] != null) {
                    if (audioSource.clip != letterSounds[0])
                        audioSource.clip = letterSounds[0];
                } else {
                    Debug.LogError ("Cannot play sounds because lettersounds[0] is null.");
                }

            }

            audioSource.Play ();

            yield return null;
        }
    }

    void EndDialogue () {

        animator.SetBool ("IsOpen", false);

        if (_answer == true) {

            Answer_Canvas.SetActive (true);
        } else {
            _Inventory.SetActive (true);
        }

        if(_showISO == true)
        {
            InfosManager.InfosText = "Well done ! Please remember to not give away your logging and password to another one.";
            InfosManager.InfosISOText = "9.3 User responsibilities Users should be made aware of their responsibilities towards" +
                " maintaining effective access controls e.g.choosing strong passwords and keeping them confidential. ";
            InfosManager.InfosAppear = true;
            _showISO = false;
        }
    }

    int GetLetterSound (char letter) {

        //letter = letter.ToLower ();

        switch (letter) {
            case 'a':
                return 0;
            case 'b':
                return 1;
            case 'c':
                return 2;
            case 'd':
                return 3;
            case 'e':
                return 4;
            case 'f':
                return 5;
            case 'g':
                return 6;
            case 'h':
                return 7;
            case 'i':
                return 8;
            case 'j':
                return 9;
            case 'k':
                return 10;
            case 'l':
                return 11;
            case 'm':
                return 12;
            case 'n':
                return 13;
            case 'o':
                return 14;
            case 'p':
                return 15;
            case 'q':
                return 16;
            case 'r':
                return 17;
            case 's':
                return 18;
            case 't':
                return 19;
            case 'u':
                return 20;
            case 'v':
                return 21;
            case 'w':
                return 22;
            case 'x':
                return 23;
            case 'y':
                return 24;
            case 'z':
                return 25;
            default:
                return 26;
        }

    }

    float getCharacterPitch (string name) {

        switch (name) {

            case "Secretaire":
                return 1.6f;
            case "Mehdi":
                return 0.8f;
            case "Mariem":
                return 1.4f;
            default:
                return 1;
        }

    }
}