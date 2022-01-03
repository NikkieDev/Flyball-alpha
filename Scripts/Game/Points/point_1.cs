using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_1 : MonoBehaviour
{

    Rigidbody rb;

    public float speed = 1.19f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        pointA = new Vector3(10.1f, 8.13f, 28.05f);
        pointB = new Vector3(10.1f, -3.422f, 28.05f);
    }


    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }

}
