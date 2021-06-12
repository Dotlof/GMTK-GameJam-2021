using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_RCheckR : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Component" && GetComponentInParent<scr_RepeaterPowerCheck>().active == true && collision.gameObject.GetComponent<scr_ComponentPowerCheck>().powered == true && collision.gameObject.GetComponent<scr_ComponentPowerCheck>().active == true)
        {
            GetComponentInParent<scr_RepeaterPowerCheck>().powerR = true;
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
