using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoad : MonoBehaviour {

    [SerializeField]
    private Image _progressBar;

    // Start is called before the first frame update
    void Start () {

        StartCoroutine (LoadAsyncOperation ());
    }

    // Update is called once per frame
    void Update () {

    }

    IEnumerator LoadAsyncOperation () {

        AsyncOperation gamelvl = SceneManager.LoadSceneAsync (2);

        while (gamelvl.progress < 1) {

            _progressBar.fillAmount = gamelvl.progress;
            yield return new WaitForEndOfFrame ();
        }
    }
}