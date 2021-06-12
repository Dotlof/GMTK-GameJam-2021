using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_button_img : MonoBehaviour
{

    int itemID;
    int buttonID;
    public GameObject Button;
    Image image;

    public Sprite cable;
    public Sprite curve;
    public Sprite crossing3;
    public Sprite crossing4;
    public Sprite repeater;
    public Sprite switcher;
    public Sprite transparent;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        buttonID = Button.gameObject.GetComponent<scr_item_button>().buttonID;
        itemID = Button.gameObject.GetComponent<scr_item_button>().invIDs[buttonID];

        //Debug.Log("ItemID: " + itemID);

        switch (itemID)
        {
            case 0:
                image.sprite = cable;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case 1:
                image.sprite = cable;
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case 2:
                image.sprite = curve;
                transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case 3:
                image.sprite = curve;
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case 4:
                image.sprite = curve;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case 5:
                image.sprite = curve;
                transform.rotation = Quaternion.Euler(0, 0, 270);
                break;
            case 6:
                image.sprite = crossing3;
                transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case 7:
                image.sprite = crossing3;
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case 8:
                image.sprite = crossing3;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case 9:
                image.sprite = crossing3;
                transform.rotation = Quaternion.Euler(0, 0, 270);
                break;
            case 10:
                image.sprite = crossing4;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case 11:
                image.sprite = repeater;
                transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case 12:
                image.sprite = repeater;
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case 13:
                image.sprite = repeater;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case 14:
                image.sprite = repeater;
                transform.rotation = Quaternion.Euler(0, 0, 270);
                break;
            default:
                image.sprite = transparent;
                break;
        }
    }
}
