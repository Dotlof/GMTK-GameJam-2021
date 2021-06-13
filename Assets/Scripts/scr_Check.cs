using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Check : MonoBehaviour
{
    public bool up = false;
    public bool down = false;
    public bool left = false;
    public bool right = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("Inside");
        if (collision.gameObject.tag == "Component" && GetComponentInParent<scr_ComponentPowerCheck>().active == true && collision.gameObject.GetComponent<scr_ComponentPowerCheck>().powered == true && collision.gameObject.GetComponent<scr_ComponentPowerCheck>().active == true)
        {
            if ((collision.GetComponent<scr_ComponentPowerCheck>().down == true && up == true) || (collision.GetComponent<scr_ComponentPowerCheck>().up == true && down == true) || (collision.GetComponent<scr_ComponentPowerCheck>().left == true && right == true) || (collision.GetComponent<scr_ComponentPowerCheck>().right == true && left == true))
            {
                GetComponentInParent<scr_ComponentPowerCheck>().powered = true;
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
        
    }
}
