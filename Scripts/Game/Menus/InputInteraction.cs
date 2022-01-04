using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InputInteraction : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pausemenu;
    
    void Start()
    {
        pausemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu();
        }
    }

    void PauseMenu()
    {
        if (Time.timeScale == 1)
        {
            pausemenu.SetActive(true);
            Time.timeScale = 0;
        } else
        {
            pausemenu.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
