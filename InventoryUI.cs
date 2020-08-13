using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{

    public Transform itemsParent;
    Inventory inventory;
    InventorySlot[] slots;
    public GameObject dialogue;

    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallBack += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        /* if(dialogue.active){
            gameObject.SetActive(false);
        }else{
            gameObject.SetActive(true);
        }*/
    }

    void UpdateUI(){

        for(int i=0; i < slots.Length; i++){

            if(i < inventory.items.Count){

                slots[i].AddItem(inventory.items[i]);
            }else
            {
                slots[i].ClearSlot();
            }
        }
    }
}