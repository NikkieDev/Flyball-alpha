using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Settings : MonoBehaviour
{
    Button btn;
    
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate() { SettingsMenu(); });
    }

    void Update()
    {
        
    }

    public GameObject pausemenu;
    public GameObject settings;

    void SettingsMenu()
    {
        if (pausemenu == true) 
        {
            pausemenu.SetActive(false);
            settings.SetActive(true);
        } else
        {
            pausemenu.SetActive(true);
            settings.SetActive(false);
        }
    }
}
