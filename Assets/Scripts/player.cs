using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
 
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.forward, Time.deltaTime * 200.0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.forward, Time.deltaTime * -200.0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * 10.0f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.up * 10.0f * Time.deltaTime;
        }
        Debug.DrawRay(transform.position, transform.up * 10f, Color.green);

    }

}
