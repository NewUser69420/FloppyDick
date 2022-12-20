using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string GameScene;
    public GameObject optionsScreen;
    public AudioSource button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        button.Play();
        StartCoroutine(Delay1());
    }

    IEnumerator Delay1(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(GameScene);
    }

    public void OpenOptions(){
        optionsScreen.SetActive(true);
        button.Play();
    }
    
    public void CloseOptions(){
        optionsScreen.SetActive(false);
        button.Play();
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Quiting");
        button.Play();
    }
}
