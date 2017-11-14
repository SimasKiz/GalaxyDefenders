using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioSettings : MonoBehaviour
{

    public Slider musicVolume;
    public Slider soundEffVolume;
    public AudioSource audioSource;
	
	// Update is called once per frame
	void Update ()
	{
	    audioSource.volume = musicVolume.value;
	}

    public void SaveSliderValue()
    {
        PlayerPrefs.SetFloat("MusicSliderVolumeLevel", musicVolume.value);
        PlayerPrefs.SetFloat("SoundEffSliderVolumeLevel", soundEffVolume.value);
    }
}
