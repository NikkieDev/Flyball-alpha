using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cube : MonoBehaviour
{

    Rigidbody rb;
    public Text txt;
    public int score;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            Destroy(collision.gameObject);
            score = score + 1;

            txt.text = score.ToString();

            if (score == 5)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
