using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;
    

    void Awake(){

        if(instance != null){

            Debug.LogWarning("More than 1 inventory found !");
            return;
        }
        instance = this;
    }

    #endregion

    public delegate void onItemChanged();
    public onItemChanged onItemChangedCallBack;
    public List<Item> items = new List<Item>();
    public int space = 6;

    public bool Add(Item item){

        if(items.Count >= space){

            Debug.Log("Not enough room for this item !");
            return false;
        }

        items.Add(item);

        if(onItemChangedCallBack != null){

            onItemChangedCallBack.Invoke();
        }

        return true;
    }

    public void Remove(Item item){

        items.Remove(item);

        if(onItemChangedCallBack != null){

            onItemChangedCallBack.Invoke();
        }
    }
}
