using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public AudioMixer theMixer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("preparing to load...");
        if(PlayerPrefs.HasKey("MasterVol")){
            theMixer.SetFloat("MasterVol", PlayerPrefs.GetFloat("Mastervol"));
            Debug.Log("loading...");
        }
    }
}
