using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Check : MonoBehaviour
{

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Check");

        if (collision.gameObject.tag == "Component" && GetComponentInParent<scr_ComponentPowerCheck>().active == true && collision.gameObject.GetComponent<scr_ComponentPowerCheck>().powered == true && collision.gameObject.GetComponent<scr_ComponentPowerCheck>().active == true)
        {
            GetComponentInParent<scr_ComponentPowerCheck>().powered = true;
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
