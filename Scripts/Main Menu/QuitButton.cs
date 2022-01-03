using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate() { quitGame(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
        void quitGame()
    {
        Application.Quit();
    }
}
