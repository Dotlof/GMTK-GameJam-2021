using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VolumeData
{
    public float Volume;

    public VolumeData (scr_Volume_slider volume)
    {
        Volume = volume.Volume;
    }
}
