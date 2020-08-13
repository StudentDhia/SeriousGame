using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMeeting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {

        if ((other.tag == "Player") && (Input.GetKeyDown("space")))
        {
            StartCoroutine(LoadMeetingScene());
        }
    }

    IEnumerator LoadMeetingScene()
    {

        //AsyncOperation gamelvl = SceneManager.LoadSceneAsync(6);
        SceneManager.LoadScene(8);
        yield return new WaitForEndOfFrame();

    }
}
