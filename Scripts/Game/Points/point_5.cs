using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_5 : MonoBehaviour
{

    Rigidbody rb;

    public float speed = 3.14f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        pointA = new Vector3(6.65f, 1.86f, 19.29f);
        pointB = new Vector3(3.62f, 5.95f, 23.93f);
    }


    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB,  time);
    }

}
