/*
 * Josh McGrew
 * Assignment 6
 * player movement
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontalInput, verticalInput, speed;

    private void Start()
    {
        speed = 10;
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //movement
        transform.Translate(Vector3.back * speed * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.left * speed * Time.deltaTime * horizontalInput);
    }
}
