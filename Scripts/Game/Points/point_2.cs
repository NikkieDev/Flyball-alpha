using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_2 : MonoBehaviour
{

    Rigidbody rb;

    public float speed = 1.19f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        pointA = new Vector3(10.61f, 6.41f, 23.74f);
        pointB = new Vector3(-2.26f, -1.21f, 23.74f);
    }


    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }

}
