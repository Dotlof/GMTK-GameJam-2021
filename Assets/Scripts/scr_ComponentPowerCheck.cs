using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_ComponentPowerCheck : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite SPowered;
    public Sprite SUnpowered;

    public bool isrepeater = false;

    public bool powered = false;
    public bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active == false) powered = false;

        if (isrepeater == false) {

            if (powered == true) sr.sprite = SPowered;
            else sr.sprite = SUnpowered;

        }

        if(isrepeater == true)
        {
            if(active == false) gameObject.GetComponent<scr_RepeaterPowerCheck>().active = active;
        }

    }


    
    }
