using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateMusic : MonoBehaviour
{
    List<AudioSource> music = new List<AudioSource>();

    // Start is called before the first frame update
    public void Start()
    {
        // Finding audio source on gamedata 
        AudioSource[] allAS = GameObject.FindWithTag("gamedata").GetComponentsInChildren<AudioSource>(); 
        // 0 element in array is the main game music
        music.Add(allAS[0]);

        // Getting slider to set and save value
        Slider musicSlider = this.GetComponent<Slider>();

        if(PlayerPrefs.HasKey("musicvolume"))
        {
            musicSlider.value = PlayerPrefs.GetFloat("musicvolume");
            UpdateMusicVolume(musicSlider.value);
        }
        else
        {
            musicSlider.value = 1;
            UpdateMusicVolume(1);
        }
    }

    // Adjusting audio volume
    public void UpdateMusicVolume(float value)
    {
        // Updating prefs
        PlayerPrefs.SetFloat("musicvolume", value);

        foreach(AudioSource m in music)
        {
            m.volume = value;
        }
    }
}
