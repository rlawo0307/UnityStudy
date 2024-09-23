using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestMain : MonoBehaviour
{
    public Slider slider;
    public Button btnSave;

    void Start()
    {
        float musicVolume = 0;

        //newbie의 값이 1이면 신규유저
        bool newbie = PlayerPrefs.GetInt("newbie", 1) == 1 ? true : false;
        Debug.Log(newbie);

        if (newbie)
        {
            musicVolume = 1;
            PlayerPrefs.SetInt("newbie", 0);
        }
        else
        {
            musicVolume = PlayerPrefs.GetFloat("musicVolume");
        }

        Debug.Log(musicVolume);

        slider.value = musicVolume;

        slider.onValueChanged.AddListener((val) => {
            Debug.Log(val);
            PlayerPrefs.SetFloat("musicVolume", val);
        });

        btnSave.onClick.AddListener(() => {
            PlayerPrefs.Save();
        });
    }
}
