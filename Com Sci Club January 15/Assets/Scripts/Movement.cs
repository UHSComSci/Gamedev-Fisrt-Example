using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 100;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, 0, speed) * Time.deltaTime);

        //if (Input.GetKey("w"))
        //{
        //    rb.AddForce(new Vector3(0, 0, speed) * Time.deltaTime);
        //}
        //if (Input.GetKey("s"))
        //{
        //    rb.AddForce(new Vector3(0, 0, -speed) * Time.deltaTime);
        //}

        if (Input.GetKey("a"))
            rb.AddForce(new Vector3(-speed, 0, 0) * Time.deltaTime);
        if (Input.GetKey("d"))
            rb.AddForce(new Vector3(speed, 0, 0) * Time.deltaTime);

        FindObjectOfType<GameManager>().UpdateScore(transform.position.z);
    }
}
