using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{

    Rigidbody rb;

    public float speed = 1.19f;
    Vector3 pointA;
    Vector3 pointB;

    public float Ax;
    public float Ay;
    public float Az;

    public float Bx;
    public float By;
    public float Bz;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        pointA = new Vector3(Ax, Ay, Az);
        pointB = new Vector3(Bx, By, Bz);
    }


    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointB, pointA, time);
    }

}
