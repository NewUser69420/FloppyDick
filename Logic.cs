using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public int playerScore;
    public Text HighScore;
    public Text scoreText;
    public GameObject GameOverScreen;
    public AudioSource Ding;
    public AudioSource button;
    public string MainMenu;

    void Start(){
        HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd){
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        Ding.Play();

        if(playerScore > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", playerScore);
            HighScore.text = playerScore.ToString();
        }
    }

    public void restartGame(){
        button.Play();
        StartCoroutine(Delay2());
    }

    IEnumerator Delay2(){
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame(){
        button.Play();
        StartCoroutine(Delay1());
    }

    IEnumerator Delay1(){
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene(MainMenu);
        }

    public void GameOver(){
        GameOverScreen.SetActive(true);

    }
    
}
