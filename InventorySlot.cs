using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Button removeButton;
    public GameObject player;
    Item item;

    public void AddItem(Item newItem){

        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
        removeButton.interactable = true;
    }

    public void ClearSlot(){

        item = null;
        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

    public void OnRemoveButton(){

        Inventory.instance.Remove(item);
    }

    public void UseItem(){
        
        if((item != null)&&(item.name == player.GetComponent<MovementController>().itemInContact)){
            
            item.Use();
            ClearSlot();
        }
    }
}
