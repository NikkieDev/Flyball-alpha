using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelButton : MonoBehaviour
{

    private Button btn;

    private void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(ToLevels);
    }


    private void Update()
    {
        
    }

    private void ToLevels()
    {
        SceneManager.LoadScene("Level Menu");
    }
}
