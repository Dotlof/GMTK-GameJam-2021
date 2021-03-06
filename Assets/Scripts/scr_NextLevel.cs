using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class scr_NextLevel : MonoBehaviour
{
    public int UnlockedLevel;
    int nextlevel;
    public GameObject Menu;
    public GameObject HUD;

    // Start is called before the first frame update
    void Start()
    {
        nextlevel = UnlockedLevel + 1;
        Menu = GameObject.FindGameObjectWithTag("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<scr_ComponentPowerCheck>().powered == true)
        {
            NextLevel();
        }
    }

    public void NextLevel()
    {
        //SaveIntoMemory
        if (Menu.gameObject.GetComponent<scr_MainMenu>().UnlockedLevel <= UnlockedLevel && UnlockedLevel != 10)
        {
            Menu.gameObject.GetComponent<scr_MainMenu>().UnlockedLevel = nextlevel;
            Menu.gameObject.GetComponent<scr_MainMenu>().SaveLevel();
        }
        if (UnlockedLevel == 10)
        {
            HUD.SetActive(true);
        }
        else
        {
            //LoadNextScene
            SceneManager.LoadScene("Level" + nextlevel);
        }

    }

}
