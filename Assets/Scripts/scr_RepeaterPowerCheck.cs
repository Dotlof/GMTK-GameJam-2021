using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_RepeaterPowerCheck : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite SPowered;
    public Sprite SPoweredL;
    public Sprite SPoweredR;
    public Sprite SUnpowered;

    public bool powerR = false;
    public bool powerL = false;

    public bool powered = false;
    public bool active = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (powerL && powerR == true) powered = true;

        if (powerL == true && powerR == false) sr.sprite = SPoweredL;
        if (powerR == true && powerL == false) sr.sprite = SPoweredR;

        if (powered == true) sr.sprite = SPowered;
        else sr.sprite = SUnpowered;
    }



}
