using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_amount_text : MonoBehaviour
{
    public GameObject canvas;
    Text text;
    public int TextID;
    private int textbox;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TextID == 0)
        {
            textbox = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR;
            text.text = textbox.ToString() + "x";
        }

        switch (TextID)
        {
            case 0:
                textbox = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR;
                text.text = textbox.ToString() + "x";
                break;
            case 1:
                textbox = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR;
                text.text = textbox.ToString() + "x";
                break;
            case 2:
                textbox = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR;
                text.text = textbox.ToString() + "x";
                break;
            case 3:
                textbox = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR;
                text.text = textbox.ToString() + "x";
                break;
            case 4:
                textbox = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR;
                text.text = textbox.ToString() + "x";
                break;
            case 5:
                textbox = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR;
                text.text = textbox.ToString() + "x";
                break;
            case 6:
                textbox = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR;
                text.text = textbox.ToString() + "x";
                break;
            case 7:
                textbox = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR;
                text.text = textbox.ToString() + "x";
                break;
            case 8:
                textbox = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR;
                text.text = textbox.ToString() + "x";
                break;
            case 9:
                textbox = canvas.gameObject.GetComponent<scr_Item_Instanciate>().cableLR;
                text.text = textbox.ToString() + "x";
                break;
        }
    }
}
