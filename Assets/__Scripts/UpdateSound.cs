using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateSound : MonoBehaviour
{
    List<AudioSource> sfx = new List<AudioSource>();

    // Start is called before the first frame update
    public void Start()
    {
        AudioSource[] allAS = GameObject.FindWithTag("gamedata").GetComponentsInChildren<AudioSource>(); 
        
        // Getting array of sound effects and Assigning all audio sources to sound volume slider
        for(int i = 1; i < allAS.Length; i++){
            sfx.Add(allAS[i]);
        }

        // Getting slider to set and save value
        Slider sfxSlider = this.GetComponent<Slider>();

        // Getting prefs and setting volume
        if(PlayerPrefs.HasKey("sfxvolume"))
        {
            sfxSlider.value = PlayerPrefs.GetFloat("sfxvolume");
            UpdateSoundVolume(sfxSlider.value);
        }
        else
        {
            sfxSlider.value = 1;
            UpdateSoundVolume(1);
        }
    }

    // Adjusting audio volume
    public void UpdateSoundVolume(float value)
    {
        // Updating prefs
        PlayerPrefs.SetFloat("sfxvolume", value);

        foreach(AudioSource s in sfx)
        {
            s.volume = value;
        }
    }
}