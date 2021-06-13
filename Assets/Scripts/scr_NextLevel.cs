using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class scr_NextLevel : MonoBehaviour
{
    public int LevelID;

    // Start is called before the first frame update
    void Start()
    {
        
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
        //LoadNextScene
    }

}
