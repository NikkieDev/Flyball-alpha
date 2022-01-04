using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cube : MonoBehaviour
{

    Rigidbody rb;

    public GameObject ResMenu;
    public GameObject NextLvlBtn;
    public GameObject RetryLvlBtn;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        ResMenu.SetActive(false);
        NextLvlBtn.SetActive(false);
        RetryLvlBtn.SetActive(false);
    }

    private void Update()
    {
        // Movement
        if (Input.GetKeyDown("w"))
        {
            rb.AddForce(Vector3.forward * 500);
        } else if (Input.GetKeyDown("s"))
        {
            rb.AddForce(Vector3.back * 500);
        } else if (Input.GetKeyDown("a"))
        {
            rb.AddForce(Vector3.left * 500);
        } else if (Input.GetKeyDown("d"))
        {
            rb.AddForce(Vector3.right * 500);
        } else if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 500);
        } else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.AddForce(Vector3.down * 500);
        }
    }

    // Collision

    public Text ScoreText;
    public Text GameResultText;
    public int score;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            Destroy(collision.gameObject);
            
            score = score + 1;
            ScoreText.text = score.ToString();

            if (score >= 5)
            {
                ResMenu.SetActive(true);
                NextLvlBtn.SetActive(true);
                
                RetryLvlBtn.SetActive(false);
                Time.timeScale = 0;
            }
        } 
        
        else if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            
            ResMenu.SetActive(true);
            RetryLvlBtn.SetActive(true);

            NextLvlBtn.SetActive(false);

            ScoreText.text = "GAME OVER";
            GameResultText.text = "GAME OVER";
            Time.timeScale = 0;
        }
    }
}
