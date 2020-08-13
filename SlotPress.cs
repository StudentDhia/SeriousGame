using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotPress : MonoBehaviour {

    public GameObject Slot;
    public int Slot_Number;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetButton(KeyCodePress(Slot_Number))) {

            Slot.GetComponent<InventorySlot> ().UseItem ();
        }
    }

    string KeyCodePress (int Slot_Number) {

        switch (Slot_Number) {

            case 1:
                return "Slot1";
            case 2:
                return "Slot2";
            case 3:
                return "Slot3";
            case 4:
                return "Slot4";
            case 5:
                return "Slot5";
            case 6:
                return "Slot6";
            default:
                return "Slot1";
        }
    }

}