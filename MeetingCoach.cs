using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetingCoach : MonoBehaviour
{
    private bool showquiz = false;
    public GameObject QuizCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            showquiz = !showquiz;
        }

        if(showquiz == true)
        {
            QuizCanvas.SetActive(true);
        }
        else
        {
            QuizCanvas.SetActive(false);
        }
    }
}
