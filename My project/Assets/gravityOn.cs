using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityOn : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            rb.useGravity = true;
        }
    }
}
