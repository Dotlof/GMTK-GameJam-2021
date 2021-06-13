using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VolumeData
{
    public float Volume;
    public int UnlockedLevel = 1;

    public VolumeData (scr_Volume_slider volume)
    {
        Volume = volume.Volume;
    }

    public VolumeData (scr_MainMenu level)
    {
        UnlockedLevel = level.UnlockedLevel; 
    }
}
