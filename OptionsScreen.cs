using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class OptionsScreen : MonoBehaviour
{
    public AudioMixer theMixer;
    public Logic logic;

    public TMP_Text mastLabel;
    public Slider masterSlider;
    public Button ResetHighScoreButton;
    public AudioSource button;

    public void SetMasterVol(){
        mastLabel.text = Mathf.RoundToInt(masterSlider.value + 80).ToString();

        theMixer.SetFloat("MasterVol", masterSlider.value);

        PlayerPrefs.SetFloat("MasterVol", masterSlider.value);
        Debug.Log("saving...");
    }

    public void ResetHighScore(){
        button.Play();
        PlayerPrefs.SetInt("HighScore", 0);
    }

    void Start(){
        float vol = 0f;
        theMixer.GetFloat("MasterVol", out vol);
        masterSlider.value = vol;

        mastLabel.text = Mathf.RoundToInt(masterSlider.value + 80).ToString();

        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }
}
