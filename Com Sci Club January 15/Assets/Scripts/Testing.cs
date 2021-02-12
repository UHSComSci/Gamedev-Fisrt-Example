using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Time.deltaTime * Input.GetAxis("Vertical"), 0f, Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
