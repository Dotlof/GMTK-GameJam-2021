using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_Volume_slider : MonoBehaviour
{
    Slider slider;
    public float Volume;

    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
        VolumeData data = SaveSystem.LoadVolume();

        Volume = data.Volume;
        slider.value = Volume;
    }

    // Update is called once per frame
    void Update()
    {
        Volume = slider.value;
        slider.value = Volume;
    }
    public void SaveVolume()
    {
        SaveSystem.SaveVolume(this);
    }
}
