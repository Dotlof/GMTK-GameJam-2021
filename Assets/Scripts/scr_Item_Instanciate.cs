using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_Item_Instanciate : MonoBehaviour
{
    public GameObject objCableLR;
    public GameObject objCableUD;
    public GameObject objCurveDR;
    public GameObject objCurveLD;
    public GameObject objCurveLU;
    public GameObject objCurveRU;
    public GameObject objCableLDR;
    public GameObject objCableLUD;
    public GameObject objCableLUR;
    public GameObject objCableURD;
    public GameObject objCableCross;
    public GameObject objRepeaterLDR;
    public GameObject objRepeaterLUD;
    public GameObject objRepeaterLUR;
    public GameObject objRepeaterURD;

    public int cableLR;
    public int cableUD;
    public int curveDR;
    public int curveLD;
    public int curveLU;
    public int curveRU;
    public int CableLDR;
    public int CableLUD;
    public int CableLUR;
    public int CableURD;
    public int cableCross;
    public int RepeaterLDR;
    public int RepeaterLUD;
    public int RepeaterLUR;
    public int RepeaterURD;

    public GameObject Button;
    public GameObject Spawnpoint;
    public GameObject Menu;

    int itemID;

    public void InitiateItem(int id)
    {
        itemID = Button.gameObject.GetComponent<scr_item_button>().invIDs[id];
        Vector3 spawnPos = Spawnpoint.gameObject.transform.position;

        //Debug.Log(itemID);

        switch (itemID)
        {
            case 0:
                if (cableLR > 0)
                {
                    Instantiate(objCableLR, spawnPos, Quaternion.Euler(0, 0, 0));
                    cableLR--;
                }
                break;
            case 1:
                if (cableUD > 0)
                {
                    Instantiate(objCableUD, spawnPos, Quaternion.Euler(0, 0, 90));
                    cableUD--;
                }
                break;
            case 2:
                if (curveDR > 0)
                {
                    Instantiate(objCurveDR, spawnPos, Quaternion.Euler(0, 0, 180));
                    curveDR--;
                }
                break;
            case 3:
                if (curveLD > 0)
                {
                    Instantiate(objCurveLD, spawnPos, Quaternion.Euler(0, 0, 90));
                    curveLD--;
                }
                break;
            case 4:
                if (curveLU > 0)
                {
                    Instantiate(objCurveLU, spawnPos, Quaternion.Euler(0, 0, 0));
                    curveLU--;
                }
                break;
            case 5:
                if (curveRU > 0)
                {
                    Instantiate(objCurveRU, spawnPos, Quaternion.Euler(0, 0, 270));
                    curveRU--;
                }
                break;
            case 6:
                if (CableLDR > 0)
                {
                    Instantiate(objCableLDR, spawnPos, Quaternion.Euler(0, 0, 180));
                    CableLDR--;
                }
                break;
            case 7:
                if (CableLUD > 0)
                {
                    Instantiate(objCableLUD, spawnPos, Quaternion.Euler(0, 0, 90));
                    CableLUD--;
                }
                break;
            case 8:
                if (CableLUR > 0)
                {
                    Instantiate(objCableLUR, spawnPos, Quaternion.Euler(0, 0, 0));
                    CableLUR--;
                }
                break;
            case 9:
                if (CableURD > 0)
                {
                    Instantiate(objCableURD, spawnPos, Quaternion.Euler(0, 0, 270));
                    CableURD--;
                }
                break;
            case 10:
                if (cableCross > 0)
                {
                    Instantiate(objCableCross, spawnPos, Quaternion.Euler(0, 0, 0));
                    cableCross--;
                }
                break;
            case 11:
                if (RepeaterLDR > 0)
                {
                    Instantiate(objRepeaterLDR, spawnPos, Quaternion.Euler(0, 0, 180));
                    RepeaterLDR--;
                }
                break;
            case 12:
                if (RepeaterLUD > 0)
                {
                    Instantiate(objRepeaterLUD, spawnPos, Quaternion.Euler(0, 0, 90));
                    RepeaterLUD--;
                }
                break;
            case 13:
                if (RepeaterLUR > 0)
                {
                    Instantiate(objRepeaterLUR, spawnPos, Quaternion.Euler(0, 0, 0));
                    RepeaterLUR--;
                }
                break;
            case 14:
                if (RepeaterURD > 0)
                {
                    Instantiate(objRepeaterURD, spawnPos, Quaternion.Euler(0, 0, 270));
                    RepeaterURD--;
                }
                break;
            default:

                break;
        }
    }

    public void MainMenu(string LevelName)
    {
        Menu.GetComponent<scr_MainMenu>().Background.SetActive(true);
        Menu.GetComponent<scr_MainMenu>().OpenMainMenu();

        gameObject.SetActive(false);
    } 

    // Start is called before the first frame update
    void Start()
    {
        Menu = GameObject.FindGameObjectWithTag("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
