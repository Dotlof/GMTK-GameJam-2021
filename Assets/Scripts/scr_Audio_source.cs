using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Audio_source : MonoBehaviour
{

    AudioSource audioSource;
    public GameObject VolumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = VolumeSlider.gameObject.GetComponent<scr_Volume_slider>().Volume;
    }
}
