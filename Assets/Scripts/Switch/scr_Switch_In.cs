using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Switch_In : MonoBehaviour
{
    public bool Input = false;
    public GameObject CorrespondingOut;

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Component" && GetComponentInParent<scr_ComponentPowerCheck>().active == true && collision.gameObject.GetComponent<scr_ComponentPowerCheck>().powered == true && collision.gameObject.GetComponent<scr_ComponentPowerCheck>().active == true)
        {
            Input = true;
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

        if(Input == true)
        {
            CorrespondingOut.GetComponent<scr_Switch_Out>().LinearIn = true;
        }
    }
}
