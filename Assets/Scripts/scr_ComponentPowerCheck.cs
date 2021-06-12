using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_ComponentPowerCheck : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite SPowered;
    public Sprite SUnpowered;

    public bool isrepeater = false;
    public bool isswitch = false;
    public bool issupply = false;

    public bool up = false;
    public bool down = false;
    public bool left = false;
    public bool right = false;


    public bool powered = false;
    public bool active = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (issupply == true) powered = true;

        if (isrepeater == false && isswitch == false) {

            if (powered == true) sr.sprite = SPowered;
            else sr.sprite = SUnpowered;

        }

        if(isrepeater == true)
        {
            if(active == false) gameObject.GetComponent<scr_RepeaterPowerCheck>().active = active;
        }

        if (active == false) powered = false;


    }

    
    }
