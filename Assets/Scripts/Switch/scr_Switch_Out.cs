using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Switch_Out : MonoBehaviour
{

    public GameObject In;
    public GameObject CrossIn;

    public bool LinearIn = false;
    public bool Out = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LinearIn == true && CrossIn.GetComponent<scr_Switch_In>().Input == false) Out = true;
        else Out = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Out == true && collision.tag == "Component" && collision.GetComponent<scr_ComponentPowerCheck>().isrepeater == false && collision.GetComponent<scr_ComponentPowerCheck>().active == true)
        {
            collision.GetComponent<scr_ComponentPowerCheck>().powered = true;
        }  
    }

}
