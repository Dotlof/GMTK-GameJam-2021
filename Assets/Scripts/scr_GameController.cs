using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_GameController : MonoBehaviour
{
    GameObject[] Components;
    // Start is called before the first frame update
    void Start()
    {
        Components = GameObject.FindGameObjectsWithTag("Component");
        StartCoroutine(ResetPower());
    }

    // Update is called once per frame
    void Update()
    {
        Components = GameObject.FindGameObjectsWithTag("Component");
    }

    IEnumerator ResetPower()
    {
        foreach(GameObject Component in Components)
        {
            Component.GetComponent<scr_ComponentPowerCheck>().powered = false;
            if(Component.GetComponent<scr_ComponentPowerCheck>().isrepeater == true)
            {
                Component.GetComponent<scr_RepeaterPowerCheck>().powerL = false;
                Component.GetComponent<scr_RepeaterPowerCheck>().powerR = false;
            }

            else if(Component.GetComponent<scr_ComponentPowerCheck>().isswitch == true)
            {
                Component.GetComponent<scr_ComponentPowerCheck>().active = false;
                Component.GetComponentInChildren<scr_Switch_In>().Input = false;
                Component.GetComponentInChildren<scr_Switch_Out>().Out = false;
                Component.GetComponentInChildren<scr_Switch_Out>().LinearIn = false;
                Component.GetComponent<scr_ComponentPowerCheck>().active = true;

            }

        }
        yield return new WaitForSeconds(2f);
        StartCoroutine(ResetPower());
    }

}
