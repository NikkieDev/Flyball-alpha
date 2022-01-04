using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{

    private Button StartBtn;
    private Button QuitBtn;

    private void Awake()
    {
        QuitBtn = GetComponent<Button>();
    }

    private void Start()
    {
        StartBtn = GetComponent<Button>();
        QuitBtn = GameObject.Find("/Canvas/QuitButton").GetComponent<Button>();

        StartBtn.onClick.AddListener(delegate() { LevelMenu(); });
        QuitBtn.onClick.AddListener(delegate() {quitGame(); });
    }

    private void Update()
    {
        
    }    

    private void LevelMenu()
    {
        SceneManager.LoadScene("Level Menu");
    }

    private void quitGame()
    {
        Application.Quit();
    }
}
