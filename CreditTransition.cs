using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditTransition : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

        StartCoroutine (LoadAsyncOperation ());
    }

    // Update is called once per frame
    void Update () {

    }

    IEnumerator LoadAsyncOperation () {

        AsyncOperation gamelvl = SceneManager.LoadSceneAsync (5);
        yield return new WaitForEndOfFrame ();
    }
}