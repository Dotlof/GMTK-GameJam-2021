using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Switch_In : MonoBehaviour
{
    public bool Input = false;
    public GameObject CorrespondingOut;

    public bool up = false;
    public bool down = false;
    public bool left = false;
    public bool right = false;

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Component" && GetComponentInParent<scr_ComponentPowerCheck>().active == true && collision.gameObject.GetComponent<scr_ComponentPowerCheck>().active == true)
        {
            Debug.Log(collision);
            if ((collision.GetComponent<scr_ComponentPowerCheck>().down == true && up == true) || (collision.GetComponent<scr_ComponentPowerCheck>().up == true && down == true) || (collision.GetComponent<scr_ComponentPowerCheck>().left == true && right == true) || (collision.GetComponent<scr_ComponentPowerCheck>().right == true && left == true))
            {
                Input = collision.GetComponent<scr_ComponentPowerCheck>().powered;
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponentInParent<scr_ComponentPowerCheck>().active == false) Input = false;

        if (Input == true)
        {
            CorrespondingOut.GetComponent<scr_Switch_Out>().LinearIn = true;
        }
        else CorrespondingOut.GetComponent<scr_Switch_Out>().LinearIn = false;
    }


}
