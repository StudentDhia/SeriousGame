using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    
    public GameObject Bubble2;
    public Item item;
    

    // Start is called before the first frame update
    void Awake()
    {
        Bubble2.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.tag == "Player"){

            Bubble2.GetComponent<Renderer>().enabled = true;
        }
        
    }

    private void OnTriggerStay(Collider other) {
        
        if (Input.GetKeyDown("space"))
        {
            bool wasPickedUp = Inventory.instance.Add(item);

            if(wasPickedUp){
                gameObject.SetActive(false);
            }
            
            Debug.Log("Item " + item.name + " eliminated.");
        }
    }

    private void OnTriggerExit(Collider other) {
        
        if(other.tag == "Player"){

            Bubble2.GetComponent<Renderer>().enabled = false;
        }
    }
}
