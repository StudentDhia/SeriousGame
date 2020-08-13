using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersSpawn : MonoBehaviour
{
    public GameObject Character1;

    void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCoroutine()
    {
        yield return new WaitForSeconds(3);
        Character1.SetActive(true);
    }
}
