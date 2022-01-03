using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_3 : MonoBehaviour
{

    Rigidbody rb;

    public float speed = 1.19f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        pointA = new Vector3(-3.82f, 7.44f, 38.05f);
        pointB = new Vector3(-4.02f, -2.58f, 20.78f);
    }


    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }

}
