using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_4 : MonoBehaviour
{

    Rigidbody rb;

    public float speed = 1.19f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        pointA = new Vector3(10.1f, -3.422f, 28.05f);
        pointB = new Vector3(7.21f, -1.91f, 37.83f);
    }


    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }

}
