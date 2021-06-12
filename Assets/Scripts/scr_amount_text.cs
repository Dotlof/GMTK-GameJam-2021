using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_amount_text : MonoBehaviour
{
    public GameObject canvas;
    public GameObject button;
    Text text;
    int TextID;
    int ItemID;
    public int ButtonID;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ItemID = button.gameObject.GetComponent<scr_item_button>().invIDs[ButtonID];

        switch (ItemID)
        {
            case 0:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR;
                break;
            case 1:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableUD;
                break;
            case 2:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().curveDR;
                break;
            case 3:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().curveLD;
                break;
            case 4:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().curveLU;
                break;
            case 5:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().curveRU;
                break;
            case 6:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().CableLDR;
                break;
            case 7:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().CableLUD;
                break;
            case 8:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().CableLUR;
                break;
            case 9:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().CableURD;
                break;
            case 10:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableCross;
                break;
            case 11:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().RepeaterLDR;
                break;
            case 12:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().RepeaterLUD;
                break;
            case 13:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().RepeaterLUR;
                break;
            case 14:
                TextID = canvas.gameObject.GetComponent<scr_Item_Instanciate>().RepeaterURD;
                break;
        }

        text.text = TextID.ToString() + "x";
    }
}
