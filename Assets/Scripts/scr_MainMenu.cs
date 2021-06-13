using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_MainMenu : MonoBehaviour
{
    public GameObject Credits;
    public GameObject Options;
    public GameObject MainMenu;
    public GameObject LevelSelect;

    public GameObject Lock2;
    public GameObject Lock3;
    public GameObject Lock4;
    public GameObject Lock5;
    public GameObject Lock6;
    public GameObject Lock7;
    public GameObject Lock8;
    public GameObject Lock9;
    public GameObject Lock10;

    public int UnlockedLevel;

    public void OpenOptions()
    {
        Credits.SetActive(false);
        Options.SetActive(true);
        MainMenu.SetActive(false);
        LevelSelect.SetActive(false);
    }
    public void OpenMainMenu()
    {
        Credits.SetActive(false);
        Options.SetActive(false);
        MainMenu.SetActive(true);
        LevelSelect.SetActive(false);
    }
    public void OpenCredits()
    {
        Credits.SetActive(true);
        Options.SetActive(false);
        MainMenu.SetActive(false);
        LevelSelect.SetActive(false);
    }
    public void OpenLevelSelect()
    {
        Credits.SetActive(false);
        Options.SetActive(false);
        MainMenu.SetActive(false);
        LevelSelect.SetActive(true);
    }

    public void OpenLevel(int level)
    {
        if (UnlockedLevel >= level)
        {
            SceneManager.LoadScene("Level" + level);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
        Options.SetActive(true);
        Options.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (UnlockedLevel >= 2)
        {
            Lock2.SetActive(false);
        }
        else
        {
            Lock2.SetActive(true);
        }

        if (UnlockedLevel >= 3)
        {
            Lock3.SetActive(false);
        }
        else
        {
            Lock3.SetActive(true);
        }

        if (UnlockedLevel >= 4)
        {
            Lock4.SetActive(false);
        }
        else
        {
            Lock4.SetActive(true);
        }

        if (UnlockedLevel >= 5)
        {
            Lock5.SetActive(false);
        }
        else
        {
            Lock5.SetActive(true);
        }

        if (UnlockedLevel >= 6)
        {
            Lock6.SetActive(false);
        }
        else
        {
            Lock6.SetActive(true);
        }

        if (UnlockedLevel >= 7)
        {
            Lock7.SetActive(false);
        }
        else
        {
            Lock7.SetActive(true);
        }

        if (UnlockedLevel >= 8)
        {
            Lock8.SetActive(false);
        }
        else
        {
            Lock8.SetActive(true);
        }

        if (UnlockedLevel >= 9)
        {
            Lock9.SetActive(false);
        }
        else
        {
            Lock9.SetActive(true);
        }

        if (UnlockedLevel >= 10)
        {
            Lock10.SetActive(false);
        }
        else
        {
            Lock10.SetActive(true);
        }
    }
}
