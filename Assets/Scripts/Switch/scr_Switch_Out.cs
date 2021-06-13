using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Switch_Out : MonoBehaviour
{
    public bool up = false;
    public bool down = false;
    public bool left = false;
    public bool right = false;

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
        LinearIn = In.GetComponent<scr_Switch_In>().Input;
        if (LinearIn == true && CrossIn.GetComponent<scr_Switch_In>().Input == false) Out = true;
        else Out = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Component" && collision.GetComponent<scr_ComponentPowerCheck>().isrepeater == false && collision.GetComponent<scr_ComponentPowerCheck>().active == true && gameObject.GetComponentInParent<scr_ComponentPowerCheck>().active == true)
        {
            if ((collision.GetComponent<scr_ComponentPowerCheck>().down == true && up == true) || (collision.GetComponent<scr_ComponentPowerCheck>().up == true && down == true) || (collision.GetComponent<scr_ComponentPowerCheck>().left == true && right == true) || (collision.GetComponent<scr_ComponentPowerCheck>().right == true && left == true))
            {
                collision.GetComponent<scr_ComponentPowerCheck>().powered = Out;
            }
        }  
    }

}
