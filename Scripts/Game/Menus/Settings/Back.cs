using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Back : MonoBehaviour
{

    Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate() { PauseMenu(); });
    }
    
    public GameObject pausemenu;
    public GameObject settings;

    void Update()
    {
        
    }

    void PauseMenu()
    {
        pausemenu.SetActive(true);
        settings.SetActive(false);
    }
}
