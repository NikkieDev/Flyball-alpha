using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextButton : MonoBehaviour
{

    private Button btn;
    private Scene SceneCheck;

    private void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(NextLvl);
        SceneCheck = SceneManager.GetActiveScene();
    }

    private void Update()
    {
        
    }


    private void NextLvl()
    {

        if (SceneCheck.name == "Level 1")
        {
            SceneManager.LoadScene("Level 2");
            Time.timeScale = 1;
        } 
        else if (SceneCheck.name == "Level 2")
        {
            SceneManager.LoadScene("Menu");
            Time.timeScale = 1;
        }
    }
}
