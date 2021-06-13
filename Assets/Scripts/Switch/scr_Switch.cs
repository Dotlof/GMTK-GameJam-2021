using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Switch : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite UnPowered;
    public Sprite PoweredLR;
    public Sprite PoweredUD;
    public Sprite BothPowered;

    public GameObject InL;
    public GameObject InD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

            if (InL.GetComponent<scr_Switch_In>().Input == false && InD.GetComponent<scr_Switch_In>().Input == false)
            {
                sr.sprite = UnPowered;
            }
            else if (InL.GetComponent<scr_Switch_In>().Input == true && InD.GetComponent<scr_Switch_In>().Input == false)
            {
                sr.sprite = PoweredLR;
            }
            else if (InL.GetComponent<scr_Switch_In>().Input == false && InD.GetComponent<scr_Switch_In>().Input == true)
            {
                sr.sprite = PoweredUD;
            }
            else if (InL.GetComponent<scr_Switch_In>().Input == true && InD.GetComponent<scr_Switch_In>().Input == true)
            {
                sr.sprite = BothPowered;
            }

        }
    }

