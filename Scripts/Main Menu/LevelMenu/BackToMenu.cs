using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{

    Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate() { ToMenu(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }    

    void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
