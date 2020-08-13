using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBubble : MonoBehaviour
{

    public int height = 10;
    public Transform Camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, height + Mathf.PingPong(Time.time, 1), transform.position.z);
        transform.LookAt(Camera);
    }
}
