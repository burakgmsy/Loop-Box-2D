using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [Header("UI Manager")]
    public bool isStart=false;
    public GameObject startUI;
    public GameObject gameUI;
    public GameObject loseUI;
    public TMP_Text highScoreText;


    private void Start()
    {
        highScoreText.text = PlayerPrefsManager.Instance.GetHighscore().ToString();
    }


    public void StartGame()
    {
        isStart=true;
        startUI.gameObject.SetActive(false);
        gameUI.gameObject.SetActive(true);
    }

    public void LoseGame()
    {
        isStart=false;
        gameUI.gameObject.SetActive(false);
        loseUI.gameObject.SetActive(true);
    }

    public void LoadScene()
    {
        isStart=false;
        SceneManager.LoadScene("GameScene");
    }
}
