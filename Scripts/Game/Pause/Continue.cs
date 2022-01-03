using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Continue : MonoBehaviour
{
    Button btn;
    public GameObject pausemenu;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate() { continueGame(); });
    }

    void Update()
    {
        
    }

    void continueGame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1; 
    }
}
