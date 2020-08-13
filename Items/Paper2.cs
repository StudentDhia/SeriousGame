using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Paper", menuName = "Inventory/Paper")]
public class Paper2 : Item {

    public GameObject Paper;
    private Animator anim;

    public override void Use () {

        base.Use ();

        Paper = GameObject.Find ("Paper2");
        anim = Paper.GetComponent<Animator> ();
        anim.SetTrigger ("Shred");
        Score.score += 25;
        ShredderEvent.Shred = true;
    }

}