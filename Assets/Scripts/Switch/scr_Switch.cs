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
        if(InL.GetComponent<scr_Switch_In>().Input == false && InD.GetComponent<scr_Switch_In>().Input == false)
        {
            sr.sprite = UnPowered;
            Debug.Log("UnPowered");
        }
        else if(InL.GetComponent<scr_Switch_In>().Input == true && InD.GetComponent<scr_Switch_In>().Input == false)
        {
            sr.sprite = PoweredLR;
            Debug.Log("Transferring Left to Right");
        }
        else if(InL.GetComponent<scr_Switch_In>().Input == false && InD.GetComponent<scr_Switch_In>().Input == true)
        {
            sr.sprite = PoweredUD;
            Debug.Log("Transferring Up and Down");
        }
        else if(InL.GetComponent<scr_Switch_In>().Input == true && InD.GetComponent<scr_Switch_In>().Input == true)
        {
            sr.sprite = BothPowered;
            Debug.Log("Error Both Inputs are Powered");
        }
    }
}
