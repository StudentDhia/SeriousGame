using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Trash", menuName = "Inventory/Trash")]
public class Trash : Item {

    public GameObject PaperTrash;

    public override void Use () {

        base.Use ();
    }
}