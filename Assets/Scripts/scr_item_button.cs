using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_item_button : MonoBehaviour
{
    public GameObject canvas;
    public int[] invIDs;
    int row = 0;

    // Start is called before the first frame update
    void Start()
    {
        invIDs = new int[9];

        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR > 0)
        {
            invIDs[row] = 0;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableUD > 0)
        {
            invIDs[row] = 1;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().curveDR > 0)
        {
            invIDs[row] = 2;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().curveLD > 0)
        {
            invIDs[row] = 3;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().curveLU > 0)
        {
            invIDs[row] = 4;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().curveRU > 0)
        {
            invIDs[row] = 5;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().CableLDR > 0)
        {
            invIDs[row] = 6;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().CableLUD > 0)
        {
            invIDs[row] = 7;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().CableLUR > 0)
        {
            invIDs[row] = 8;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().CableURD > 0)
        {
            invIDs[row] = 9;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableCross > 0)
        {
            invIDs[row] = 10;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().RepeaterLDR > 0)
        {
            invIDs[row] = 11;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().RepeaterLUD > 0)
        {
            invIDs[row] = 12;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().RepeaterLUR > 0)
        {
            invIDs[row] = 13;
            row++;
        }
        if (canvas.gameObject.GetComponent<scr_Item_Instanciate>().RepeaterURD > 0)
        {
            invIDs[row] = 14;
            row++;
        }

        for (int i = 0; i < invIDs.Length; i++)
        {
            Debug.Log(invIDs[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
