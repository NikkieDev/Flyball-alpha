using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level1 : MonoBehaviour
{

    Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate() { StartLevel(); });
    }

    void Update()
    {
        
    }

    void StartLevel()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1;
    }
}
